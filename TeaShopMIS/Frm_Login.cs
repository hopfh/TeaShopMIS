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
                lbl_Note.Text = "�˺Ų���Ϊ�գ�";
                lbl_Note.ForeColor = Color.Red;
                txt_UserName.Focus();
            }
            else if (password == "")
            {
                lbl_Note.Text = "���벻��Ϊ�գ�";
                lbl_Note.ForeColor = Color.Red;
                txt_Password.Focus();
            }
            else
            {
                string sqlstr = string.Format("select * from User_Info where UserName = '{0}'", username);
                DataTable dt = DataWork.DataQuery(sqlstr);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("�Բ����û��������ڣ�");
                }
                else if (dt.Rows[0]["Password"].ToString() != password)
                {
                    MessageBox.Show("�Բ������벻��ȷ��");
                }
                else if (dt.Rows[0]["Status"].ToString() != "1")
                {
                    MessageBox.Show("�Բ��𣬸��û�״̬�Ѿ�ʧЧ������ϵϵͳ������Ա�������ã�");
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
