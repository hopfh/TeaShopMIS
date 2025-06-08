using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeaShopMIS
{
    public partial class Frm_TeaInfoManage : Form
    {
        public Frm_TeaInfoManage()
        {
            InitializeComponent();
        }

        private void Frm_TeaInfoManage_Load(object sender, EventArgs e)
        {
            DataBind_TeaInfo(); //加载饮品信息
        }

        //加载饮品信息
        protected void DataBind_TeaInfo()
        {
            string sqlstr = "select * from Tea_Info";
            DataTable dt = DataWork.DataQuery(sqlstr);
            lv_TeaInfo.Items.Clear();  //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["TeaID"].ToString());  //饮品编号
                myitem.SubItems.Add(dr["TeaName"].ToString());
                //饮品名称
                myitem.SubItems.Add(dr["Price_Small"].ToString());  //价格(小)
                myitem.SubItems.Add(dr["Price_Medium"].ToString()); //价格(中)
                myitem.SubItems.Add(dr["Price_Large"].ToString());  //价格(大)
                switch (dr["Status"].ToString())   //状态
                {
                    case "1": myitem.SubItems.Add("在售"); break;
                    case "2": myitem.SubItems.Add("售完"); break;
                    case "3": myitem.SubItems.Add("停售"); break;
                    default: break;
                }
                myitem.SubItems.Add(dr["TeaImage"].ToString());  //图片路径
                lv_TeaInfo.Items.Add(myitem);  //将新建项添加到ListView控件中
            }
        }

        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "图片(*.jpg;*.png)|*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string teaName = txt_TeaName.Text.Trim();
            string teaImage = pictureBox1.ImageLocation;
            string priceSmall = txt_Price_Small.Text.Trim();
            string priceMedium = txt_Price_Medium.Text.Trim();
            string priceLarge = txt_Price_Large.Text.Trim();
            int status = ccb_Status.SelectedIndex + 1;
            if (teaName == "")
            {
                lbl_Note.Text = "饮品名称不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_TeaName.Focus();
            }
            else if (lbl_Operation.Text == "添加")
            {
                string sqlstr = string.Format("insert into Tea_Info values('{0}','{1}',{2},{3},{4},{5}) ", teaName, teaImage, priceSmall, priceMedium, priceLarge, status);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "饮品信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_TeaInfo();
                }
                else
                {
                    lbl_Note.Text = "对不起，饮品信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else
            {
                string sqlstr = string.Format("update Tea_Info set TeaName='{0}', TeaImage='{1}', Price_Small ={2}, Price_Medium ={3}, Price_Large ={4}, Status ={5} where TeaID = {6}", teaName, teaImage, priceSmall, priceMedium, priceLarge, status, teaid);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "饮品信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();   //调用函数，清空各控件
                    DataBind_TeaInfo();  //重新加载饮品信息
                }
                else
                {
                    lbl_Note.Text = "对不起，饮品信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }

        }

        protected void ClearTextBox()
        {
            txt_TeaName.Text = "";
            pictureBox1.ImageLocation = "";
            txt_Price_Medium.Text = "0";
            txt_Price_Small.Text = "0";
            txt_Price_Large.Text = "0";
            ccb_Status.SelectedIndex = 0;
            lbl_Operation.Text = "添加";
            lbl_Note.Text = "";
        }

        string teaid;   //全局变量

        private void lv_TeaInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_TeaInfo.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem = lv_TeaInfo.SelectedItems[0]; //获取选中的第一行(一次只能选一行)
                teaid = myitem.SubItems[0].Text; //将选中行第1列的值赋值全局变量，饮品编号
                txt_TeaName.Text = myitem.SubItems[1].Text;
                txt_Price_Small.Text = myitem.SubItems[2].Text;
                txt_Price_Medium.Text = myitem.SubItems[3].Text;
                txt_Price_Large.Text = myitem.SubItems[4].Text;
                switch (myitem.SubItems[5].Text)
                {
                    case "在售": ccb_Status.SelectedIndex = 0; break;
                    case "售完": ccb_Status.SelectedIndex = 1; break;
                    case "停售": ccb_Status.SelectedIndex = 2; break;
                    default: ccb_Status.SelectedIndex = 0; break;
                }
                pictureBox1.ImageLocation = myitem.SubItems[6].Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                lbl_Operation.Text = "修改";
            }
        }

        private void btn_OnSale_Click(object sender, EventArgs e)
        {
            if (teaid == "")
            {
                MessageBox.Show("请先选择要设置的饮品信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要设置选中的饮品状态为“在售”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update Tea_Info set Status = 1 where TeaID={0}", teaid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，饮品状态成功修改为“在售”！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();   //调用函数，清空各控件
                        DataBind_TeaInfo();  //重新加载饮品信息}
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，饮品状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Soldout_Click(object sender, EventArgs e)
        {
            if (teaid == "")
            {
                MessageBox.Show("请先选择要设置的饮品信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要设置选中的饮品状态为“售完”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update Tea_Info set Status = 2 where TeaID={0}", teaid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，饮品状态成功修改为“售完”！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_TeaInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，饮品状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Discontinued_Click(object sender, EventArgs e)
        {
            if (teaid == "")
            {
                MessageBox.Show("请先选择要设置的饮品信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要设置选中的饮品状态为“停售”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update Tea_Info set Status = 3 where TeaID={0}", teaid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，饮品状态成功修改为“停售”！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_TeaInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，饮品状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (teaid == "")
            {
                MessageBox.Show("请先选择要删除的饮品信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的饮品信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("delete from Tea_Info where TeaID={0}", teaid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，饮品信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_TeaInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，饮品信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void txt_Price_Small_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字，也不是退格键，也不是回车键
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void txt_Price_Medium_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void txt_Price_Large_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();  //调用函数，清空各控件
            lbl_Operation.Text = "添加";
            lbl_Note.Text = "";
            teaid = "";
        }
    }
}
