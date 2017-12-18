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
    public partial class FrmFoodManage : Form
    {
        #region 加载
        FoodManage foodmanage = new FoodManage();
        public FrmFoodManage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFoodManage_Load(object sender, EventArgs e)
        {
            SearchFood();
        }
        #endregion
        #region 清空
        /// <summary>
        /// 查询清空按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCleanSearch_Click(object sender, EventArgs e)
        {
            CleanSearch();
        }
        /// <summary>
        /// 清空查询
        /// </summary>
        public void CleanSearch()
        {
            this.txtFoodNameSearch.Text = "";
            this.cmbFoodTypeSearch.Text = "";
        }
        /// <summary>
        /// 新增清空按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCleanAdd_Click(object sender, EventArgs e)
        {
            CleanAdd();
        }
        /// <summary>
        /// 清空新增
        /// </summary>
        public void CleanAdd()
        {
            this.txtFoodName.Text = "";
            this.txtFilePath.Text = "";
            this.cmbFoodType.Text = "";
            this.txtFoodPrice.Text = "";
        }
        #endregion
        #region 查询
        /// <summary>
        /// 查询按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchFood();
        }
        /// <summary>
        /// 查询食品信息
        /// </summary>
        public void SearchFood()
        {
            List<Food> foodList = foodmanage.GetFoodList(this.txtFoodNameSearch.Text.Trim(),this.cmbFoodTypeSearch.Text.Trim());
            if(foodList.Count == 0)
            {
                MessageBox.Show("没有查到数据", "查询", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.dgvFoodList.DataSource = foodList;
        }
        #endregion
        #region 删除
        /// <summary>
        /// 删除按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            DeleteFood();
        }
        /// <summary>
        /// 删除
        /// </summary>
        public void DeleteFood()
        {
            bool result = foodmanage.DeleteFood(this.dgvFoodList.SelectedRows[0].Cells[0].Value.ToString());
            if (result)
            {
                MessageBox.Show(this.dgvFoodList.SelectedRows[0].Cells[1].Value + "已被删除", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanSearch();
                SearchFood();
                return;
            }
            MessageBox.Show("删除失败", "删除", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        #region 新增
        /// <summary>
        /// 浏览文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindFilePath_Click(object sender, EventArgs e)
        {
            FindFilePath();
        }
        /// <summary>
        /// 浏览文件
        /// </summary>
        public void FindFilePath()
        {
            OpenFileDialog openfile = new OpenFileDialog();
            DialogResult result = openfile.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txtFilePath.Text = openfile.SafeFileName;
            }
        }
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            if (this.txtFoodName.Text.Trim() == "")
            {
                MessageBox.Show("食品名称不能为空", "新增", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtFoodName.Focus();
                return false;
            }
            if (this.cmbFoodType.Text.Trim() == "")
            {
                MessageBox.Show("食品类型不能为空", "新增", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmbFoodType.Focus();
                return false;
            }
            if (this.txtFoodPrice.Text.Trim() == "")
            {
                MessageBox.Show("食品价格不能为空", "新增", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtFoodPrice.Focus();
                return false;
            }
            if (this.txtFilePath.Text.Trim() == "")
            {
                MessageBox.Show("请选择食品照片", "新增", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtFilePath.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// 添加新食品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpData_Click(object sender, EventArgs e)
        {
            if(CheckInput())
            {
                AddFood();
            }
        }
        /// <summary>
        /// 添加
        /// </summary>
        public void AddFood()
        {
            if(foodmanage.GetFoodList(this.txtFoodName.Text.Trim(),this.cmbFoodType.Text.Trim()).Count == 0)
            {
                Food food = new Food();
                food.FI_FoodName1 = this.txtFoodName.Text.Trim();
                food.FI_FoodPhotoURL1 = this.txtFilePath.Text.Trim();
                food.FI_FoodPrice1 = Convert.ToInt32(this.txtFoodPrice.Text.Trim());
                food.FT_FoodTypeName1 = this.cmbFoodType.Text.Trim(); ;
                bool result = foodmanage.AddFood(food);
                if (result)
                {
                    MessageBox.Show("新增成功", "新增", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanAdd();
                    CleanSearch();
                    SearchFood();
                    return;
                }
                MessageBox.Show("新增失败", "新增", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("该食品已存在，无需添加","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
