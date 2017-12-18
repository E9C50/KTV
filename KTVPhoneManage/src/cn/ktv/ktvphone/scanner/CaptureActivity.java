package cn.ktv.ktvphone.scanner;

import java.io.IOException;
import java.lang.ref.WeakReference;
import java.util.Collection;
import java.util.Map;

import android.R.string;
import android.app.Activity;
import android.app.ProgressDialog;
import android.content.Intent;
import android.database.Cursor;
import android.graphics.Bitmap;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.provider.MediaStore;
import android.provider.MediaStore.MediaColumns;
import android.util.Log;
import android.view.KeyEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Toast;
import cn.ktv.ktvphone.R;
import cn.ktv.ktvphone.activity.MainActivity;
import cn.ktv.ktvphone.connection.ClientConnection;
import cn.ktv.ktvphone.scanner.camera.CameraManager;
import cn.ktv.ktvphone.scanner.common.BitmapUtils;
import cn.ktv.ktvphone.scanner.decode.BitmapDecoder;
import cn.ktv.ktvphone.scanner.decode.CaptureActivityHandler;
import cn.ktv.ktvphone.scanner.view.ViewfinderView;

import com.google.zxing.BarcodeFormat;
import com.google.zxing.DecodeHintType;
import com.google.zxing.Result;
import com.google.zxing.client.result.ResultParser;

public final class CaptureActivity extends Activity implements
		SurfaceHolder.Callback, View.OnClickListener {

	private static final String TAG = CaptureActivity.class.getSimpleName();

	private static final int REQUEST_CODE = 100;

	private static final int PARSE_BARCODE_FAIL = 300;
	private static final int PARSE_BARCODE_SUC = 200;

	private boolean hasSurface;

	private InactivityTimer inactivityTimer;

	private BeepManager beepManager;

	private AmbientLightManager ambientLightManager;

	private CameraManager cameraManager;

	private ViewfinderView viewfinderView;

	private CaptureActivityHandler handler;

	private Result lastResult;

	private boolean isFlashlightOpen;

	private Collection<BarcodeFormat> decodeFormats;

	private Map<DecodeHintType, ?> decodeHints;

	private String characterSet;

	private Result savedResultToShow;

	private IntentSource source;

	private String photoPath;

	private Handler mHandler = new MyHandler(this);

	static class MyHandler extends Handler {

		private WeakReference<Activity> activityReference;

		public MyHandler(Activity activity) {
			activityReference = new WeakReference<Activity>(activity);
		}

		@Override
		public void handleMessage(Message msg) {

			switch (msg.what) {
			case PARSE_BARCODE_SUC: // 鐟欙絾鐎介崶鍓у閹存劕濮�
				Toast.makeText(activityReference.get(),
						"鐟欙絾鐎介幋鎰閿涘瞼绮ㄩ弸婊�璐熼敍锟�" + msg.obj, Toast.LENGTH_SHORT)
						.show();
				break;

			case PARSE_BARCODE_FAIL:// 鐟欙絾鐎介崶鍓у婢惰精瑙�

				Toast.makeText(activityReference.get(), "鐟欙絾鐎介崶鍓у婢惰精瑙�",
						Toast.LENGTH_SHORT).show();
				break;

			default:
				break;
			}

			super.handleMessage(msg);
		}

	}

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);

		Window window = getWindow();
		window.addFlags(WindowManager.LayoutParams.FLAG_KEEP_SCREEN_ON);
		setContentView(R.layout.activity_scanner);

		hasSurface = false;
		inactivityTimer = new InactivityTimer(this);
		beepManager = new BeepManager(this);
		ambientLightManager = new AmbientLightManager(this);

		findViewById(R.id.capture_flashlight).setOnClickListener(this);

	}

	@Override
	protected void onResume() {
		super.onResume();

		// CameraManager must be initialized here, not in onCreate(). This is
		// necessary because we don't
		// want to open the camera driver and measure the screen size if we're
		// going to show the help on
		// first launch. That led to bugs where the scanning rectangle was the
		// wrong size and partially
		// off screen.

		// 閻╁憡婧�閸掓繂顫愰崠鏍畱閸斻劋缍旈棁锟界憰浣哥磻閸氼垳娴夐張鍝勮嫙濞村鍣虹仦蹇撶婢堆冪毈閿涘矁绻栨禍娑欐惙娴ｏ拷
		// 娑撳秴缂撶拋顔芥杹閸掔殎nCreate娑擃叏绱濋崶鐘辫礋婵″倹鐏夐崷鈺玭Create娑擃厼濮炴稉濠囶浕濞嗏�虫儙閸斻劌鐫嶇粈鍝勫簻閸斺晙淇婇幁顖滄畱娴狅絿鐖滈惃锟�
		// 鐠囨繐绱�
		// 娴兼艾顕遍懛瀛樺閹诲繒鐛ラ崣锝囨畱鐏忓搫顕拋锛勭暬閺堝顕ら惃鍒g
		cameraManager = new CameraManager(getApplication());

		viewfinderView = (ViewfinderView) findViewById(R.id.capture_viewfinder_view);
		viewfinderView.setCameraManager(cameraManager);

		handler = null;
		lastResult = null;

		// 閹藉嫬鍎氭径鎾暕鐟欏牆濮涢懗钘夌箑妞よ锟界喎濮猄urfaceView閿涘苯娲滃銈勭瘍闂囷拷鐟曚礁婀稉锟藉锟芥慨瀣嚠閸忔儼绻樼悰灞藉灥婵瀵�
		// 婵″倹鐏夐棁锟界憰浣风啊鐟欘枡urfaceView閻ㄥ嫬甯悶锟�
		// 閸欏倽锟斤拷:http://blog.csdn.net/luoshengyang/article/details/8661317
		SurfaceView surfaceView = (SurfaceView) findViewById(R.id.capture_preview_view); // 妫板嫯顫�
		SurfaceHolder surfaceHolder = surfaceView.getHolder();
		if (hasSurface) {
			// The activity was paused but not stopped, so the surface still
			// exists. Therefore
			// surfaceCreated() won't be called, so init the camera here.
			initCamera(surfaceHolder);

		} else {
			// 闂冨弶顒泂dk8閻ㄥ嫯顔曟径鍥у灥婵瀵叉０鍕潔瀵倸鐖�
			surfaceHolder.setType(SurfaceHolder.SURFACE_TYPE_PUSH_BUFFERS);

			// Install the callback and wait for surfaceCreated() to init the
			// camera.
			surfaceHolder.addCallback(this);
		}

		// 閸旂姾娴囨竟浼寸叾闁板秶鐤嗛敍灞藉従鐎圭偛婀狟eemManager閻ㄥ嫭鐎柅鐘叉珤娑擃厺绡冩导姘崇殶閻€劏顕氶弬瑙勭《閿涘苯宓嗛崷鈺玭Create閻ㄥ嫭妞傞崐娆庣窗鐠嬪啰鏁ゆ稉锟藉▎锟�
		beepManager.updatePrefs();

		// 閸氼垰濮╅梻顏勫帨閻忣垵鐨熼懞鍌氭珤
		ambientLightManager.start(cameraManager);

		// 閹垹顦插ú璇插З閻╂垶甯堕崳锟�
		inactivityTimer.onResume();

		source = IntentSource.NONE;
		decodeFormats = null;
		characterSet = null;
	}

	@Override
	protected void onPause() {
		if (handler != null) {
			handler.quitSynchronously();
			handler = null;
		}
		inactivityTimer.onPause();
		ambientLightManager.stop();
		beepManager.close();

		// 閸忔娊妫撮幗鍕剼婢讹拷
		cameraManager.closeDriver();
		if (!hasSurface) {
			SurfaceView surfaceView = (SurfaceView) findViewById(R.id.capture_preview_view);
			SurfaceHolder surfaceHolder = surfaceView.getHolder();
			surfaceHolder.removeCallback(this);
		}
		super.onPause();
	}

	@Override
	protected void onDestroy() {
		inactivityTimer.shutdown();
		super.onDestroy();
	}

	@Override
	public boolean onKeyDown(int keyCode, KeyEvent event) {
		switch (keyCode) {
		case KeyEvent.KEYCODE_BACK:
			if ((source == IntentSource.NONE) && lastResult != null) { // 闁插秵鏌婃潻娑滎攽閹殿偅寮�
				restartPreviewAfterDelay(0L);
				return true;
			}
			break;
		case KeyEvent.KEYCODE_FOCUS:
		case KeyEvent.KEYCODE_CAMERA:
			// Handle these events so they don't launch the Camera app
			return true;

		case KeyEvent.KEYCODE_VOLUME_UP:
			cameraManager.zoomIn();
			return true;

		case KeyEvent.KEYCODE_VOLUME_DOWN:
			cameraManager.zoomOut();
			return true;

		}
		return super.onKeyDown(keyCode, event);
	}

	public void surfaceCreated(SurfaceHolder holder) {
		if (holder == null) {
			Log.e(TAG,
					"*** WARNING *** surfaceCreated() gave us a null surface!");
		}
		if (!hasSurface) {
			hasSurface = true;
			initCamera(holder);
		}
	}

	public void surfaceChanged(SurfaceHolder holder, int format, int width,
			int height) {
		/* hasSurface = false; */
	}

	public void surfaceDestroyed(SurfaceHolder holder) {
		hasSurface = false;
	}

	public void handleDecode(Result rawResult, Bitmap barcode, float scaleFactor) {

		inactivityTimer.onActivity();

		lastResult = rawResult;

		viewfinderView.drawResultBitmap(barcode);

		beepManager.playBeepSoundAndVibrate();

		String address = ResultParser.parseResult(rawResult).toString();
		
		try {
			final String ip = address.substring(0,address.indexOf(":"));
			final int post = Integer.parseInt(address.substring(address.indexOf(":") + 1,address.length()));
			System.out.println(ip + "|" + post);
			if (isIp(ip) && post >= 0 && post <= 65535) {
				Intent intent=new Intent(CaptureActivity.this,MainActivity.class);
                intent.putExtra("ip", ip);
                intent.putExtra("post",	Integer.toString(post));
                setResult(RESULT_OK, intent);
				finish();
			} else {
				Toast.makeText(getBaseContext(), R.string.scan_failed, Toast.LENGTH_LONG).show();
				finish();
			}
		} catch (Exception e) {
			System.out.println(e);
			Toast.makeText(getBaseContext(), R.string.scan_failed, Toast.LENGTH_LONG).show();
			finish();
		}
		
	}  
	public boolean isIp(String IP){//判断是否是一个IP
		boolean b = false;
		IP = IP.trim();
		if(IP.matches("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}")){
		String s[] = IP.split("\\.");
		if(Integer.parseInt(s[0])<255)
		if(Integer.parseInt(s[1])<255)
		if(Integer.parseInt(s[2])<255)
		if(Integer.parseInt(s[3])<255)
			b = true;
		}
			return b;
	}
	public void restartPreviewAfterDelay(long delayMS) {
		if (handler != null) {
			handler.sendEmptyMessageDelayed(R.id.restart_preview, delayMS);
		}
		resetStatusView();
	}

	public ViewfinderView getViewfinderView() {
		return viewfinderView;
	}

	public Handler getHandler() {
		return handler;
	}

	public CameraManager getCameraManager() {
		return cameraManager;
	}

	private void resetStatusView() {
		viewfinderView.setVisibility(View.VISIBLE);
		lastResult = null;
	}

	public void drawViewfinder() {
		viewfinderView.drawViewfinder();
	}

	private void initCamera(SurfaceHolder surfaceHolder) {
		if (surfaceHolder == null) {
			throw new IllegalStateException("No SurfaceHolder provided");
		}

		if (cameraManager.isOpen()) {
			Log.w(TAG,
					"initCamera() while already open -- late SurfaceView callback?");
			return;
		}
		try {
			cameraManager.openDriver(surfaceHolder);
			// Creating the handler starts the preview, which can also throw a
			// RuntimeException.
			if (handler == null) {
				handler = new CaptureActivityHandler(this, decodeFormats,
						decodeHints, characterSet, cameraManager);
			}
			decodeOrStoreSavedBitmap(null, null);
		} catch (IOException ioe) {
			Log.w(TAG, ioe);
			Toast.makeText(getBaseContext(), R.string.scan_failed,
					Toast.LENGTH_LONG).show();
		} catch (RuntimeException e) {
			// Barcode Scanner has seen crashes in the wild of this variety:
			// java.?lang.?RuntimeException: Fail to connect to camera service
			Log.w(TAG, "Unexpected error initializing camera", e);
			Toast.makeText(getBaseContext(),R.string.cinema_Allow,
					Toast.LENGTH_LONG).show();
		}
	}

	/**
	 * 閸氭厤aptureActivityHandler娑擃厼褰傞柅浣圭Х閹垽绱濋獮璺虹潔缁�鐑樺閹诲繐鍩岄惃鍕禈閸嶏拷
	 * 
	 * @param bitmap
	 * @param result
	 */
	private void decodeOrStoreSavedBitmap(Bitmap bitmap, Result result) {
		// Bitmap isn't used yet -- will be used soon
		if (handler == null) {
			savedResultToShow = result;
		} else {
			if (result != null) {
				savedResultToShow = result;
			}
			if (savedResultToShow != null) {
				Message message = Message.obtain(handler,
						R.id.decode_succeeded, savedResultToShow);
				handler.sendMessage(message);
			}
			savedResultToShow = null;
		}
	}

	public void onClick(View v) {
		switch (v.getId()) {
		case R.id.capture_flashlight:
			if (isFlashlightOpen) {
				cameraManager.setTorch(false); // 閸忔娊妫撮梻顏勫帨閻忥拷
				isFlashlightOpen = false;
			} else {
				cameraManager.setTorch(true); // 閹垫挸绱戦梻顏勫帨閻忥拷
				isFlashlightOpen = true;
			}
			break;
		default:
			break;
		}

	}

}
