package cn.ktv.ktvphone.activity;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import cn.ktv.ktvphone.R;
import cn.ktv.ktvphone.entity.Song;
import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.AdapterView.OnItemSelectedListener;

public class CountListActivity extends Activity {
	List<Song> songList;
	ListView listView;
	int index;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		
		setContentView(R.layout.acyivity_countlist);

		TextView textView = (TextView) findViewById(R.id.tvS);
		textView.setText("歌手");

		listView = (ListView) findViewById(R.id.lvSongList);
		BlindSongInfo(listView);

		listView.setOnItemClickListener(new OnItemClickListener() {
			public void onItemClick(AdapterView<?> arg0, View arg1, int arg2,
					long arg3) {
				String songName = songList.get(arg2).getSGI_SongName();// 获取到点击的歌手姓名
				String message = "AddSong-" + songName + "-#";
				MainActivity.client.SendMessage(message);
			}
		});
		
		Spinner spinner = (Spinner) findViewById(R.id.spiCount);
		
		spinner.setOnItemSelectedListener(new OnItemSelectedListener() {
			@Override
			public void onItemSelected(AdapterView<?> arg0, View arg1,
					int arg2, long arg3) {
				index = arg2+1;
				BlindSongInfo(listView);
			}

			@Override
			public void onNothingSelected(AdapterView<?> arg0) {
				// TODO Auto-generated method stub
				
			}
		});
		
//		String message = "getbtn-#-#";
//		String btnResult;
//		do {
//			byte[] buff = MainActivity.client.SendMessage(message);
//			btnResult = null;
//			btnResult = new String(buff);
//		} while (btnResult == null);
//		String[] btn = btnResult.split("-");
//		ImageView imgpause = (ImageView) findViewById(R.id.btnPause);
//		ImageView imgtruck = (ImageView) findViewById(R.id.btnSong);
//		if (btn[0] == "0") {
//			imgpause.setImageResource(R.drawable.play);
//		} else if (btn[0] == "1") {
//			imgpause.setImageResource(R.drawable.pause);
//		}
//		if (btn[1] == "0") {
//			imgtruck.setImageResource(R.drawable.hassinger);
//		} else if (btn[1] == "1") {
//			imgtruck.setImageResource(R.drawable.nosinger);
//		}
	}
	
	public void Search(View view){
		BlindSongInfo(listView);
	}
	
	/**
	 * 绑定歌曲
	 * @param listView
	 */
	public void BlindSongInfo(ListView listView) {
		String message = null;
		message = ("Song-4-" + index);
		byte[] buff;
		do{
			buff = null;
			buff = MainActivity.client.SendMessage(message);
			System.out.println(new String(buff));
			if(new String(buff).equals("")){
				Toast.makeText(getBaseContext(), "断开连接", Toast.LENGTH_LONG).show();
//				Intent intent = new Intent(CountListActivity.this,MainActivity.class);
//				startActivity(intent);
				System.out.println("断开");
				return;
			}
			if(songList != null){
				songList.clear();
			}
			songList = MainActivity.operation.GetSongOnJson(buff);
			System.out.println("循环");
		}while(songList == null);
		
		List<Map<String, Object>> listitem = new ArrayList<Map<String, Object>>();
		for (Song song : songList) {
			Map<String, Object> map = new HashMap<String, Object>();
			map.put("name", song.getSGI_SongName());
			map.put("singer", song.getSRI_SingerName());
			listitem.add(map);
		}
		SimpleAdapter adapter = new SimpleAdapter(this, listitem,
				R.layout.listviewitem, new String[] { "name", "singer" },
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
				button.setImageResource(R.drawable.play);
			} else if (result == 0) {
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
				button.setImageResource(R.drawable.nosinger);
			} else if (result == 0) {
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
