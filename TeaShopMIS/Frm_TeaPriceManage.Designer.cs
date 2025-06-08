namespace TeaShopMIS
{
    partial class Frm_TeaPriceManage
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
            lbl_Note = new Label();
            pictureBox1 = new PictureBox();
            btn_Cancel = new Button();
            btn_Save = new Button();
            dtp_EndDate = new DateTimePicker();
            dtp_BeginDate = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txt_Price_Large = new TextBox();
            txt_Price_Medium = new TextBox();
            txt_Price_Small = new TextBox();
            txt_TeaName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lbl_Operation = new Label();
            groupBox2 = new GroupBox();
            lv_TeaInfo = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btn_Delete = new Button();
            lv_TeaPrice = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_Note);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btn_Cancel);
            groupBox1.Controls.Add(btn_Save);
            groupBox1.Controls.Add(dtp_EndDate);
            groupBox1.Controls.Add(dtp_BeginDate);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_Price_Large);
            groupBox1.Controls.Add(txt_Price_Medium);
            groupBox1.Controls.Add(txt_Price_Small);
            groupBox1.Controls.Add(txt_TeaName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbl_Operation);
            groupBox1.Location = new Point(26, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 410);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "修改饮品价格    当前操作：";
            // 
            // lbl_Note
            // 
            lbl_Note.AutoSize = true;
            lbl_Note.Location = new Point(420, 364);
            lbl_Note.Name = "lbl_Note";
            lbl_Note.Size = new Size(0, 24);
            lbl_Note.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(406, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 328);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(253, 354);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(112, 34);
            btn_Cancel.TabIndex = 15;
            btn_Cancel.Text = "取消";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(94, 354);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(112, 34);
            btn_Save.TabIndex = 14;
            btn_Save.Text = "保存";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // dtp_EndDate
            // 
            dtp_EndDate.Location = new Point(139, 296);
            dtp_EndDate.Name = "dtp_EndDate";
            dtp_EndDate.Size = new Size(240, 30);
            dtp_EndDate.TabIndex = 13;
            // 
            // dtp_BeginDate
            // 
            dtp_BeginDate.Location = new Point(139, 254);
            dtp_BeginDate.Name = "dtp_BeginDate";
            dtp_BeginDate.Size = new Size(240, 30);
            dtp_BeginDate.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 301);
            label9.Name = "label9";
            label9.Size = new Size(100, 24);
            label9.TabIndex = 11;
            label9.Text = "失效日期：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 254);
            label8.Name = "label8";
            label8.Size = new Size(100, 24);
            label8.TabIndex = 10;
            label8.Text = "生效日期：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(253, 206);
            label7.Name = "label7";
            label7.Size = new Size(82, 24);
            label7.TabIndex = 9;
            label7.Text = "（大份）";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 147);
            label6.Name = "label6";
            label6.Size = new Size(82, 24);
            label6.TabIndex = 8;
            label6.Text = "（中份）";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 88);
            label5.Name = "label5";
            label5.Size = new Size(126, 24);
            label5.TabIndex = 7;
            label5.Text = "（正常/小份）";
            // 
            // txt_Price_Large
            // 
            txt_Price_Large.Location = new Point(139, 203);
            txt_Price_Large.Name = "txt_Price_Large";
            txt_Price_Large.Size = new Size(108, 30);
            txt_Price_Large.TabIndex = 6;
            txt_Price_Large.Text = "0";
            txt_Price_Large.KeyPress += txt_Price_Large_KeyPress;
            // 
            // txt_Price_Medium
            // 
            txt_Price_Medium.Location = new Point(139, 144);
            txt_Price_Medium.Name = "txt_Price_Medium";
            txt_Price_Medium.Size = new Size(108, 30);
            txt_Price_Medium.TabIndex = 5;
            txt_Price_Medium.Text = "0";
            txt_Price_Medium.KeyPress += txt_Price_Medium_KeyPress;
            // 
            // txt_Price_Small
            // 
            txt_Price_Small.Location = new Point(139, 85);
            txt_Price_Small.Name = "txt_Price_Small";
            txt_Price_Small.Size = new Size(108, 30);
            txt_Price_Small.TabIndex = 4;
            txt_Price_Small.Text = "0";
            txt_Price_Small.KeyPress += txt_Price_Small_KeyPress;
            // 
            // txt_TeaName
            // 
            txt_TeaName.Location = new Point(139, 37);
            txt_TeaName.Name = "txt_TeaName";
            txt_TeaName.Size = new Size(261, 30);
            txt_TeaName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 91);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 2;
            label4.Text = "饮品价格：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 40);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 1;
            label3.Text = "饮品名称：";
            // 
            // lbl_Operation
            // 
            lbl_Operation.AutoSize = true;
            lbl_Operation.Location = new Point(223, 0);
            lbl_Operation.Name = "lbl_Operation";
            lbl_Operation.Size = new Size(0, 24);
            lbl_Operation.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lv_TeaInfo);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(689, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(687, 797);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "饮品信息列表";
            // 
            // lv_TeaInfo
            // 
            lv_TeaInfo.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader17, columnHeader18, columnHeader19 });
            lv_TeaInfo.FullRowSelect = true;
            lv_TeaInfo.GridLines = true;
            lv_TeaInfo.Location = new Point(6, 37);
            lv_TeaInfo.MultiSelect = false;
            lv_TeaInfo.Name = "lv_TeaInfo";
            lv_TeaInfo.Size = new Size(681, 754);
            lv_TeaInfo.TabIndex = 5;
            lv_TeaInfo.UseCompatibleStateImageBehavior = false;
            lv_TeaInfo.View = View.Details;
            lv_TeaInfo.SelectedIndexChanged += lv_TeaInfo_SelectedIndexChanged;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "编号";
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "饮品名称";
            columnHeader14.TextAlign = HorizontalAlignment.Center;
            columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "价格(小)";
            columnHeader15.TextAlign = HorizontalAlignment.Center;
            columnHeader15.Width = 80;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "价格(中)";
            columnHeader16.TextAlign = HorizontalAlignment.Center;
            columnHeader16.Width = 80;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "价格(大)";
            columnHeader17.TextAlign = HorizontalAlignment.Center;
            columnHeader17.Width = 80;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "状态";
            columnHeader18.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "图片地址";
            columnHeader19.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_Delete);
            groupBox3.Controls.Add(lv_TeaPrice);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(26, 456);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(657, 365);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "饮品价格列表";
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(154, 0);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(112, 34);
            btn_Delete.TabIndex = 4;
            btn_Delete.Text = "删除";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // lv_TeaPrice
            // 
            lv_TeaPrice.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lv_TeaPrice.FullRowSelect = true;
            lv_TeaPrice.GridLines = true;
            lv_TeaPrice.Location = new Point(19, 40);
            lv_TeaPrice.MultiSelect = false;
            lv_TeaPrice.Name = "lv_TeaPrice";
            lv_TeaPrice.Size = new Size(629, 319);
            lv_TeaPrice.TabIndex = 1;
            lv_TeaPrice.UseCompatibleStateImageBehavior = false;
            lv_TeaPrice.View = View.Details;
            lv_TeaPrice.SelectedIndexChanged += lv_TeaPrice_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "价格（小）";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "价格（中）";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "价格（大）";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "生效日期";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "失效日期";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 120;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 24);
            label2.TabIndex = 0;
            // 
            // Frm_TeaPriceManage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 833);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_TeaPriceManage";
            Text = "饮品价格管理";
            Load += Frm_TeaPriceManage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_Operation;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox txt_TeaName;
        private Button btn_Cancel;
        private Button btn_Save;
        private DateTimePicker dtp_EndDate;
        private DateTimePicker dtp_BeginDate;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txt_Price_Large;
        private TextBox txt_Price_Medium;
        private TextBox txt_Price_Small;
        private Label lbl_Note;
        private ListView lv_TeaPrice;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView lv_TeaInfo;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private PictureBox pictureBox1;
        private Button btn_Delete;
    }
}