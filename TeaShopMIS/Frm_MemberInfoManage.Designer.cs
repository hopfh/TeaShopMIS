namespace TeaShopMIS
{
    partial class Frm_MemberInfoManage
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
            panel2 = new Panel();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            txt_note = new TextBox();
            label4 = new Label();
            txt_Name = new TextBox();
            txt_Telephone = new TextBox();
            label3 = new Label();
            txt_creditNum = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lbl_status = new Label();
            groupBox2 = new GroupBox();
            lv_MemberInfo = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btn_Delete = new Button();
            btn_right = new Button();
            lbl_Note = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Cancel);
            groupBox1.Controls.Add(btn_Save);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_note);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_Name);
            groupBox1.Controls.Add(txt_Telephone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_creditNum);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl_status);
            groupBox1.Location = new Point(26, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(731, 331);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "编辑会员信息   状态：";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(448, 275);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(112, 34);
            btn_Cancel.TabIndex = 14;
            btn_Cancel.Text = "取消";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(233, 275);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(112, 34);
            btn_Save.TabIndex = 13;
            btn_Save.Text = "保存";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton4);
            panel2.Controls.Add(radioButton3);
            panel2.Location = new Point(448, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 65);
            panel2.TabIndex = 12;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(138, 20);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(53, 28);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "女";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(40, 20);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(53, 28);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "男";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(104, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 65);
            panel1.TabIndex = 11;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(146, 17);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 28);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "删除";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(27, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(71, 28);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "正常";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 187);
            label6.Name = "label6";
            label6.Size = new Size(64, 24);
            label6.TabIndex = 10;
            label6.Text = "状态：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 117);
            label5.Name = "label5";
            label5.Size = new Size(64, 24);
            label5.TabIndex = 9;
            label5.Text = "性别：";
            // 
            // txt_note
            // 
            txt_note.Location = new Point(473, 187);
            txt_note.Name = "txt_note";
            txt_note.Size = new Size(215, 30);
            txt_note.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 187);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 7;
            label4.Text = "备注：";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(473, 40);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(215, 30);
            txt_Name.TabIndex = 6;
            // 
            // txt_Telephone
            // 
            txt_Telephone.Location = new Point(119, 114);
            txt_Telephone.Name = "txt_Telephone";
            txt_Telephone.Size = new Size(215, 30);
            txt_Telephone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 46);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 4;
            label3.Text = "姓名：";
            // 
            // txt_creditNum
            // 
            txt_creditNum.Location = new Point(119, 43);
            txt_creditNum.Name = "txt_creditNum";
            txt_creditNum.Size = new Size(215, 30);
            txt_creditNum.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 120);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 2;
            label2.Text = "电话：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 49);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 1;
            label1.Text = "会员卡号：";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(194, 0);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(46, 24);
            lbl_status.TabIndex = 0;
            lbl_status.Text = "添加";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lv_MemberInfo);
            groupBox2.Controls.Add(btn_Delete);
            groupBox2.Controls.Add(btn_right);
            groupBox2.Location = new Point(26, 421);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(731, 464);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "会员信息列表";
            // 
            // lv_MemberInfo
            // 
            lv_MemberInfo.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lv_MemberInfo.FullRowSelect = true;
            lv_MemberInfo.GridLines = true;
            lv_MemberInfo.Location = new Point(6, 40);
            lv_MemberInfo.MultiSelect = false;
            lv_MemberInfo.Name = "lv_MemberInfo";
            lv_MemberInfo.Size = new Size(719, 418);
            lv_MemberInfo.TabIndex = 17;
            lv_MemberInfo.UseCompatibleStateImageBehavior = false;
            lv_MemberInfo.View = View.Details;
            lv_MemberInfo.SelectedIndexChanged += lv_MemberInfo_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "会员姓名";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "会员卡号";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "性别";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "电话";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "状态";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "备注";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 105;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(302, 0);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(112, 34);
            btn_Delete.TabIndex = 16;
            btn_Delete.Text = "删除";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_right
            // 
            btn_right.Location = new Point(155, 0);
            btn_right.Name = "btn_right";
            btn_right.Size = new Size(112, 34);
            btn_right.TabIndex = 15;
            btn_right.Text = "设为正常";
            btn_right.UseVisualStyleBackColor = true;
            btn_right.Click += btn_right_Click;
            // 
            // lbl_Note
            // 
            lbl_Note.AutoSize = true;
            lbl_Note.Location = new Point(314, 376);
            lbl_Note.Name = "lbl_Note";
            lbl_Note.Size = new Size(0, 24);
            lbl_Note.TabIndex = 15;
            // 
            // Frm_MemberInfoManage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 897);
            Controls.Add(lbl_Note);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_MemberInfoManage";
            Text = "会员信息管理";
            Load += Frm_MemberInfoManage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private TextBox txt_note;
        private Label label4;
        private TextBox txt_Name;
        private TextBox txt_Telephone;
        private Label label3;
        private TextBox txt_creditNum;
        private Label label2;
        private Label label1;
        private Label lbl_status;
        private GroupBox groupBox2;
        private Panel panel2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Panel panel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private Button btn_Cancel;
        private Button btn_Save;
        private ListView lv_MemberInfo;
        private Button btn_Delete;
        private Button btn_right;
        private Label lbl_Note;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}