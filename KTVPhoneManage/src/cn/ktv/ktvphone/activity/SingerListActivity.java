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
		textView.setText("歌手类型");

		ResultOperation operation = new ResultOperation();

		final String message = "Song-1-#";// 要发送的消息
		
		do{
			byte[] buff = MainActivity.client.SendMessage(message);// 发送消息并收到反馈
			if(singerList != null){
				singerList.clear();
			}
			singerList = operation.GetSingerOnJson(buff);
		}while(singerList == null);
		
		ListView listView = (ListView) findViewById(R.id.lvSingerList);// 获得ListView控件
		BlindSingerInfo(listView);// 获得所有歌手并绑定到ListView
		// ListView 单击事件
		listView.setOnItemClickListener(new OnItemClickListener() {
			public void onItemClick(AdapterView<?> arg0, View arg1, int arg2,
					long arg3) {
				String singerName = singerList.get(arg2).getSRI_SingerName();// 获取到点击的歌手姓名
				Intent intent = new Intent(SingerListActivity.this,
						SingerSongListActivity.class);
				intent.putExtra("text", singerName);
				intent.putExtra("type", 2);
				startActivity(intent);
			}
		});
	}
	/**
	 * 判断按钮状态
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
	 * 获得所有歌手并绑定到ListView
	 * 
	 * @param listView
	 *            控件
	 * @param singers
	 *            歌手集合
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
	 * 暂停单击事件
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
	 * 原唱
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
	 * 切歌
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
	 * 服务
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
	 * 重唱
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
