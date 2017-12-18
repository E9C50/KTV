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

package cn.ktv.ktvphone.scanner.camera;

import android.graphics.Point;
import android.hardware.Camera;
import android.os.Handler;
import android.os.Message;
import android.util.Log;

/**
 * 璇ョ被鐨勪綔鐢ㄦ槸鍦ㄩ瑙堢晫闈㈠姞杞藉ソ鍚庡悜ui绾跨▼鍙戞秷鎭�
 */
final class PreviewCallback implements Camera.PreviewCallback {

	private static final String TAG = PreviewCallback.class.getSimpleName();

	private final CameraConfigurationManager configManager;
	private Handler previewHandler;
	private int previewMessage;

	PreviewCallback(CameraConfigurationManager configManager) {
		this.configManager = configManager;
	}

	/**
	 * 缁戝畾handler锛岀敤浜庡彂娑堟伅鍒皍i绾跨▼
	 * 
	 * @param previewHandler
	 * @param previewMessage
	 */
	void setHandler(Handler previewHandler, int previewMessage) {
		this.previewHandler = previewHandler;
		this.previewMessage = previewMessage;
	}

	public void onPreviewFrame(byte[] data, Camera camera) {
		Point cameraResolution = configManager.getCameraResolution();
		Handler thePreviewHandler = previewHandler;
		if (cameraResolution != null && thePreviewHandler != null) {
			Message message = thePreviewHandler.obtainMessage(previewMessage, cameraResolution.x, cameraResolution.y,
					data);
			message.sendToTarget();
			previewHandler = null;
		} else {
			Log.d(TAG, "Got preview callback, but no handler or resolution available");
		}
	}

}
