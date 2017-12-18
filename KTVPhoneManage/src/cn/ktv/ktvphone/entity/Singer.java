package cn.ktv.ktvphone.entity;

import java.io.Serializable;


public class Singer implements Serializable {
	private int SRI_SingeId;
	private String SRI_SingerName;
    private String SRI_SingeType;
    private byte[] SRI_SingePhoto;
    public int getSRI_SingeId() {
		return SRI_SingeId;
	}
	public void setSRI_SingeId(int sRI_SingeId) {
		SRI_SingeId = sRI_SingeId;
	}
	public String getSRI_SingerName() {
		return SRI_SingerName;
	}
	public void setSRI_SingerName(String sRI_SingerName) {
		SRI_SingerName = sRI_SingerName;
	}
	public String getSRI_SingeType() {
		return SRI_SingeType;
	}
	public void setSRI_SingeType(String sRI_SingeType) {
		SRI_SingeType = sRI_SingeType;
	}
	public byte[] getSRI_SingePhoto() {
		return SRI_SingePhoto;
	}
	public void setSRI_SingePhoto(byte[] sRI_SingePhoto) {
		SRI_SingePhoto = sRI_SingePhoto;
	}
	public Singer() {}
	public Singer(int sRI_SingeId, String sRI_SingerName, String sRI_SingeType,
			byte[] sRI_SingePhoto) {
		SRI_SingeId = sRI_SingeId;
		SRI_SingerName = sRI_SingerName;
		SRI_SingeType = sRI_SingeType;
		SRI_SingePhoto = sRI_SingePhoto;
	}
}
