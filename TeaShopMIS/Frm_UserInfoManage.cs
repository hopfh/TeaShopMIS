using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaShopMIS
{
    public partial class Frm_UserInfoManage : Form
    {
        public Frm_UserInfoManage()
        {
            InitializeComponent();
        }

        private void Frm_UserInfoManage_Load(object sender, EventArgs e)
        {
            DataBind_UserInfo();
        }

        protected void DataBind_UserInfo()
        {
            string sqlstr = "select * from User_Info";
            DataTable dt = DataWork.DataQuery(sqlstr);
            lv_UserInfo.Items.Clear();  //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["UserID"].ToString());
                myitem.SubItems.Add(dr["UserName"].ToString());
                myitem.SubItems.Add(dr["Password"].ToString());
                myitem.SubItems.Add(dr["RealName"].ToString());
                switch (dr["UserType"].ToString())   //状态
                {
                    case "1": myitem.SubItems.Add("管理员"); break;
                    case "2": myitem.SubItems.Add("职员"); break;
                    default: break;
                }
                switch (dr["Status"].ToString())   //状态
                {
                    case "1": myitem.SubItems.Add("启用"); break;
                    case "2": myitem.SubItems.Add("禁用"); break;
                    default: break;
                }
                lv_UserInfo.Items.Add(myitem);  //将新建项添加到ListView控件中
            }
        }

        string userid;    //全局变量

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string username = txt_userName.Text.Trim();
            string pwd = txt_Pwd.Text.Trim();
            string realname = txt_realName.Text.Trim();
            int classes = comboBox1.SelectedIndex + 1;
            string status = radioButton1.Checked ? "1" : "2";

            if (username == "")
            {
                lbl_Note.Text = "用户名不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_userName.Focus();
            }
            else if (pwd == "")
            {
                lbl_Note.Text = "密码不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_userName.Focus();
            }
            else if (realname == "")
            {
                lbl_Note.Text = "姓名不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_userName.Focus();
            }
            else if (lbl_Operation.Text == "添加")
            {
                string sqlstr = string.Format("insert into User_Info values('{0}','{1}','{2}',{3},{4}) ", username, pwd, realname, classes, status);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "员工信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_UserInfo();
                }
                else
                {
                    lbl_Note.Text = "对不起，员工信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else
            {
                string sqlstr = string.Format("update User_Info set UserName='{0}', Password='{1}', RealName ='{2}', UserType ={3}, Status ={4} where UserID = {5}", username, pwd, realname, classes, status, userid);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "员工信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();   //调用函数，清空各控件
                    DataBind_UserInfo();  //重新加载饮品信息}
                }
                else
                {
                    lbl_Note.Text = "对不起，员工信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }

        protected void ClearTextBox()
        {
            txt_userName.Text = "";
            txt_Pwd.Text = "";
            txt_realName.Text = "";
            comboBox1.SelectedIndex = 0;
            lbl_Operation.Text = "添加";
            lbl_Note.Text = "";
        }

        private void lv_UserInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_UserInfo.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem = lv_UserInfo.SelectedItems[0]; //获取选中的第一行(一次只能选一行)
                userid = myitem.SubItems[0].Text; //将选中行第1列的值赋值全局变量，饮品编号
                txt_userName.Text = myitem.SubItems[1].Text;
                txt_Pwd.Text = myitem.SubItems[2].Text;
                txt_realName.Text = myitem.SubItems[3].Text;
                switch (myitem.SubItems[4].Text)
                {
                    case "管理员": comboBox1.SelectedIndex = 0; break;
                    case "职员": comboBox1.SelectedIndex = 1; break;
                    default: comboBox1.SelectedIndex = 0; break;
                }
                if (myitem.SubItems[5].Text == "启用")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                lbl_Operation.Text = "修改";
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();  //调用函数，清空各控件
            lbl_Operation.Text = "添加";
            lbl_Note.Text = "";
            userid = "";
        }

        private void btn_on_Click(object sender, EventArgs e)
        {
            if (userid == "")
            {
                MessageBox.Show("请先选择要设置的员工信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要设置选中的员工状态为“启用”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update User_Info set Status = 1 where UserID={0}", userid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，员工状态成功修改为“启用”！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();   //调用函数，清空各控件
                        DataBind_UserInfo();  //重新加载饮品信息}
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (userid == "")
            {
                MessageBox.Show("请先选择要设置的员工信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要设置选中的员工状态为“禁用”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update User_Info set Status = 2 where UserID={0}", userid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，员工状态成功修改为“禁用”！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();   //调用函数，清空各控件
                        DataBind_UserInfo();  //重新加载饮品信息}
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (userid == "")
            {
                MessageBox.Show("请先选择要删除的员工信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的员工信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("delete from User_Info where UserID={0}", userid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，员工信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_UserInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_repwd_Click(object sender, EventArgs e)
        {
            if (userid == "")
            {
                MessageBox.Show("请先选择要设置的员工信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要重置选中员工的密码？", "重置密码提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string pwd = txt_Pwd.Text;
                    string sqlstr = string.Format("update User_Info set Password = '{0}' where UserID={1}", pwd,userid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，员工密码重置成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_UserInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工密码重置失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
