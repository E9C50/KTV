using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyKTVServer.BLL;
using MyKTVServer.Model;

namespace MyKTVServer
{
    public partial class FrmRoomManage : Form
    {
        #region 加载
        public ToolStripMenuItem tsmi = null;
        DateTime startTime = DateTime.Now;
        RoomManage roommanage = new RoomManage();
        public FrmRoomManage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRoomManage_Load(object sender, EventArgs e)
        {
            AddRomeBtn();
            
        }
        #endregion
        #region 查看
        /// <summary>
        /// 动态添加包厢信息
        /// </summary>
        public void AddRomeBtn()
        {
            List<Room> roomList = roommanage.GetRoomList();
            int weight = 200;//横坐标
            int height = 0;//纵坐标
            for(int i = 0,j = 0;i < roomList.Count;i++,j++)
            {
                Button btn = new Button();
                if(j * weight + 200 > this.Size.Width - 75)//如果横坐标超过屏幕大小，纵坐标加100，横坐标清空
                {
                    height += 100;
                    j = 0;
                }
                if(roomList[i].R_RoomState1 == 1)
                {
                    btn.Text = roomList[i].R_RoomId1 + "  使用中  " + roomList[i].R_RoomType1;
                    btn.BackColor = Color.Red;
                }
                else if (roomList[i].R_RoomState1 == 0)
                {
                    btn.Text = roomList[i].R_RoomId1 + "  空闲中  " + roomList[i].R_RoomType1;
                    btn.BackColor = Color.Green;
                }
                btn.Name = "btnRoom" + roomList[i].R_RoomId1;
                btn.Size = new Size(200, 100);
                btn.Location = new Point(j * weight, height);
                List<string> taglist = new List<string>();
                taglist.Add(roomList[i].R_RoomId1.ToString());
                taglist.Add("");
                btn.Tag = taglist;
                btn.Click += new System.EventHandler(btn_Click);
                this.Controls.Add(btn);//将创建好的btn添加到窗体
            }
        }
        #endregion
        #region 修改
        /// <summary>
        /// 动态添加的按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.Red || btn.BackColor == Color.Green)
            {
                UpdataState(btn);
            }
            if(btn.BackColor == Color.OrangeRed)
            {
                MessageBox.Show(((List<string>)btn.Tag)[1],"请立即处理",MessageBoxButtons.OK,MessageBoxIcon.Information);
                roommanage.CloseServer(Convert.ToInt32(((List<string>)btn.Tag)[0]));
                roommanage.CloseFoodSubmit(Convert.ToInt32(((List<string>)btn.Tag)[0]));
                roommanage.ClosePayServer(Convert.ToInt32(((List<string>)btn.Tag)[0]));
                btn.BackColor = Color.Red;
                this.tsmi.ForeColor = Color.Black;
                if(((List<string>)btn.Tag)[1].Contains("结账"))
                {
                    DialogResult result = MessageBox.Show("要打印发票吗？","发票打印",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                    if(result == DialogResult.OK)
                    {
                        this.label1.Text = "KTV自助系统\n"+((List<string>)btn.Tag)[1].ToString().Remove(0,15);

                        this.printDocument1.Print();
                    }
                    roommanage.UpdataState(Convert.ToInt32(((List<string>)btn.Tag)[0]), "有人");
                    btn.BackColor = Color.Green;
                    btn.Text = btn.Text.Replace("  使用中  ", "  空闲中  ");
                }
                ((List<string>)btn.Tag)[1] = "";
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        public void UpdataState(Button btn)
        {
            if (btn.BackColor == Color.Green)//选择空闲的包厢
            {
                DialogResult sure = MessageBox.Show("确定要开启" + ((List<string>)btn.Tag)[0] + "包厢吗","开启",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(sure == DialogResult.OK)
                {
                    bool result = roommanage.UpdataState(Convert.ToInt32(((List<string>)btn.Tag)[0]), "空闲");
                    if (result)
                    {
                        btn.BackColor = Color.Red;
                        MessageBox.Show(((List<string>)btn.Tag)[0] + "包厢已开启", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn.Text = btn.Text.Replace("  空闲中  ", "  使用中  ");
                        return;
                    }
                    MessageBox.Show("更新状态失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (btn.BackColor == Color.Red)//选择有人的包厢
            {
                DialogResult sure = MessageBox.Show("确定要关闭" + ((List<string>)btn.Tag)[0] + "包厢吗", "开启", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (sure == DialogResult.OK)
                {
                    bool result = roommanage.UpdataState(Convert.ToInt32(((List<string>)btn.Tag)[0]), "有人");
                    if (result)
                    {
                        btn.BackColor = Color.Green;
                        MessageBox.Show(((List<string>)btn.Tag)[0] + "包厢已关闭", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn.Text = btn.Text.Replace("  使用中  ", "  空闲中  ");
                        return;
                    }
                }
                MessageBox.Show("更新状态失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region 添加
        /// <summary>
        /// 显示添加包厢pnl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            this.pnlAddRoom.Visible = true;
        }
        /// <summary>
        /// 取消添加按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.pnlAddRoom.Visible = false;
        }
        /// <summary>
        /// 非空判断
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            if(this.txtRoomId.Text.Trim() == "")
            {
                MessageBox.Show("包厢ID不能为空","新增",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.txtRoomId.Focus();
                return false;
            }
            if (this.cmbRoomType.Text.Trim() == "")
            {
                MessageBox.Show("包厢类型不能为空", "新增", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmbRoomType.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// 添加包厢
        /// </summary>
        public void AddRoom()
        {
            Room room = new Room();
            room.R_RoomId1 = Convert.ToInt32(this.txtRoomId.Text.Trim());
            room.R_RoomState1 = 0;
            room.R_RoomType1 = this.cmbRoomType.Text.Trim();
            bool result = roommanage.AddRoom(room);
            if (result)
            {
                MessageBox.Show("新增成功", "新增", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtRoomId.Text = "";
                this.cmbRoomType.Text = "";
                AddRomeBtn();
                this.pnlAddRoom.Visible = false;
                return;
            }
            MessageBox.Show("新增失败", "新增", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// 添加包厢按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRoom_Click_1(object sender, EventArgs e)
        {
            if(CheckInput())
            {
                AddRoom();
            }
        }
        #endregion
        /// <summary>
        /// 服务状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timServerPnl_Tick(object sender, EventArgs e)
        {
            RoomManage room = new RoomManage();
            int ServerroomId = 0;
            ServerroomId = room.GetServerRoom();
            if (ServerroomId != 0)
            {
                timServerPnl.Stop();
                foreach(Control c in this.Controls)
                {
                    if(c.Tag == null)
                    {
                        continue;
                    }
                    if(c.Tag.GetType() == typeof(List<string>))
                    {
                        if (Convert.ToInt32(((List<string>)c.Tag)[0]) == ServerroomId)
                        {
                            c.BackColor = Color.OrangeRed;
                            ((List<string>)c.Tag)[1] = ((List<string>)c.Tag)[0] + "请求服务";
                            break;
                        }
                    }
                }
                this.timServerPnl.Start();
                
            }
            TimeSpan recordTime = DateTime.Now.Subtract(startTime);
            if (recordTime.Seconds % 5 == 0)
            {
                //10秒中手动回收一次内存
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        /// <summary>
        /// 刷新食物
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timFoodServer_Tick(object sender, EventArgs e)
        {
            RoomManage roommanage = new RoomManage();
            Room room = new Room();
            room = roommanage.GetFoodList();
            if (room != null)
            {
                this.timFoodServer.Stop();
                foreach (Control c in this.Controls)
                {
                    if (c.Tag == null)
                    {
                        continue;
                    }
                    if (c.Tag.GetType() == typeof(List<string>))
                    {
                        if (Convert.ToInt32(((List<string>)c.Tag)[0]) == room.R_RoomId1)
                        {
                            c.BackColor = Color.OrangeRed;
                            ((List<string>)c.Tag)[1] = ((List<string>)c.Tag)[0].ToString() + "包厢点餐：\n" + room.R_RoomFoodedList1;
                            break;
                        }
                    }
                }
                this.timFoodServer.Start();
            }
            TimeSpan recordTime = DateTime.Now.Subtract(startTime);
            if (recordTime.Seconds % 5 == 0)
            {
                //10秒中手动回收一次内存
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        /// <summary>
        /// 刷新结账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timPayServer_Tick(object sender, EventArgs e)
        {
            RoomManage roommanage = new RoomManage();
            Room room = new Room();
            room = roommanage.GetPayServerRoom();
            if (room != null)
            {
                this.timFoodServer.Stop();
                foreach (Control c in this.Controls)
                {
                    if (c.Tag == null)
                    {
                        continue;
                    }
                    if (c.Tag.GetType() == typeof(List<string>))
                    {
                        if (Convert.ToInt32(((List<string>)c.Tag)[0]) == room.R_RoomId1)
                        {
                            c.BackColor = Color.OrangeRed;
                            ((List<string>)c.Tag)[1] = ((List<string>)c.Tag)[0].ToString() + "包厢请求结账，餐单如下：\n" + room.R_RoomFoodedList1 + "共消费\t\t" + room.R_RoomFoodedMoney1 + "元";
                            break;
                        }
                    }
                }
                this.timFoodServer.Start();
            }
            TimeSpan recordTime = DateTime.Now.Subtract(startTime);
            if (recordTime.Seconds % 5 == 0)
            {
                //10秒中手动回收一次内存
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            foreach (Control c in Controls)
            {
                if(c.Tag == null)
                {
                    continue;
                }
                if (c.Tag.ToString() == "print")
                {
                    e.Graphics.DrawString(c.Text, c.Font,new SolidBrush(c.ForeColor), 0,0);
                }
            }
        }
    }
}
