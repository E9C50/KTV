/*
 * Copyright (C) 2012 ZXing authors
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

import android.content.Context;
import android.content.SharedPreferences;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.preference.PreferenceManager;
import cn.ktv.ktvphone.scanner.camera.CameraManager;
import cn.ktv.ktvphone.scanner.camera.FrontLightMode;

/**
 * Detects ambient light and switches on the front light when very dark, and off
 * again when sufficiently light.
 * 
 * @author Sean Owen
 * @author Nikolaus Huber
 */
final class AmbientLightManager implements SensorEventListener {

	private static final float TOO_DARK_LUX = 45.0f;
	private static final float BRIGHT_ENOUGH_LUX = 450.0f;

	private final Context context;
	private CameraManager cameraManager;

	/**
	 * 鍏変紶鎰熷櫒
	 */
	private Sensor lightSensor;

	AmbientLightManager(Context context) {
		this.context = context;
	}

	void start(CameraManager cameraManager) {
		this.cameraManager = cameraManager;
		SharedPreferences sharedPrefs = PreferenceManager
				.getDefaultSharedPreferences(context);
		if (FrontLightMode.readPref(sharedPrefs) == FrontLightMode.AUTO) {
			SensorManager sensorManager = (SensorManager) context
					.getSystemService(Context.SENSOR_SERVICE);
			lightSensor = sensorManager.getDefaultSensor(Sensor.TYPE_LIGHT);
			if (lightSensor != null) {
				sensorManager.registerListener(this, lightSensor,
						SensorManager.SENSOR_DELAY_NORMAL);
			}
		}
	}

	void stop() {
		if (lightSensor != null) {
			SensorManager sensorManager = (SensorManager) context
					.getSystemService(Context.SENSOR_SERVICE);
			sensorManager.unregisterListener(this);
			cameraManager = null;
			lightSensor = null;
		}
	}

	/**
	 * 璇ユ柟娉曚細鍦ㄥ懆鍥寸幆澧冩敼鍙樺悗鍥炶皟锛岀劧鍚庢牴鎹缃ソ鐨勪复鐣屽�煎喅瀹氭槸鍚︽墦寮�闂厜鐏�
	 */
	public void onSensorChanged(SensorEvent sensorEvent) {
		float ambientLightLux = sensorEvent.values[0];
		if (cameraManager != null) {
			if (ambientLightLux <= TOO_DARK_LUX) {
				cameraManager.setTorch(true);
			}
			else if (ambientLightLux >= BRIGHT_ENOUGH_LUX) {
				cameraManager.setTorch(false);
			}
		}
	}

	public void onAccuracyChanged(Sensor sensor, int accuracy) {
		// do nothing
	}

}
