package cn.ktv.ktvphone.connection;

import java.io.*;
import java.net.Socket;

import org.apache.commons.logging.Log;

import cn.ktv.ktvphone.activity.MainActivity;

public class ClientConnection implements Serializable {
	private PrintWriter writer; // 输出对象
	DataInputStream dis;// 读取流
	Socket socket;// 发送socket
	byte[] Reader = new byte[618587];

	/**
	 * 连接
	 * 
	 * @param v
	 */
	public boolean ConnTest(final String ip, final int post) {
		new Thread(new Runnable() {// 创建连接线程
					public void run() {
						try {
							// System.out.println("try connection!");
							android.util.Log.e("SendMessage", "try connection");
							socket = new Socket(ip, post);// 创建连接到服务器的socket
							// System.out.println("connectioned!");
							android.util.Log.e("SendMessage", "connectioned");
						} catch (Exception e) {
							return;
						}
					}
				}).start();
		return true;
	}

	/**
	 * 发送信息
	 * 
	 * @param message
	 * @return
	 */
	public byte[] SendMessage(String message) {
		try {
			writer = new PrintWriter(socket.getOutputStream(), true);// 将printwriter绑定到socket
			writer.println(message);
			writer.flush();
			dis = new DataInputStream(socket.getInputStream());// 绑定输入流到DataInputStream对象
			Reader = new byte[618587];
			new Thread(new Runnable() {
				public void run() {
					try {
						while (true) {
							dis.read(Reader);// 读取数据
							final String str = new String(Reader);
							if (str.trim() != "" && str.trim() != null) {// 如果获取到反馈
								//System.out.println("读到数据" + str);
								break;
							}
						}
					} catch (IOException e) {
						System.out.println(e);
					}
				}
			}).start();
			Thread.sleep(100);// 等待子线程读取到值
			while (true) {// 不断刷新读取
				final String str = new String(Reader);
				// Thread.sleep(100);
				if (str.trim() != "" && str.trim() != null) {// 如果获取到反馈
					// System.out.println("返回数据");
					//System.out.println(str);
					android.util.Log.e("SendMessage", new String(Reader).trim());
					return Reader;// 返回收到的数据
				}
			}
		} catch (Exception e) {
			System.out.println(e);
			return "Exception".getBytes();
		}
	}
}
