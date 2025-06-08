namespace TeaShopMIS
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btn_Login = new Button();
            btn_Exit = new Button();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            lbl_Note = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 24);
            label1.Name = "label1";
            label1.Size = new Size(695, 90);
            label1.TabIndex = 0;
            label1.Text = "饮品店点餐收银系统";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 35);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 1;
            label2.Text = "账号：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 112);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 2;
            label3.Text = "密码：";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(496, 431);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(31, 228);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(112, 34);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "登录";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(223, 228);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(112, 34);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "退出";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(97, 29);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(252, 30);
            txt_UserName.TabIndex = 6;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(97, 112);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(252, 30);
            txt_Password.TabIndex = 7;
            // 
            // lbl_Note
            // 
            lbl_Note.AutoSize = true;
            lbl_Note.Location = new Point(133, 156);
            lbl_Note.Name = "lbl_Note";
            lbl_Note.Size = new Size(0, 24);
            lbl_Note.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_UserName);
            groupBox1.Controls.Add(lbl_Note);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_Password);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btn_Login);
            groupBox1.Controls.Add(btn_Exit);
            groupBox1.Location = new Point(552, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 299);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 595);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Frm_Login";
            Text = "饮品店点餐收银系统";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btn_Login;
        private Button btn_Exit;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private Label lbl_Note;
        private GroupBox groupBox1;
    }
}
