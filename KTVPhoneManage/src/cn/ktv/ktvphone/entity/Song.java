package cn.ktv.ktvphone.entity;

public class Song {
	private int SGI_SongId;//�������
    private String SGI_SongName;//��������
    private String SGT_SongTypeName;//��������
    private int SGI_SongWordCount;//������������
    private String SGI_SongSpell;//��������ƴ����д
    private String SRI_SingerName;//��������
    private int SGI_SongClickRate;//���������
    private String SGI_SongURL;//����·��
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
