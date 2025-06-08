namespace TeaShopMIS
{
    partial class Frm_UserInfoManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_Cancel = new Button();
            btn_Save = new Button();
            comboBox1 = new ComboBox();
            txt_Pwd = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_realName = new TextBox();
            txt_userName = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbl_Operation = new Label();
            groupBox2 = new GroupBox();
            lv_UserInfo = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btn_Delete = new Button();
            btn_repwd = new Button();
            btn_down = new Button();
            btn_on = new Button();
            lbl_Note = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Cancel);
            groupBox1.Controls.Add(btn_Save);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txt_Pwd);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_realName);
            groupBox1.Controls.Add(txt_userName);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl_Operation);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(813, 282);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "编辑员工信息   状态：";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(465, 228);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(112, 34);
            btn_Cancel.TabIndex = 13;
            btn_Cancel.Text = "取消";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(237, 228);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(112, 34);
            btn_Save.TabIndex = 12;
            btn_Save.Text = "保存";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "管理员", "职员" });
            comboBox1.Location = new Point(538, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 32);
            comboBox1.TabIndex = 11;
            // 
            // txt_Pwd
            // 
            txt_Pwd.Location = new Point(538, 40);
            txt_Pwd.Name = "txt_Pwd";
            txt_Pwd.Size = new Size(229, 30);
            txt_Pwd.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 110);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 9;
            label4.Text = "用户类别：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(432, 43);
            label5.Name = "label5";
            label5.Size = new Size(84, 24);
            label5.TabIndex = 8;
            label5.Text = "密    码：";
            // 
            // txt_realName
            // 
            txt_realName.Location = new Point(119, 113);
            txt_realName.Name = "txt_realName";
            txt_realName.Size = new Size(256, 30);
            txt_realName.TabIndex = 7;
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(118, 43);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(256, 30);
            txt_userName.TabIndex = 6;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(217, 173);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 28);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "禁用";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(119, 173);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(71, 28);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "启用";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 177);
            label3.Name = "label3";
            label3.Size = new Size(84, 24);
            label3.TabIndex = 3;
            label3.Text = "状    态：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 113);
            label2.Name = "label2";
            label2.Size = new Size(84, 24);
            label2.TabIndex = 2;
            label2.Text = "姓    名：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 46);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 1;
            label1.Text = "用户名：";
            // 
            // lbl_Operation
            // 
            lbl_Operation.AutoSize = true;
            lbl_Operation.Location = new Point(197, 0);
            lbl_Operation.Name = "lbl_Operation";
            lbl_Operation.Size = new Size(46, 24);
            lbl_Operation.TabIndex = 0;
            lbl_Operation.Text = "添加";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lv_UserInfo);
            groupBox2.Controls.Add(btn_Delete);
            groupBox2.Controls.Add(btn_repwd);
            groupBox2.Controls.Add(btn_down);
            groupBox2.Controls.Add(btn_on);
            groupBox2.Location = new Point(12, 345);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(813, 385);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "员工信息列表";
            // 
            // lv_UserInfo
            // 
            lv_UserInfo.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lv_UserInfo.FullRowSelect = true;
            lv_UserInfo.GridLines = true;
            lv_UserInfo.Location = new Point(6, 40);
            lv_UserInfo.MultiSelect = false;
            lv_UserInfo.Name = "lv_UserInfo";
            lv_UserInfo.Size = new Size(801, 339);
            lv_UserInfo.TabIndex = 4;
            lv_UserInfo.UseCompatibleStateImageBehavior = false;
            lv_UserInfo.View = View.Details;
            lv_UserInfo.SelectedIndexChanged += lv_UserInfo_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "用户名";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "密码";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "姓名";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "类别";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "状态";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 90;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(586, 0);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(112, 34);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "删除";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_repwd
            // 
            btn_repwd.Location = new Point(443, 0);
            btn_repwd.Name = "btn_repwd";
            btn_repwd.Size = new Size(112, 34);
            btn_repwd.TabIndex = 2;
            btn_repwd.Text = "重置密码";
            btn_repwd.UseVisualStyleBackColor = true;
            btn_repwd.Click += btn_repwd_Click;
            // 
            // btn_down
            // 
            btn_down.Location = new Point(300, 0);
            btn_down.Name = "btn_down";
            btn_down.Size = new Size(112, 34);
            btn_down.TabIndex = 1;
            btn_down.Text = "禁用";
            btn_down.UseVisualStyleBackColor = true;
            btn_down.Click += btn_down_Click;
            // 
            // btn_on
            // 
            btn_on.Location = new Point(157, 0);
            btn_on.Name = "btn_on";
            btn_on.Size = new Size(112, 34);
            btn_on.TabIndex = 0;
            btn_on.Text = "启用";
            btn_on.UseVisualStyleBackColor = true;
            btn_on.Click += btn_on_Click;
            // 
            // lbl_Note
            // 
            lbl_Note.AutoSize = true;
            lbl_Note.Location = new Point(323, 318);
            lbl_Note.Name = "lbl_Note";
            lbl_Note.Size = new Size(0, 24);
            lbl_Note.TabIndex = 2;
            // 
            // Frm_UserInfoManage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 736);
            Controls.Add(lbl_Note);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_UserInfoManage";
            Text = "员工信息管理";
            Load += Frm_UserInfoManage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbl_Operation;
        private GroupBox groupBox2;
        private Button btn_Cancel;
        private Button btn_Save;
        private ComboBox comboBox1;
        private TextBox txt_Pwd;
        private Label label4;
        private Label label5;
        private TextBox txt_realName;
        private TextBox txt_userName;
        private Button btn_Delete;
        private Button btn_repwd;
        private Button btn_down;
        private Button btn_on;
        private Label lbl_Note;
        private ListView lv_UserInfo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}