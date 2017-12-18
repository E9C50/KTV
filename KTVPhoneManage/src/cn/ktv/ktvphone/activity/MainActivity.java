package cn.ktv.ktvphone.activity;

import java.security.PublicKey;

import cn.ktv.ktvphone.connection.ClientConnection;
import cn.ktv.ktvphone.connection.CommonTools;
import cn.ktv.ktvphone.connection.ResultOperation;
import cn.ktv.ktvphone.scanner.CaptureActivity;
import cn.ktv.ktvphone.R;
import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.LinearLayout.LayoutParams;
import android.widget.Toast;

public class MainActivity extends Activity {

	public static boolean isConnection = false;// �Ƿ�����
	public static ClientConnection client = new ClientConnection();
	public static ResultOperation operation = new ResultOperation();
	public static CommonTools tools = new CommonTools(client);
	private static ClientConnection conn = new ClientConnection();
	public static int btnPause = 0;
	public static int btnSinger = 0;

	/**
	 * activity�����¼�
	 */
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);// ���ر���
		setContentView(R.layout.activity_main);// ������Ӧ��XML

	}

	/**
	 * ɨ�谴ť�����¼�
	 * 
	 * @param view
	 */
	public void ScannerQR(View view) {
		Intent intent = new Intent(MainActivity.this, CaptureActivity.class);// ��ת������������һ������תǰ�ģ��ڶ�����Ҫ��ת��
		startActivityForResult(intent, 0);
	}

	/**
	 * ������ת�������
	 */
	@Override
	public void onActivityResult(int requestCode, int resultCode, Intent intent) {
		if (resultCode == RESULT_OK) {// ���ܱ�ʶ
			try {
				final String ip = intent.getStringExtra("ip");// ip��ַ
				String poststrString = intent.getStringExtra("post");// �˿ں��ַ���
				final int post = Integer.parseInt(poststrString);// �˿ں�
				if (ip.equals("127.0.0.1")) {
					Toast.makeText(getBaseContext(), R.string.scan_failed,
							Toast.LENGTH_SHORT).show();
					return;
				}
				client.ConnTest(ip, post);// ���ӷ�����
				conn.ConnTest(ip, post);
				Thread.sleep(500);
				String clientResult = new String(client.SendMessage("conn-#-#"));
				String connResult = new String(conn.SendMessage("conn-#-#"));
				if (connResult.trim().equals("conn") && clientResult.trim().equals("conn")) {
					Toast.makeText(getBaseContext(), R.string.connectioned,
							Toast.LENGTH_SHORT).show();
					isConnection = true;// ��������״̬
					tools.isConnection = true;
					/**
					 * ��ð�ť״̬
					 */
					if (MainActivity.isConnection) {
						String message = "getbtn-#-#";
						String btnResult;
						do {
							byte[] buff = MainActivity.client
									.SendMessage(message);
							btnResult = null;
							btnResult = new String(buff);
						} while (btnResult == null);
						android.util.Log.e("SendMessage", "btn\t"+btnResult.trim());
						String[] btn = btnResult.split("-");
						ChangeBtn(btn);
					}
					/**
					 * ���ӳɹ���ʱ�����ж�����״̬
					 */
					new Thread(new Runnable() {

						@Override
						public void run() {
							while(true){
								String result = null;
								int i = 0;
								do {
									result = new String(
											conn.SendMessage("conn-#-#"));
									if (!result.trim().equals("") || result != null) {
										try {
											android.util.Log.e("SendMessage", "conn\tconn");
											Thread.sleep(10000);
											break;
										} catch (InterruptedException e) {
											e.printStackTrace();
										}
									}
									i++;
								} while (i<=10);
								if(result.trim().equals("conn")){
									continue;
								}
								MainActivity.isConnection = false;
								android.util.Log.e("SendMessage", "false");
								runOnUiThread(new Runnable() {
									
									@Override
									public void run() {
										// TODO Auto-generated method stub
										Toast.makeText(getBaseContext(), R.string.disconnection, Toast.LENGTH_SHORT).show();
										android.util.Log.e("SendMessage", "toast");
									}
								});
								return;
								
							}
							
						}
					}).start();
					
					
				} else {
					Toast.makeText(getBaseContext(), R.string.scan_failed,
							Toast.LENGTH_SHORT).show();
					return;
				}
			} catch (Exception e) {
				Toast.makeText(getBaseContext(), R.string.scan_failed,
						Toast.LENGTH_SHORT).show();
			}
		}
	}
	
	public void ChangeBtn(String[] btn){
		ImageView imgpause = (ImageView) findViewById(R.id.btnPause);
		ImageView imgtruck = (ImageView) findViewById(R.id.btnSong);
		if (btn[0].trim().equals("1")) {
			btnPause = 1;
			imgpause.setImageResource(R.drawable.play);
		} else if (btn[0].trim().equals("0")) {
			btnPause = 0;
			imgpause.setImageResource(R.drawable.pause);
		}
		if (btn[1].trim().equals("0")) {
			btnSinger = 0;
			imgtruck.setImageResource(R.drawable.hassinger);
		} else if (btn[1].trim().equals("1")) {
			btnSinger = 1;
			imgtruck.setImageResource(R.drawable.nosinger);
		}
	}

	/**
	 * ���ֵ��
	 * 
	 * @param view
	 */
	public void GetSingers(View view) {
		try {
			if (isConnection) {// �ж��Ƿ�����
				Intent intent = new Intent(MainActivity.this,
						SingerListActivity.class);
				startActivity(intent);
			} else {// ��δ����
				Toast.makeText(getBaseContext(), R.string.unconnection,
						Toast.LENGTH_SHORT).show();
			}
		} catch (Exception e) {
			System.out.println(e);
		}
	}

	/**
	 * ƴ�����
	 * 
	 * @param view
	 */
	public void SpellSong(View view) {
		try {
			if (isConnection) {// �ж��Ƿ�����
				Intent intent = new Intent(MainActivity.this,
						SpellSongListActivity.class);
				intent.putExtra("text", "");
				intent.putExtra("type", 3);
				startActivity(intent);
			} else {// ��δ����
				Toast.makeText(getBaseContext(), R.string.unconnection,
						Toast.LENGTH_SHORT).show();
			}
		} catch (Exception e) {
			System.out.println(e);
		}
	}

	/**
	 * ��������
	 * 
	 * @param view
	 */
	public void Top(View view) {
		try {
			if (isConnection) {// �ж��Ƿ�����
				Intent intent = new Intent(MainActivity.this,
						TopListActivity.class);
				startActivity(intent);
			} else {// ��δ����
				Toast.makeText(getBaseContext(), R.string.unconnection,
						Toast.LENGTH_SHORT).show();
			}
		} catch (Exception e) {
			System.out.println(e);
		}
	}

	/**
	 * ���͵��
	 * 
	 * @param view
	 */
	public void TypeList(View view) {
		try {
			if (isConnection) {// �ж��Ƿ�����
				Intent intent = new Intent(MainActivity.this,
						TypeListActivity.class);
				intent.putExtra("text", "");
				intent.putExtra("type", 3);
				startActivity(intent);
			} else {// ��δ����
				Toast.makeText(getBaseContext(), R.string.unconnection,
						Toast.LENGTH_SHORT).show();
			}
		} catch (Exception e) {
			System.out.println(e);
		}
	}

	/**
	 * �������
	 * 
	 * @param view
	 */
	public void Count(View view) {
		try {
			if (isConnection) {// �ж��Ƿ�����
				Intent intent = new Intent(MainActivity.this,
						CountListActivity.class);
				intent.putExtra("text", "");
				intent.putExtra("type", 3);
				startActivity(intent);
			} else {// ��δ����
				Toast.makeText(getBaseContext(), R.string.unconnection,
						Toast.LENGTH_SHORT).show();
			}
		} catch (Exception e) {
			System.out.println(e);
		}
	}

	/**
	 * ��ͣ�����¼�
	 * 
	 * @param view
	 */
	public void PauseClick(View view) {
		if (isConnection) {
			ImageView button = (ImageView) findViewById(R.id.btnPause);
			int result = tools.PauseClick();
			if (result == 1) {
				MainActivity.btnPause = 1;
				button.setImageResource(R.drawable.play);
			} else if (result == 0) {
				MainActivity.btnPause = 0;
				button.setImageResource(R.drawable.pause);
			}
		} else {
			Toast.makeText(getBaseContext(), R.string.unconnection,
					Toast.LENGTH_SHORT).show();
		}

	}

	/**
	 * ԭ��
	 * 
	 * @param view
	 */
	public void NoSinger(View view) {
		if (isConnection) {
			ImageView button = (ImageView) findViewById(R.id.btnSong);
			int result = tools.NoSinger();
			if (result == 1) {
				MainActivity.btnSinger = 1;
				button.setImageResource(R.drawable.nosinger);
			} else if (result == 0) {
				MainActivity.btnSinger = 0;
				button.setImageResource(R.drawable.hassinger);
			}
		} else {
			Toast.makeText(getBaseContext(), R.string.unconnection,
					Toast.LENGTH_SHORT).show();
		}

	}

	/**
	 * �и�
	 * 
	 * @param view
	 */
	public void CutSong(View view) {
		if (isConnection) {
			tools.CutSong();
		} else {
			Toast.makeText(getBaseContext(), R.string.unconnection,
					Toast.LENGTH_SHORT).show();
		}

	}

	/**
	 * ����
	 * 
	 * @param view
	 */
	public void Server(View view) {
		if (isConnection) {
			if (tools.Server()) {
				Toast.makeText(getBaseContext(), R.string.requestServer,
						Toast.LENGTH_SHORT).show();
			}
		} else {
			Toast.makeText(getBaseContext(), R.string.unconnection,
					Toast.LENGTH_SHORT).show();
		}

	}

	/**
	 * �س�
	 * 
	 * @param view
	 */
	public void LastSong(View view) {
		if (isConnection) {
			tools.LastSong();
		} else {
			Toast.makeText(getBaseContext(), R.string.unconnection,
					Toast.LENGTH_SHORT).show();
		}

	}
}
