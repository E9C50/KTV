using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Runtime.Serialization;
using MyKTVClient.BLL;
using MyKTVClient.Model;

namespace MyKTVClient
{
    public class PhoneConnTool
    {
        public FrmPlaySong play = null;
        IPAddress ip;//ip地址
        IPEndPoint point;//带端口号的ip地址
        Socket socketWatch;//用于监听的socket
        Socket socketSend;//用于发送的socket
        Thread listenThread;//用于监听的线程
        /// <summary>
        /// 监听
        /// </summary>
        public void Listen()
        {
            //在服务器端创建一个负责监听IP地址和端口号的Socket
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    ip = _IPAddress;//获取本机IP地址
                    //Console.WriteLine(ip.ToString());
                }
            }
            //ip = IPAddress.Parse("192.168.1.110");//创建ip地址对象
            point = new IPEndPoint(ip, 8998);//创建包含端口号的ip地址对象
            socketWatch.Bind(point);//绑定包含端口的ip到监听socket
            socketWatch.Listen(10);//开始监听，最大监听10个设备
            while (true)
            {
                socketSend = socketWatch.Accept();//等待客户端的连接，并创建一个用于通讯的socket
                Console.WriteLine(socketSend.RemoteEndPoint + "设备已连接到本服务器");
                listenThread = new Thread(new ParameterizedThreadStart(GetClientMessage));//创建负责监听的子线程
                listenThread.IsBackground = true;//设置该子线程为后台线程
                listenThread.Start(socketSend);//启动线程传入监听socket
            }
            
        }
        /// <summary>
        /// 获得客户端的消息
        /// </summary>
        /// <param name="obj"></param>
        private void GetClientMessage(Object obj)
        {
            Socket socket = obj as Socket;//转换数据类型
            while (true)
            {
                try
                {
                    Byte[] buffer = new Byte[2048];//接收信息的字节数组
                    int count = socket.Receive(buffer);//判断客户端连接状态
                    if (count == 0)
                    {
                        Console.WriteLine(socket.RemoteEndPoint + "断开连接");
                        break;//客户端断开时跳出
                    }
                    else
                    {
                        String str = Encoding.UTF8.GetString(buffer, 0, count);//获得客户端发送的信息
                        Console.WriteLine(socket.RemoteEndPoint + "发送消息：" + str);
                        ReturnJson(str, socket);
                    }
                }
                catch (Exception)
                {
                }
            }
        }
        /// <summary>
        /// 回馈数据
        /// </summary>
        /// <param name="str"></param>
        private void ReturnJson(string str,Socket returnSocket)
        {
            
            string[] message = str.Split('-');//字符串转换为字符串数组
            try
            {
                Byte[] returnData = null;//字符串转换为字节数组
                SingerManage singer = new SingerManage();
                SongManage song = new SongManage();
                message[2] = message[2].Replace("\n","");
                switch (message[0])
                {
                    case "Song":
                        #region 查找歌曲
                        List<SongInfo> songList = null;
                        switch(message[1]){
                            case "1"://查找所有歌手
                                returnData = null;
                                List<SingerInfo> singerList = singer.GetSingerList("");
                                returnData = GetJson(singerList);
                                break;
                            case "2"://查找某个歌手的所有歌曲
                                returnData = null;
                                songList = song.GetSongList("歌手",message[2]);
                                returnData = GetJson(songList);
                                break;
                            case "3"://歌名点歌
                                returnData = null;
                                songList = song.GetSongList("歌名s",message[2]);
                                returnData = GetJson(songList);
                                break;
                            case "4"://字数点歌
                                returnData = null;
                                songList = song.GetSongList("字数", message[2]);
                                returnData = GetJson(songList);
                                break;
                            case "5"://金曲点歌
                                returnData = null;
                                songList = song.GetSongList("排行", message[2]);
                                returnData = GetJson(songList);
                                break;
                            case "6"://类型点歌
                                returnData = null;
                                songList = song.GetSongList("类型", message[2]);
                                returnData = GetJson(songList);
                                break;
                        }
                        returnSocket.Send(returnData, returnData.Length, SocketFlags.None);//发送回馈
                        #endregion
                        break;
                    case "Function":
                        #region 功能
                        switch (message[1])
                        {
                            case "1":
                                #region 切歌
                                returnData = null;
                                PlayList.CutSong();
                                returnData = Encoding.UTF8.GetBytes("true");
                                returnSocket.Send(returnData, returnData.Length, SocketFlags.None);//发送回馈
                                break;
                                #endregion
                            case "2":
                                #region 重唱
                                returnData = null;
                                PlayList.PlayAgain();
                                returnData = Encoding.UTF8.GetBytes("true");
                                returnSocket.Send(returnData, returnData.Length, SocketFlags.None);//发送回馈
                                break;
                                #endregion
                            case "3":
                                #region 服务
                                returnData = null;
                                RoomManage roommanage = new RoomManage();
                                bool result = roommanage.Server(FrmMain.roomId);
                                if (result)
                                {
                                    returnData = Encoding.UTF8.GetBytes("true");
                                    returnSocket.Send(returnData, returnData.Length, SocketFlags.None);//发送回馈
                                    break;
                                }
                                returnData = Encoding.UTF8.GetBytes("false");
                                returnSocket.Send(returnData, returnData.Length, SocketFlags.None);//发送回馈
                                break;
                                #endregion
                            case "4":
                                #region 暂停
                                returnData = null;
                                if (FrmPlaySong.pause == 0)
                                {
                                    play.Pause(1);
                                    returnData = Encoding.UTF8.GetBytes("Function-4-1");
                                }
                                else if (FrmPlaySong.pause == 1)
                                {
                                    play.Pause(0);
                                    returnData = Encoding.UTF8.GetBytes("Function-4-0");
                                }
                                returnSocket.Send(returnData, returnData.Length, SocketFlags.None);//发送回馈
                                break;
                                #endregion
                            case "5":
                                #region 原唱
                                returnData = null;
                                if (FrmPlaySong.truck == 0)
                                {
                                    play.wmp.SetConfig(403, "1");
                                    FrmPlaySong.truck = 1;
                                    returnData = Encoding.UTF8.GetBytes("Function-5-1");
                                }
                                else if (FrmPlaySong.truck == 1)
                                {
                                    play.wmp.SetConfig(403, "0");
                                    FrmPlaySong.truck = 0;
                                    returnData = Encoding.UTF8.GetBytes("Function-5-0");
                                }
                                returnSocket.Send(returnData, returnData.Length, SocketFlags.None);//发送回馈
                                break;
                                #endregion
                        }
                        #endregion
                        break;
                    case "AddSong":
                        #region 点歌
                        List<SongInfo> addSong = song.GetSongList("歌名",message[1]);
                        SongInfo songInfo = new SongInfo();
                        songInfo = addSong[0];
                        PlayList.Songgroup.Add(songInfo);
                        song.CountAdd(songInfo.SGI_SongId1);
                        #endregion
                        break;
                    case "conn":
                        #region 连接测试
                        returnData = null;
                        returnData = Encoding.UTF8.GetBytes("conn");
                        returnSocket.Send(returnData, returnData.Length, SocketFlags.None);//发送回馈
                        #endregion
                        break;
                    case "getbtn":
                        #region 获得按钮状态
                        returnData = null;
                        string paruse = FrmPlaySong.pause.ToString() + "-" + FrmPlaySong.truck.ToString();
                        returnData = Encoding.UTF8.GetBytes(paruse);
                        returnSocket.Send(returnData, returnData.Length, SocketFlags.None);//发送回馈
                        #endregion
                        break;
                }
            }
            catch (Exception)
            {
                Byte[] returnData = Encoding.UTF8.GetBytes("false");
                returnSocket.Send(returnData, returnData.Length, SocketFlags.None);//反馈false
            }
        }
        /// <summary>
        /// 获得Json字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private byte[] GetJson(Object obj)
        {
            StringBuilder jsonStr = new StringBuilder();
            if (obj is List<SongInfo>)
            {
                jsonStr.Clear();
                jsonStr.Append("{");
                int i = 0;
                foreach(SongInfo song in obj as List<SongInfo>)
                {
                    i++;
                    jsonStr.Append("\""+song.SGI_SongId1 + "\":{");
                    jsonStr.Append("\"name\":\"" + song.SGI_SongName1 + "\",");
                    jsonStr.Append("\"type\":\"" + song.SGI_SongType1 + "\",");
                    jsonStr.Append("\"count\":\"" + song.SGI_SongWordCount1 + "\",");
                    jsonStr.Append("\"spell\":\"" + song.SGI_SongSpell1 + "\",");
                    jsonStr.Append("\"singer\":\"" + song.SGI_SongSinger1 + "\",");
                    jsonStr.Append("\"click\":\"" + song.SGI_SongClickRate1 + "\"");
                    jsonStr.Append("}");
                    if (i != (obj as List<SongInfo>).Count)
                    {
                        jsonStr.Append(",");
                    }
                }
                jsonStr.Append("}");
                return Encoding.UTF8.GetBytes(jsonStr.ToString());
            }
            else if (obj is List<SingerInfo>)
            {
                jsonStr.Clear();
                jsonStr.Append("{");
                int i = 0;
                foreach (SingerInfo singer in obj as List<SingerInfo>)
                {
                    i++;
                    jsonStr.Append("\"" + singer.SRI_SingeId1 + "\":{");
                    jsonStr.Append("\"name\":\"" + singer.SRI_SingerName1 + "\",");
                    jsonStr.Append("\"type\":\"" + singer.SRI_SingeType1 + "\"");
                    jsonStr.Append("}");
                    if (i != (obj as List<SingerInfo>).Count)
                    {
                        jsonStr.Append(",");
                    }
                }
                jsonStr.Append("}");
                return Encoding.UTF8.GetBytes(jsonStr.ToString());
            }
            return null;
        }
        /// <summary>
        /// 获得ip
        /// </summary>
        /// <returns></returns>
        public string GetIPAddress()
        {
            return this.point.ToString();
        }
    }
}
