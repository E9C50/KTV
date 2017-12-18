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
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.AdapterView.OnItemClickListener;

public class SingerSongListActivity extends Activity {

	int searchType = 0;
	String searchText = "";
	List<Song> songList;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_songlist);

		ChangeBtn();
		
		searchType = getIntent().getIntExtra("type",0);
		searchText = getIntent().getStringExtra("text");

		TextView textView = (TextView) findViewById(R.id.tvS);
		textView.setText("歌手");

		ListView listView = (ListView) findViewById(R.id.lvSongList);
		BlindSongInfo(listView);

		listView.setOnItemClickListener(new OnItemClickListener() {
			public void onItemClick(AdapterView<?> arg0, View arg1, int arg2,
					long arg3) {
				String songName = songList.get(arg2).getSGI_SongName();// 获取到点击的歌手姓名
				String message = "AddSong-" + songName + "-#";
				MainActivity.client.SendMessage(message);
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
	 * 绑定歌曲
	 * @param listView
	 */
	public void BlindSongInfo(ListView listView) {
		String message = null;
		switch (searchType) {
			case 2:
				message = "Song-2-" + searchText;
				break;
			case 3:
				message = "Song-3-" + searchText;
				break;
		}
		
		do{
			byte[] buff = MainActivity.client.SendMessage(message);
			if(songList != null){
				songList.clear();
			}
			songList = MainActivity.operation.GetSongOnJson(buff);
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
