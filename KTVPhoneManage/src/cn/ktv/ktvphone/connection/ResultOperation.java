package cn.ktv.ktvphone.connection;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import org.json.*;

import cn.ktv.ktvphone.entity.Singer;
import cn.ktv.ktvphone.entity.Song;

public class ResultOperation {
	public List<Singer> GetSingerOnJson(byte[] buff){
		List<Singer> singerList = new ArrayList<Singer>();
		try {
			String string = new String(buff);
			JSONObject jsonObject = new JSONObject(string);
			Iterator iterator = jsonObject.keys();
			while(iterator.hasNext()){
				String key = (String) iterator.next();
				JSONObject singerJson = jsonObject.getJSONObject(key);
				Singer singer = new Singer();
				singer.setSRI_SingeId(Integer.parseInt(key));
	        	singer.setSRI_SingerName(singerJson.getString("name"));
	        	singer.setSRI_SingeType(singerJson.getString("type"));
	        	//singer.setSRI_SingePhoto();∏Ë ÷’’∆¨
	        	singerList.add(singer);
			}
			return singerList;
		} catch (JSONException e) {
			System.out.println(e);
		}
		return singerList;
	}
	
	public List<Song> GetSongOnJson(byte[] buff){
		List<Song> songList = new ArrayList<Song>();
		try {
			String string = new String(buff);
			JSONObject jsonObject = new JSONObject(string);
			Iterator iterator = jsonObject.keys();
			while(iterator.hasNext()){
				String key = (String) iterator.next();
				JSONObject songJson = jsonObject.getJSONObject(key);
				Song song = new Song();
				song.setSGI_SongId(Integer.parseInt(key));
				song.setSGI_SongName(songJson.getString("name"));
				song.setSRI_SingerName(songJson.getString("singer"));
	        	songList.add(song);
			}
			return songList;
		} catch (JSONException e) {
			return null;
		}
	}
}
