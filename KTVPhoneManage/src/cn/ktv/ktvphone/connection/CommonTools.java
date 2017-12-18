package cn.ktv.ktvphone.connection;



public class CommonTools {
	
	public boolean isConnection = false;
	public ClientConnection client = null;
	
	public CommonTools(ClientConnection clientConnection){
		this.client = clientConnection;
	}
	
	/**
	 * ��ͣ�����¼�
	 * @param view
	 */
	public int PauseClick(){
		try {
			if(isConnection){//�ж��Ƿ�����
				final String message = "Function-4-#";//Ҫ���͵���Ϣ
				String string = new String(client.SendMessage(message)).trim();//������Ϣ���յ�����
				if(string.equals("Function-4-0")){//�ж�״̬�����İ�ť����
					return 0;
					//button.setText(R.string.pause);
				}else if(string.equals("Function-4-1")){
					return 1;
					//button.setText(R.string.play);
				}
				return -1;
			}else{//��δ����
				return -1;
			}
		} catch (Exception e) {
			return -1;
		}
	}
	/**
	 * ԭ��
	 * @param view
	 */
	public int NoSinger(){
		try {
			if(isConnection){//�ж��Ƿ�����
				final String message = "Function-5-#";//Ҫ���͵���Ϣ
				String string = new String(client.SendMessage(message)).trim();//������Ϣ���յ�����
				if(string.equals("Function-5-0")){//�ж�״̬�����İ�ť����
					return 0;
					//button.setText(R.string.singer);
				}else if(string.equals("Function-5-1")){
					return 1;
					//button.setText(R.string.nosinger);
				}
				return -1;
			}else{//��δ����
				return -1;
			}
		} catch (Exception e) {
			return -1;
		}
	}
	/**
	 * �и�
	 * @param view
	 */
	public boolean CutSong(){
		try {
			if(isConnection){//�ж��Ƿ�����
				final String message = "Function-1-#";//Ҫ���͵���Ϣ
				String string = new String(client.SendMessage(message)).trim();//������Ϣ���յ�����
				if(string.equals("true")){//�ж�״̬�����İ�ť����
					return true;
				}
				return false;
			}else{//��δ����
				return false;
			}
		} catch (Exception e) {
			return false;
		}
		
	}
	/**
	 * ����
	 * @param view
	 */
	public boolean Server(){
		try {
			if(isConnection){//�ж��Ƿ�����
				final String message = "Function-3-#";//Ҫ���͵���Ϣ
				String string = new String(client.SendMessage(message)).trim();//������Ϣ���յ�����
				if(string.equals("true")){//�ж�״̬�����İ�ť����
					return true;
				}
				return false;
			}else{//��δ����
				return false;
			}
		} catch (Exception e) {
			return false;
		}
	}
	/**
	 * �س�
	 * @param view
	 */
	public boolean LastSong(){
		try {
			if(isConnection){//�ж��Ƿ�����
				final String message = "Function-2-#";//Ҫ���͵���Ϣ
				String string = new String(client.SendMessage(message)).trim();//������Ϣ���յ�����
				if(string.equals("true")){//�ж�״̬�����İ�ť����
					return true;
				}
				return false;
			}else{//��δ����
				return false;
			}
		} catch (Exception e) {
			return false;
		}
		
	}
}
