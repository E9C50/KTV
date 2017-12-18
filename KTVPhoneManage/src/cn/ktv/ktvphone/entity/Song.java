package cn.ktv.ktvphone.entity;

public class Song {
	private int SGI_SongId;//¸èÇú±àºÅ
    private String SGI_SongName;//¸èÇúÃû³Æ
    private String SGT_SongTypeName;//¸èÇúÀàÐÍ
    private int SGI_SongWordCount;//¸èÇúÃû³Æ×ÖÊý
    private String SGI_SongSpell;//¸èÇúÃû³ÆÆ´Òô¼òÐ´
    private String SRI_SingerName;//¸èÇú¸èÊÖ
    private int SGI_SongClickRate;//¸èÇúµã»÷ÂÊ
    private String SGI_SongURL;//¸èÇúÂ·¾¶
	public int getSGI_SongId() {
		return SGI_SongId;
	}
	public void setSGI_SongId(int sGI_SongId) {
		SGI_SongId = sGI_SongId;
	}
	public String getSGI_SongName() {
		return SGI_SongName;
	}
	public void setSGI_SongName(String sGI_SongName) {
		SGI_SongName = sGI_SongName;
	}
	public String getSGT_SongTypeName() {
		return SGT_SongTypeName;
	}
	public void setSGT_SongTypeName(String sGT_SongTypeName) {
		SGT_SongTypeName = sGT_SongTypeName;
	}
	public int getSGI_SongWordCount() {
		return SGI_SongWordCount;
	}
	public void setSGI_SongWordCount(int sGI_SongWordCount) {
		SGI_SongWordCount = sGI_SongWordCount;
	}
	public String getSGI_SongSpell() {
		return SGI_SongSpell;
	}
	public void setSGI_SongSpell(String sGI_SongSpell) {
		SGI_SongSpell = sGI_SongSpell;
	}
	public String getSRI_SingerName() {
		return SRI_SingerName;
	}
	public void setSRI_SingerName(String sRI_SingerName) {
		SRI_SingerName = sRI_SingerName;
	}
	public int getSGI_SongClickRate() {
		return SGI_SongClickRate;
	}
	public void setSGI_SongClickRate(int sGI_SongClickRate) {
		SGI_SongClickRate = sGI_SongClickRate;
	}
	public String getSGI_SongURL() {
		return SGI_SongURL;
	}
	public void setSGI_SongURL(String sGI_SongURL) {
		SGI_SongURL = sGI_SongURL;
	}
	public Song() {}
	public Song(int sGI_SongId, String sGI_SongName, String sGT_SongTypeName,
			int sGI_SongWordCount, String sGI_SongSpell, String sRI_SingerName,
			int sGI_SongClickRate, String sGI_SongURL) {
		SGI_SongId = sGI_SongId;
		SGI_SongName = sGI_SongName;
		SGT_SongTypeName = sGT_SongTypeName;
		SGI_SongWordCount = sGI_SongWordCount;
		SGI_SongSpell = sGI_SongSpell;
		SRI_SingerName = sRI_SingerName;
		SGI_SongClickRate = sGI_SongClickRate;
		SGI_SongURL = sGI_SongURL;
	}
    
    
}
