using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TeaShopMIS
{
    public partial class Frm_TeaPriceManage : Form
    {
        public Frm_TeaPriceManage()
        {
            InitializeComponent();
        }
        string teaid = ""; //定义全局变量，用于存储选中的饮品编号
        string tpid = ""; //定义全局变量，用于存储选中的饮品价格编号
        protected void DataBind_TeaPrice(string teaid)
        {
            //查询所有饮品信息
            string sqlstr = string.Format("select * from Tea_Price where TeaID={0}", teaid);

            //调用数据查询函数
            DataTable dt = DataWork.DataQuery(sqlstr);

            //显示结果
            lv_TeaPrice.Items.Clear();  //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["TPID"].ToString());  //第1列，价格编号
                myitem.SubItems.Add(dr["Price_Small"].ToString());  //第2列，价格(小)
                myitem.SubItems.Add(dr["Price_Medium"].ToString()); //第3列，价格(中)
                myitem.SubItems.Add(dr["Price_Large"].ToString());  //第4列，价格(大)
                myitem.SubItems.Add(dr["BeginDate"].ToString());  //第5列，价格生效日期
                myitem.SubItems.Add(dr["EndDate"].ToString());  //第6列，价格失效日期

                lv_TeaPrice.Items.Add(myitem);  //将新建项添加到ListView控件中
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (dtp_EndDate.Value <= dtp_BeginDate.Value)
            {
                lbl_Note.Text = "失效日期应大于生效日期.";
                lbl_Note.ForeColor = Color.Red;
            }
            else if (lbl_Operation.Text == "添加")
            {
                string sqlstr = "insert into Tea_Price (TeaID, Price_Small, Price_Medium, Price_Large, BeginDate, EndDate) ";
                sqlstr += string.Format(" values ({0}, {1}, {2}, {3}, '{4}', '{5}')", teaid, txt_Price_Small.Text, txt_Price_Medium.Text, txt_Price_Large.Text, dtp_BeginDate.Value, dtp_EndDate.Value);

                int i = DataWork.DataExcute(sqlstr);

                if (i > 0)
                {
                    lbl_Note.Text = "饮品价格添加成功！";
                    lbl_Note.ForeColor = Color.Blue;

                    DataBind_TeaPrice(teaid); //重新加载饮品价格
                }
                else
                {
                    lbl_Note.Text = "饮品价格添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else if (lbl_Operation.Text == "修改")
            {
                string sqlstr = string.Format("update Tea_Price set Price_Small={0}, Price_Medium={1}, Price_Large={2}, BeginDate='{3}', EndDate='{4}' where TPID={5}", txt_Price_Small.Text, txt_Price_Medium.Text, txt_Price_Large.Text, dtp_BeginDate.Value, dtp_EndDate.Value, tpid);

                int i = DataWork.DataExcute(sqlstr);

                if (i > 0)
                {
                    lbl_Note.Text = "饮品价格修改成功！";
                    lbl_Note.ForeColor = Color.Blue;

                    DataBind_TeaPrice(teaid); //重新加载饮品价格
                }
                else
                {
                    lbl_Note.Text = "饮品价格修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }
        private void lv_TeaPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_TeaPrice.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem = lv_TeaPrice.SelectedItems[0]; //获取选中的第一行(一次只能选一行) 

                tpid = myitem.SubItems[0].Text; //将选中行第1列的值赋值全局变量，饮品编号

                txt_Price_Small.Text = myitem.SubItems[1].Text;  //价格(小)
                txt_Price_Medium.Text = myitem.SubItems[2].Text; //价格(中)
                txt_Price_Large.Text = myitem.SubItems[3].Text;  //价格(大)
                dtp_BeginDate.Value = DateTime.Parse(myitem.SubItems[4].Text);  //价格生效日期
                dtp_EndDate.Value = DateTime.Parse(myitem.SubItems[5].Text);  //价格失效日期               

                lbl_Operation.Text = "修改";
            }
        }

        private void Frm_TeaPriceManage_Load(object sender, EventArgs e)
        {
            DataBind_TeaInfo();
        }

        protected void DataBind_TeaInfo()
        {
            //查询所有饮品信息
            string sqlstr = "select * from Tea_Info";

            //调用数据查询函数
            DataTable dt = DataWork.DataQuery(sqlstr);

            //显示结果
            lv_TeaInfo.Items.Clear();  //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["TeaID"].ToString());  //创建一个ListViewItem项，并为第1列赋值，饮品编号
                myitem.SubItems.Add(dr["TeaName"].ToString());      //第2列，饮品名称
                myitem.SubItems.Add(dr["Price_Small"].ToString());  //第3列，价格(小)
                myitem.SubItems.Add(dr["Price_Medium"].ToString()); //第4列，价格(中)
                myitem.SubItems.Add(dr["Price_Large"].ToString());  //第5列，价格(大)
                switch (dr["Status"].ToString())   //第6列，状态
                {
                    case "1": myitem.SubItems.Add("在售"); break;
                    case "2": myitem.SubItems.Add("售完"); break;
                    case "3": myitem.SubItems.Add("停售"); break;
                    default: break;
                }
                myitem.SubItems.Add(dr["TeaImage"].ToString());  //第7列，图片路径

                lv_TeaInfo.Items.Add(myitem);  //将新建项添加到ListView控件中
            }
        }

        private void lv_TeaInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_TeaInfo.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem = lv_TeaInfo.SelectedItems[0]; //获取选中的第一行(一次只能选一行) 

                teaid = myitem.SubItems[0].Text; //将选中行第1列的值赋值全局变量，饮品编号
                txt_TeaName.Text = myitem.SubItems[1].Text;      //饮品名称                
                txt_Price_Small.Text = myitem.SubItems[2].Text;  //价格(小)
                txt_Price_Medium.Text = myitem.SubItems[3].Text; //价格(中)
                txt_Price_Large.Text = myitem.SubItems[4].Text;  //价格(大);
                pictureBox1.ImageLocation = myitem.SubItems[6].Text;      //饮品图片
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                DataBind_TeaPrice(teaid);  //加载饮品价格
            }
        }
        protected void ClearTextBox()
        {
            txt_TeaName.Text = "";
            txt_Price_Small.Text = "0";
            txt_Price_Medium.Text = "0";
            txt_Price_Large.Text = "0";
            lbl_Operation.Text = "添加";
            dtp_BeginDate.Value = DateTime.Now;
            dtp_EndDate.Value = DateTime.Now;
            pictureBox1.Image = null;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox(); //调用函数，清空各控件
            lbl_Operation.Text = "添加";
            lbl_Note.Text = "";
        }

        private void txt_Price_Small_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字，也不是退格键，也不是回车键
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true; //不接受此输入，即输入无效
            }
        }

        private void txt_Price_Medium_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字，也不是退格键，也不是回车键
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true; //不接受此输入，即输入无效
            }
        }

        private void txt_Price_Large_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字，也不是退格键，也不是回车键
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true; //不接受此输入，即输入无效
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (tpid == "")
            { MessageBox.Show("请先选择要删除的价格"); }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的价格信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("delete from Tea_Price where TPID={0}", tpid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，价格信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox(); //调用函数，清空各控件
                        DataBind_TeaPrice(teaid);//重新加载价格信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，价格信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
