package cn.ktv.ktvphone.activity;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

import cn.ktv.ktvphone.R;
import cn.ktv.ktvphone.connection.ClientConnection;
import cn.ktv.ktvphone.connection.CommonTools;
import cn.ktv.ktvphone.connection.ResultOperation;
import cn.ktv.ktvphone.entity.Singer;
import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.support.v4.widget.ListViewAutoScrollHelper;
import android.view.View;
import android.view.Window;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.TextView;
import android.widget.Toast;

public class SingerListActivity extends Activity {

	List<Singer> singerList = new ArrayList<Singer>();

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_singerlist);

		ChangeBtn();
		
		TextView textView = (TextView) findViewById(R.id.tvS);
		textView.setText("��������");

		ResultOperation operation = new ResultOperation();

		final String message = "Song-1-#";// Ҫ���͵���Ϣ
		
		do{
			byte[] buff = MainActivity.client.SendMessage(message);// ������Ϣ���յ�����
			if(singerList != null){
				singerList.clear();
			}
			singerList = operation.GetSingerOnJson(buff);
		}while(singerList == null);
		
		ListView listView = (ListView) findViewById(R.id.lvSingerList);// ���ListView�ؼ�
		BlindSingerInfo(listView);// ������и��ֲ��󶨵�ListView
		// ListView �����¼�
		listView.setOnItemClickListener(new OnItemClickListener() {
			public void onItemClick(AdapterView<?> arg0, View arg1, int arg2,
					long arg3) {
				String singerName = singerList.get(arg2).getSRI_SingerName();// ��ȡ������ĸ�������
				Intent intent = new Intent(SingerListActivity.this,
						SingerSongListActivity.class);
				intent.putExtra("text", singerName);
				intent.putExtra("type", 2);
				startActivity(intent);
			}
		});
	}
	/**
	 * �жϰ�ť״̬
	 * @param btn
	 */
	public void ChangeBtn(){
		ImageView imgpause = (ImageView) findViewById(R.id.btnPause);
		ImageView imgtruck = (ImageView) findViewById(R.id.btnSong);
		if (MainActivity.btnPause == 1) {
			imgpause.setImageResource(R.drawable.play);
		} else if (MainActivity.btnPause == 0) {
			imgpause.setImageResource(R.drawable.pause);
		}
		if (MainActivity.btnSinger == 0) {
			imgtruck.setImageResource(R.drawable.hassinger);
		} else if (MainActivity.btnSinger == 1) {
			imgtruck.setImageResource(R.drawable.nosinger);
		}
	}
	/**
	 * ������и��ֲ��󶨵�ListView
	 * 
	 * @param listView
	 *            �ؼ�
	 * @param singers
	 *            ���ּ���
	 */
	public void BlindSingerInfo(ListView listView) {

		List<Map<String, Object>> listitem = new ArrayList<Map<String, Object>>();
		for (Singer singer : singerList) {
			Map<String, Object> map = new HashMap<String, Object>();
			map.put("name", singer.getSRI_SingerName());
			map.put("type", singer.getSRI_SingeType());
			listitem.add(map);
		}
		SimpleAdapter adapter = new SimpleAdapter(this, listitem,
				R.layout.listviewitem, new String[] { "name", "type" },
				new int[] { R.id.tvSingerName, R.id.tvSingerType });
		listView.setAdapter(adapter);
	}

	/**
	 * ��ͣ�����¼�
	 * 
	 * @param view
	 */
	public void PauseClick(View view) {
		if (MainActivity.isConnection) {
			ImageView button = (ImageView) findViewById(R.id.btnPause);
			int result = MainActivity.tools.PauseClick();
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
		if (MainActivity.isConnection) {
			ImageView button = (ImageView) findViewById(R.id.btnSong);
			int result = MainActivity.tools.NoSinger();
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
		if (MainActivity.isConnection) {
			MainActivity.tools.CutSong();
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
		if (MainActivity.isConnection) {
			if (MainActivity.tools.Server()) {
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
		if (MainActivity.isConnection) {
			MainActivity.tools.LastSong();
		} else {
			Toast.makeText(getBaseContext(), R.string.unconnection,
					Toast.LENGTH_SHORT).show();
		}

	}

}
