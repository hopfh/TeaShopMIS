namespace TeaShopMIS
{
    partial class Frm_TeaInfoManage
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
            lbl_Operation = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ccb_Status = new ComboBox();
            txt_Price_Large = new TextBox();
            txt_Price_Medium = new TextBox();
            txt_Price_Small = new TextBox();
            txt_TeaName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            btn_SelectImage = new Button();
            groupBox2 = new GroupBox();
            lv_TeaInfo = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btn_Delete = new Button();
            btn_Discontinued = new Button();
            btn_Soldout = new Button();
            btn_OnSale = new Button();
            lbl_Note = new Label();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Cancel);
            groupBox1.Controls.Add(btn_Save);
            groupBox1.Controls.Add(lbl_Operation);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ccb_Status);
            groupBox1.Controls.Add(txt_Price_Large);
            groupBox1.Controls.Add(txt_Price_Medium);
            groupBox1.Controls.Add(txt_Price_Small);
            groupBox1.Controls.Add(txt_TeaName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(819, 400);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "编辑饮品信息   当前操作：";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(302, 354);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(112, 34);
            btn_Cancel.TabIndex = 14;
            btn_Cancel.Text = "重置";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(95, 354);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(112, 34);
            btn_Save.TabIndex = 13;
            btn_Save.Text = "保存";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // lbl_Operation
            // 
            lbl_Operation.AutoSize = true;
            lbl_Operation.Location = new Point(240, 0);
            lbl_Operation.Name = "lbl_Operation";
            lbl_Operation.Size = new Size(46, 24);
            lbl_Operation.TabIndex = 12;
            lbl_Operation.Text = "添加";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 247);
            label6.Name = "label6";
            label6.Size = new Size(58, 24);
            label6.TabIndex = 11;
            label6.Text = "(大份)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 183);
            label5.Name = "label5";
            label5.Size = new Size(58, 24);
            label5.TabIndex = 10;
            label5.Text = "(中份)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 116);
            label4.Name = "label4";
            label4.Size = new Size(102, 24);
            label4.TabIndex = 9;
            label4.Text = "(正常/小份)";
            // 
            // ccb_Status
            // 
            ccb_Status.FormattingEnabled = true;
            ccb_Status.Items.AddRange(new object[] { "在售", "售完", "停售" });
            ccb_Status.Location = new Point(144, 303);
            ccb_Status.Name = "ccb_Status";
            ccb_Status.Size = new Size(294, 32);
            ccb_Status.TabIndex = 8;
            // 
            // txt_Price_Large
            // 
            txt_Price_Large.Location = new Point(145, 241);
            txt_Price_Large.Name = "txt_Price_Large";
            txt_Price_Large.Size = new Size(158, 30);
            txt_Price_Large.TabIndex = 7;
            txt_Price_Large.KeyPress += txt_Price_Large_KeyPress;
            // 
            // txt_Price_Medium
            // 
            txt_Price_Medium.Location = new Point(145, 177);
            txt_Price_Medium.Name = "txt_Price_Medium";
            txt_Price_Medium.Size = new Size(158, 30);
            txt_Price_Medium.TabIndex = 6;
            txt_Price_Medium.KeyPress += txt_Price_Medium_KeyPress;
            // 
            // txt_Price_Small
            // 
            txt_Price_Small.Location = new Point(145, 113);
            txt_Price_Small.Name = "txt_Price_Small";
            txt_Price_Small.Size = new Size(158, 30);
            txt_Price_Small.TabIndex = 5;
            txt_Price_Small.KeyPress += txt_Price_Small_KeyPress;
            // 
            // txt_TeaName
            // 
            txt_TeaName.Location = new Point(145, 53);
            txt_TeaName.Name = "txt_TeaName";
            txt_TeaName.Size = new Size(293, 30);
            txt_TeaName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 303);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 3;
            label3.Text = "状态：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 116);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 2;
            label2.Text = "饮品价格：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 52);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 1;
            label1.Text = "饮品名称：";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(btn_SelectImage);
            groupBox3.Location = new Point(474, 41);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(339, 356);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "饮品图片";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 264);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_SelectImage
            // 
            btn_SelectImage.Location = new Point(32, 43);
            btn_SelectImage.Name = "btn_SelectImage";
            btn_SelectImage.Size = new Size(112, 34);
            btn_SelectImage.TabIndex = 0;
            btn_SelectImage.Text = "选择图片";
            btn_SelectImage.UseVisualStyleBackColor = true;
            btn_SelectImage.Click += btn_SelectImage_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lv_TeaInfo);
            groupBox2.Controls.Add(btn_Delete);
            groupBox2.Controls.Add(btn_Discontinued);
            groupBox2.Controls.Add(btn_Soldout);
            groupBox2.Controls.Add(btn_OnSale);
            groupBox2.Location = new Point(18, 475);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(813, 465);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "饮品信息列表";
            // 
            // lv_TeaInfo
            // 
            lv_TeaInfo.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lv_TeaInfo.FullRowSelect = true;
            lv_TeaInfo.GridLines = true;
            lv_TeaInfo.Location = new Point(6, 40);
            lv_TeaInfo.MultiSelect = false;
            lv_TeaInfo.Name = "lv_TeaInfo";
            lv_TeaInfo.Size = new Size(801, 425);
            lv_TeaInfo.TabIndex = 4;
            lv_TeaInfo.UseCompatibleStateImageBehavior = false;
            lv_TeaInfo.View = View.Details;
            lv_TeaInfo.SelectedIndexChanged += lv_TeaInfo_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "饮品名称";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "价格(小)";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "价格(中)";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "价格(大)";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "状态";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "图片地址";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 300;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(571, 0);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(112, 34);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "删除";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Discontinued
            // 
            btn_Discontinued.Location = new Point(436, 0);
            btn_Discontinued.Name = "btn_Discontinued";
            btn_Discontinued.Size = new Size(112, 34);
            btn_Discontinued.TabIndex = 2;
            btn_Discontinued.Text = "停售";
            btn_Discontinued.UseVisualStyleBackColor = true;
            btn_Discontinued.Click += btn_Discontinued_Click;
            // 
            // btn_Soldout
            // 
            btn_Soldout.Location = new Point(301, 0);
            btn_Soldout.Name = "btn_Soldout";
            btn_Soldout.Size = new Size(112, 34);
            btn_Soldout.TabIndex = 1;
            btn_Soldout.Text = "售完";
            btn_Soldout.UseVisualStyleBackColor = true;
            btn_Soldout.Click += btn_Soldout_Click;
            // 
            // btn_OnSale
            // 
            btn_OnSale.Location = new Point(166, 0);
            btn_OnSale.Name = "btn_OnSale";
            btn_OnSale.Size = new Size(112, 34);
            btn_OnSale.TabIndex = 0;
            btn_OnSale.Text = "在售";
            btn_OnSale.UseVisualStyleBackColor = true;
            btn_OnSale.Click += btn_OnSale_Click;
            // 
            // lbl_Note
            // 
            lbl_Note.AutoSize = true;
            lbl_Note.Location = new Point(18, 439);
            lbl_Note.Name = "lbl_Note";
            lbl_Note.Size = new Size(0, 24);
            lbl_Note.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_TeaInfoManage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 965);
            Controls.Add(lbl_Note);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_TeaInfoManage";
            Text = "饮品信息管理";
            Load += Frm_TeaInfoManage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox ccb_Status;
        private TextBox txt_Price_Large;
        private TextBox txt_Price_Medium;
        private TextBox txt_Price_Small;
        private TextBox txt_TeaName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Cancel;
        private Button btn_Save;
        private Label lbl_Operation;
        private PictureBox pictureBox1;
        private Button btn_SelectImage;
        private Label lbl_Note;
        private ListView lv_TeaInfo;
        private Button btn_Delete;
        private Button btn_Discontinued;
        private Button btn_Soldout;
        private Button btn_OnSale;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private OpenFileDialog openFileDialog1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}