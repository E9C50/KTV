/*
 * Copyright (C) 2010 ZXing authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package cn.ktv.ktvphone.scanner;

import java.io.IOException;

import android.app.Activity;
import android.content.Context;
import android.content.SharedPreferences;
import android.content.res.AssetFileDescriptor;
import android.media.AudioManager;
import android.media.MediaPlayer;
import android.os.Vibrator;
import android.preference.PreferenceManager;
import android.util.Log;
import cn.ktv.ktvphone.R;
import cn.ktv.ktvphone.scanner.config.Config;

/**
 * Manages beeps and vibrations for {@link CaptureActivity}.
 */
final class BeepManager implements MediaPlayer.OnCompletionListener,
		MediaPlayer.OnErrorListener {

	private static final String TAG = BeepManager.class.getSimpleName();

	private static final float BEEP_VOLUME = 0.10f;

	private static final long VIBRATE_DURATION = 200L;

	private final Activity activity;

	private MediaPlayer mediaPlayer;

	private boolean playBeep;

	private boolean vibrate;

	BeepManager(Activity activity) {
		this.activity = activity;
		this.mediaPlayer = null;
		updatePrefs();
	}

	/**
	 * 鎵弿鎴愬姛鍚庡彲浠ユ挱鏀炬彁绀洪煶骞堕渿鍔紝杩欎袱绉嶅姛鑳介兘鏄敤鎴疯嚜瀹氫箟鐨� 鍦˙arcode Scanner涓偣鍑昏彍鍗曢敭锛岀偣璁剧疆鍗冲彲鐪嬪埌杩欎袱椤圭殑璁剧疆
	 */
	synchronized void updatePrefs() {
		SharedPreferences prefs = PreferenceManager
				.getDefaultSharedPreferences(activity);
		playBeep = shouldBeep(prefs, activity);
		vibrate = prefs.getBoolean(Config.KEY_VIBRATE, false);
		if (playBeep && mediaPlayer == null) {
			// The volume on STREAM_SYSTEM is not adjustable, and users found it
			// too loud,
			// so we now play on the music stream.
			activity.setVolumeControlStream(AudioManager.STREAM_MUSIC);
			mediaPlayer = buildMediaPlayer(activity);
		}
	}

	/**
	 * 鏍规嵁閰嶇疆鎾斁鎻愮ず闊冲拰闇囧姩
	 */
	synchronized void playBeepSoundAndVibrate() {
		if (playBeep && mediaPlayer != null) {
			mediaPlayer.start();
		}
		if (vibrate) {
			Vibrator vibrator = (Vibrator) activity
					.getSystemService(Context.VIBRATOR_SERVICE);
			vibrator.vibrate(VIBRATE_DURATION);
		}
	}

	private static boolean shouldBeep(SharedPreferences prefs, Context activity) {
		boolean shouldPlayBeep = prefs.getBoolean(Config.KEY_PLAY_BEEP, true);
		if (shouldPlayBeep) {
			// See if sound settings overrides this
			AudioManager audioService = (AudioManager) activity
					.getSystemService(Context.AUDIO_SERVICE);
			if (audioService.getRingerMode() != AudioManager.RINGER_MODE_NORMAL) {
				shouldPlayBeep = false;
			}
		}
		return shouldPlayBeep;
	}

	private MediaPlayer buildMediaPlayer(Context activity) {
		MediaPlayer mediaPlayer = new MediaPlayer();
		mediaPlayer.setAudioStreamType(AudioManager.STREAM_MUSIC);
		mediaPlayer.setOnCompletionListener(this);
		mediaPlayer.setOnErrorListener(this);

		AssetFileDescriptor file = activity.getResources().openRawResourceFd(
				R.raw.beep);
		try {
			mediaPlayer.setDataSource(file.getFileDescriptor(),
					file.getStartOffset(), file.getLength());
			file.close();
			mediaPlayer.setVolume(BEEP_VOLUME, BEEP_VOLUME);
			mediaPlayer.prepare();
		}
		catch (IOException ioe) {
			Log.w(TAG, ioe);
			mediaPlayer = null;
		}
		return mediaPlayer;
	}

	public void onCompletion(MediaPlayer mp) {
		// When the beep has finished playing, rewind to queue up another one.
		mp.seekTo(0);
	}

	public synchronized boolean onError(MediaPlayer mp, int what, int extra) {
		if (what == MediaPlayer.MEDIA_ERROR_SERVER_DIED) {
			// we are finished, so put up an appropriate error toast if required
			// and finish
			activity.finish();
		}
		else {
			// possibly media player error, so release and recreate
			mp.release();
			mediaPlayer = null;
			updatePrefs();
		}
		return true;
	}

	/**
	 * 鏂板
	 * 鍏抽棴beep澹伴煶
	 */
	public synchronized void close() {
		if (mediaPlayer != null) {
			mediaPlayer.release();
			mediaPlayer = null;
		}
	}

}
