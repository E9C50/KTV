package cn.ktv.ktvphone.connection;

import java.io.*;
import java.net.Socket;

import org.apache.commons.logging.Log;

import cn.ktv.ktvphone.activity.MainActivity;

public class ClientConnection implements Serializable {
	private PrintWriter writer; // �������
	DataInputStream dis;// ��ȡ��
	Socket socket;// ����socket
	byte[] Reader = new byte[618587];

	/**
	 * ����
	 * 
	 * @param v
	 */
	public boolean ConnTest(final String ip, final int post) {
		new Thread(new Runnable() {// ���������߳�
					public void run() {
						try {
							// System.out.println("try connection!");
							android.util.Log.e("SendMessage", "try connection");
							socket = new Socket(ip, post);// �������ӵ���������socket
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
	 * ������Ϣ
	 * 
	 * @param message
	 * @return
	 */
	public byte[] SendMessage(String message) {
		try {
			writer = new PrintWriter(socket.getOutputStream(), true);// ��printwriter�󶨵�socket
			writer.println(message);
			writer.flush();
			dis = new DataInputStream(socket.getInputStream());// ����������DataInputStream����
			Reader = new byte[618587];
			new Thread(new Runnable() {
				public void run() {
					try {
						while (true) {
							dis.read(Reader);// ��ȡ����
							final String str = new String(Reader);
							if (str.trim() != "" && str.trim() != null) {// �����ȡ������
								//System.out.println("��������" + str);
								break;
							}
						}
					} catch (IOException e) {
						System.out.println(e);
					}
				}
			}).start();
			Thread.sleep(100);// �ȴ����̶߳�ȡ��ֵ
			while (true) {// ����ˢ�¶�ȡ
				final String str = new String(Reader);
				// Thread.sleep(100);
				if (str.trim() != "" && str.trim() != null) {// �����ȡ������
					// System.out.println("��������");
					//System.out.println(str);
					android.util.Log.e("SendMessage", new String(Reader).trim());
					return Reader;// �����յ�������
				}
			}
		} catch (Exception e) {
			System.out.println(e);
			return "Exception".getBytes();
		}
	}
}
