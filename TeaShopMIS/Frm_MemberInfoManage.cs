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
    public partial class Frm_MemberInfoManage : Form
    {
        public Frm_MemberInfoManage()
        {
            InitializeComponent();
        }

        private void Frm_MemberInfoManage_Load(object sender, EventArgs e)
        {
            DataBind_MemberInfo();
        }

        protected void DataBind_MemberInfo()
        {
            string sqlstr = "select * from Member_Info";
            DataTable dt = DataWork.DataQuery(sqlstr);
            lv_MemberInfo.Items.Clear();  //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["MemberID"].ToString());
                myitem.SubItems.Add(dr["MemberName"].ToString());
                myitem.SubItems.Add(dr["MemberNumber"].ToString());
                switch (dr["Sex"].ToString())   //状态
                {
                    case "1": myitem.SubItems.Add("男"); break;
                    case "2": myitem.SubItems.Add("女"); break;
                    default: break;
                }
                myitem.SubItems.Add(dr["Telephone"].ToString());
                switch (dr["Status"].ToString())   //状态
                {
                    case "1": myitem.SubItems.Add("正常"); break;
                    case "2": myitem.SubItems.Add("删除"); break;
                    default: break;
                }
                myitem.SubItems.Add(dr["Remark"].ToString());
                lv_MemberInfo.Items.Add(myitem);  //将新建项添加到ListView控件中
            }
        }

        string memid;    //全局变量

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string id = txt_creditNum.Text.Trim();
            string name = txt_Name.Text.Trim();
            string tel = txt_Telephone.Text.Trim();
            string note = txt_note.Text.Trim();
            string status = radioButton1.Checked ? "1" : "2";
            string sex = radioButton3.Checked ? "1" : "2";
            if (id == "")
            {
                lbl_Note.Text = "会员卡号不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_creditNum.Focus();
            }
            else if (name == "")
            {
                lbl_Note.Text = "姓名不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_Name.Focus();
            }
            else if (lbl_status.Text == "添加")
            {
                string sqlstr = string.Format("insert into Member_Info values('{0}','{1}',{2},'{3}',{4},'{5}') ", name, id, sex, tel, status, note);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "会员信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_MemberInfo();
                }
                else
                {
                    lbl_Note.Text = "对不起，会员信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else
            {
                string sqlstr = string.Format("update Member_Info set MemberName='{0}', MemberNumber='{1}', Sex ={2}, Telephone ='{3}', Status ={4}, Remark ='{5}' where MemberID = {6}", name, id, sex, tel, status, note, memid);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "会员信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();   //调用函数，清空各控件
                    DataBind_MemberInfo();  //重新加载饮品信息}
                }
                else
                {
                    lbl_Note.Text = "对不起，会员信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }

        protected void ClearTextBox()
        {
            txt_creditNum.Text = "";
            txt_Name.Text = "";
            txt_Telephone.Text = "";
            txt_note.Text = "";
            lbl_status.Text = "添加";
            lbl_Note.Text = "";
        }

        private void lv_MemberInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_MemberInfo.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem = lv_MemberInfo.SelectedItems[0]; //获取选中的第一行(一次只能选一行)
                memid = myitem.SubItems[0].Text; //将选中行第1列的值赋值全局变量，饮品编号
                txt_Name.Text = myitem.SubItems[1].Text;
                txt_creditNum.Text = myitem.SubItems[2].Text;
                txt_Telephone.Text = myitem.SubItems[4].Text;
                txt_note.Text = myitem.SubItems[6].Text;
                switch (myitem.SubItems[3].Text)
                {
                    case "男": radioButton3.Checked = true; break;
                    case "女": radioButton4.Checked = true; break;
                    default: /*radioButton3.Checked = true;*/ break;
                }
                switch (myitem.SubItems[5].Text)
                {
                    case "正常": radioButton1.Checked = true; break;
                    case "删除": radioButton2.Checked = true; break;
                    default: /*radioButton1.Checked = true;*/ break;
                }
                lbl_status.Text = "修改";
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();  //调用函数，清空各控件
            lbl_status.Text = "添加";
            lbl_Note.Text = "";
            memid = "";
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (memid == "")
            {
                MessageBox.Show("请先选择要设置的会员信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要设置选中的会员状态为“正常”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update Member_Info set Status = 1 where MemberID={0}", memid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，会员状态成功修改为“正常”！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_MemberInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，会员状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (memid == "")
            {
                MessageBox.Show("请先选择要删除的会员信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的会员信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("delete from Member_Info where MemberID={0}", memid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，会员信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_MemberInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，会员信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
