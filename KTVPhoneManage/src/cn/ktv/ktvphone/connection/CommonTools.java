package cn.ktv.ktvphone.connection;



public class CommonTools {
	
	public boolean isConnection = false;
	public ClientConnection client = null;
	
	public CommonTools(ClientConnection clientConnection){
		this.client = clientConnection;
	}
	
	/**
	 * 暂停单击事件
	 * @param view
	 */
	public int PauseClick(){
		try {
			if(isConnection){//判断是否连接
				final String message = "Function-4-#";//要发送的消息
				String string = new String(client.SendMessage(message)).trim();//发送消息并收到反馈
				if(string.equals("Function-4-0")){//判断状态并更改按钮文字
					return 0;
					//button.setText(R.string.pause);
				}else if(string.equals("Function-4-1")){
					return 1;
					//button.setText(R.string.play);
				}
				return -1;
			}else{//还未连接
				return -1;
			}
		} catch (Exception e) {
			return -1;
		}
	}
	/**
	 * 原唱
	 * @param view
	 */
	public int NoSinger(){
		try {
			if(isConnection){//判断是否连接
				final String message = "Function-5-#";//要发送的消息
				String string = new String(client.SendMessage(message)).trim();//发送消息并收到反馈
				if(string.equals("Function-5-0")){//判断状态并更改按钮文字
					return 0;
					//button.setText(R.string.singer);
				}else if(string.equals("Function-5-1")){
					return 1;
					//button.setText(R.string.nosinger);
				}
				return -1;
			}else{//还未连接
				return -1;
			}
		} catch (Exception e) {
			return -1;
		}
	}
	/**
	 * 切歌
	 * @param view
	 */
	public boolean CutSong(){
		try {
			if(isConnection){//判断是否连接
				final String message = "Function-1-#";//要发送的消息
				String string = new String(client.SendMessage(message)).trim();//发送消息并收到反馈
				if(string.equals("true")){//判断状态并更改按钮文字
					return true;
				}
				return false;
			}else{//还未连接
				return false;
			}
		} catch (Exception e) {
			return false;
		}
		
	}
	/**
	 * 服务
	 * @param view
	 */
	public boolean Server(){
		try {
			if(isConnection){//判断是否连接
				final String message = "Function-3-#";//要发送的消息
				String string = new String(client.SendMessage(message)).trim();//发送消息并收到反馈
				if(string.equals("true")){//判断状态并更改按钮文字
					return true;
				}
				return false;
			}else{//还未连接
				return false;
			}
		} catch (Exception e) {
			return false;
		}
	}
	/**
	 * 重唱
	 * @param view
	 */
	public boolean LastSong(){
		try {
			if(isConnection){//判断是否连接
				final String message = "Function-2-#";//要发送的消息
				String string = new String(client.SendMessage(message)).trim();//发送消息并收到反馈
				if(string.equals("true")){//判断状态并更改按钮文字
					return true;
				}
				return false;
			}else{//还未连接
				return false;
			}
		} catch (Exception e) {
			return false;
		}
		
	}
}
