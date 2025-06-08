using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        // 获取图片目录绝对路径
        private string GetImageDirectory()
        {
            return Path.Combine(Application.StartupPath, "饮品店图片");
        }

        //加载饮品信息
        protected void DataBind_TeaInfo()
        {
            string sqlstr = "select * from Tea_Info";
            DataTable dt = DataWork.DataQuery(sqlstr);
            lv_TeaInfo.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["TeaID"].ToString());
                myitem.SubItems.Add(dr["TeaName"].ToString());
                myitem.SubItems.Add(dr["Price_Small"].ToString());
                myitem.SubItems.Add(dr["Price_Medium"].ToString());
                myitem.SubItems.Add(dr["Price_Large"].ToString());

                switch (dr["Status"].ToString())
                {
                    case "1": myitem.SubItems.Add("在售"); break;
                    case "2": myitem.SubItems.Add("售完"); break;
                    case "3": myitem.SubItems.Add("停售"); break;
                    default: break;
                }

                // 相对路径 -> 绝对路径
                string relativePath = dr["TeaImage"].ToString();
                string fullPath = Path.Combine(GetImageDirectory(), relativePath);
                myitem.SubItems.Add(relativePath); // 保持相对路径
                lv_TeaInfo.Items.Add(myitem);
            }
        }

        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "图片(*.jpg;*.png)|*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = openFileDialog1.FileName;
                string imageDirectory = GetImageDirectory();

                if (!Directory.Exists(imageDirectory))
                {
                    Directory.CreateDirectory(imageDirectory);
                }

                string fileName = Path.GetFileName(selectedPath);
                string destinationPath = Path.Combine(imageDirectory, fileName);

                // 如果文件不存在，则复制
                if (!File.Exists(destinationPath))
                {
                    File.Copy(selectedPath, destinationPath);
                }

                pictureBox1.ImageLocation = destinationPath;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string teaName = txt_TeaName.Text.Trim();
            string teaImagePath = pictureBox1.ImageLocation;
            string priceSmall = txt_Price_Small.Text.Trim();
            string priceMedium = txt_Price_Medium.Text.Trim();
            string priceLarge = txt_Price_Large.Text.Trim();
            int status = ccb_Status.SelectedIndex + 1;

            // 取相对路径
            string relativeImagePath = "";
            if (!string.IsNullOrEmpty(teaImagePath))
            {
                relativeImagePath = Path.GetFileName(teaImagePath);
            }

            if (teaName == "")
            {
                lbl_Note.Text = "饮品名称不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_TeaName.Focus();
            }
            else if (lbl_Operation.Text == "添加")
            {
                string sqlstr = string.Format("insert into Tea_Info values('{0}','{1}',{2},{3},{4},{5}) ",
                    teaName, relativeImagePath, priceSmall, priceMedium, priceLarge, status);
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
                string sqlstr = string.Format("update Tea_Info set TeaName='{0}', TeaImage='{1}', Price_Small ={2}, Price_Medium ={3}, Price_Large ={4}, Status ={5} where TeaID = {6}",
                    teaName, relativeImagePath, priceSmall, priceMedium, priceLarge, status, teaid);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "饮品信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_TeaInfo();
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

        string teaid; //全局变量

        private void lv_TeaInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_TeaInfo.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_TeaInfo.SelectedItems[0];
                teaid = myitem.SubItems[0].Text;
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

                string relativePath = myitem.SubItems[6].Text;
                string fullPath = Path.Combine(GetImageDirectory(), relativePath);
                pictureBox1.ImageLocation = fullPath;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                lbl_Operation.Text = "修改";
            }
        }

        private void btn_OnSale_Click(object sender, EventArgs e)
        {
            UpdateStatus(1, "在售");
        }

        private void btn_Soldout_Click(object sender, EventArgs e)
        {
            UpdateStatus(2, "售完");
        }

        private void btn_Discontinued_Click(object sender, EventArgs e)
        {
            UpdateStatus(3, "停售");
        }

        private void UpdateStatus(int statusCode, string statusText)
        {
            if (string.IsNullOrEmpty(teaid))
            {
                MessageBox.Show("请先选择要设置的饮品信息");
                return;
            }

            DialogResult result = MessageBox.Show($"确定要设置选中的饮品状态为“{statusText}”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sqlstr = $"update Tea_Info set Status = {statusCode} where TeaID={teaid}";
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = $"恭喜您，饮品状态成功修改为“{statusText}”！";
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
                    string sqlstr = $"delete from Tea_Info where TeaID={teaid}";
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
            ClearTextBox();
            lbl_Operation.Text = "添加";
            lbl_Note.Text = "";
            teaid = "";
        }
    }
}
