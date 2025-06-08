using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace TeaShopMIS
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        protected string StringFilter(string str)
        {
            str = str.Replace("or", "");
            str = str.Replace("and", "");
            str = str.Replace("--", "");
            str = str.Replace(" ", "");
            return str;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = StringFilter(txt_UserName.Text);
            string password = StringFilter(txt_Password.Text);

            if (username == "")
            {
                lbl_Note.Text = "账号不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_UserName.Focus();
            }
            else if (password == "")
            {
                lbl_Note.Text = "密码不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_Password.Focus();
            }
            else
            {
                string sqlstr = string.Format("select * from User_Info where UserName = '{0}'", username);
                DataTable dt = DataWork.DataQuery(sqlstr);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("对不起，用户名不存在！");
                }
                else if (dt.Rows[0]["Password"].ToString() != password)
                {
                    MessageBox.Show("对不起，密码不正确！");
                }
                else if (dt.Rows[0]["Status"].ToString() != "1")
                {
                    MessageBox.Show("对不起，该用户状态已经失效，请联系系统管理人员进行设置！");
                }
                else
                {
                    Frm_Main frm_main = new Frm_Main();
                    ConfigurationManager.AppSettings["UserID"] = dt.Rows[0]["UserID"].ToString();
                    ConfigurationManager.AppSettings[" UserName"] = dt.Rows[0]["UserName"].ToString();
                    ConfigurationManager.AppSettings[" RealName"] = dt.Rows[0]["RealName"].ToString();

                    frm_main.Show();
                    this.Hide();
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }
    }
}
