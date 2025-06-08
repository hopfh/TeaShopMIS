namespace TeaShopMIS
{
    partial class Frm_Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            menuStrip1 = new MenuStrip();
            系统管理ToolStripMenuItem = new ToolStripMenuItem();
            menu_TeaInfoManage = new ToolStripMenuItem();
            menu_TeaPriceManage = new ToolStripMenuItem();
            menu_MemberInfoManage = new ToolStripMenuItem();
            menu_UserInfoManage = new ToolStripMenuItem();
            menu_ChangePassword = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            menu_Exit = new ToolStripMenuItem();
            点餐服务ToolStripMenuItem = new ToolStripMenuItem();
            menu_Order = new ToolStripMenuItem();
            menu_PlayMusic = new ToolStripMenuItem();
            查询中心ToolStripMenuItem = new ToolStripMenuItem();
            menu_TeaInfoQuery = new ToolStripMenuItem();
            menu_MemberInfoQuery = new ToolStripMenuItem();
            menu_OrderInfoQuery = new ToolStripMenuItem();
            menu_BusinessChart = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btn_TeaInfoManage = new ToolStripButton();
            btn_MemberInfoManage = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_selfOrder = new ToolStripButton();
            btn_Order = new ToolStripButton();
            btn_PlayMusic = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lbl_Name = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            lbl_Time = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 系统管理ToolStripMenuItem, 点餐服务ToolStripMenuItem, 查询中心ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1159, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            系统管理ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menu_TeaInfoManage, menu_TeaPriceManage, menu_MemberInfoManage, menu_UserInfoManage, menu_ChangePassword, toolStripMenuItem1, menu_Exit });
            系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            系统管理ToolStripMenuItem.ShortcutKeyDisplayString = "";
            系统管理ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            系统管理ToolStripMenuItem.Size = new Size(120, 28);
            系统管理ToolStripMenuItem.Text = "系统管理(&S)";
            // 
            // menu_TeaInfoManage
            // 
            menu_TeaInfoManage.Name = "menu_TeaInfoManage";
            menu_TeaInfoManage.Size = new Size(270, 34);
            menu_TeaInfoManage.Text = "饮品信息管理";
            menu_TeaInfoManage.Click += menu_TeaInfoManage_Click;
            // 
            // menu_TeaPriceManage
            // 
            menu_TeaPriceManage.Name = "menu_TeaPriceManage";
            menu_TeaPriceManage.Size = new Size(270, 34);
            menu_TeaPriceManage.Text = "饮品价格管理";
            menu_TeaPriceManage.Click += menu_TeaPriceManage_Click;
            // 
            // menu_MemberInfoManage
            // 
            menu_MemberInfoManage.Name = "menu_MemberInfoManage";
            menu_MemberInfoManage.Size = new Size(270, 34);
            menu_MemberInfoManage.Text = "会员信息管理";
            menu_MemberInfoManage.Click += menu_MemberInfoManage_Click;
            // 
            // menu_UserInfoManage
            // 
            menu_UserInfoManage.Name = "menu_UserInfoManage";
            menu_UserInfoManage.Size = new Size(270, 34);
            menu_UserInfoManage.Text = "员工信息管理";
            menu_UserInfoManage.Click += menu_UserInfoManage_Click;
            // 
            // menu_ChangePassword
            // 
            menu_ChangePassword.Name = "menu_ChangePassword";
            menu_ChangePassword.Size = new Size(270, 34);
            menu_ChangePassword.Text = "修改密码";
            menu_ChangePassword.Click += menu_ChangePassword_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(267, 6);
            // 
            // menu_Exit
            // 
            menu_Exit.Name = "menu_Exit";
            menu_Exit.Size = new Size(270, 34);
            menu_Exit.Text = "退出系统";
            menu_Exit.Click += menu_Exit_Click;
            // 
            // 点餐服务ToolStripMenuItem
            // 
            点餐服务ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menu_Order, menu_PlayMusic });
            点餐服务ToolStripMenuItem.Name = "点餐服务ToolStripMenuItem";
            点餐服务ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            点餐服务ToolStripMenuItem.Size = new Size(120, 28);
            点餐服务ToolStripMenuItem.Text = "点餐服务(&F)";
            // 
            // menu_Order
            // 
            menu_Order.Name = "menu_Order";
            menu_Order.Size = new Size(182, 34);
            menu_Order.Text = "点餐收银";
            menu_Order.Click += menu_Order_Click;
            // 
            // menu_PlayMusic
            // 
            menu_PlayMusic.Name = "menu_PlayMusic";
            menu_PlayMusic.Size = new Size(182, 34);
            menu_PlayMusic.Text = "播放音乐";
            menu_PlayMusic.Click += menu_PlayMusic_Click;
            // 
            // 查询中心ToolStripMenuItem
            // 
            查询中心ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menu_TeaInfoQuery, menu_MemberInfoQuery, menu_OrderInfoQuery, menu_BusinessChart });
            查询中心ToolStripMenuItem.Name = "查询中心ToolStripMenuItem";
            查询中心ToolStripMenuItem.Size = new Size(98, 28);
            查询中心ToolStripMenuItem.Text = "查询中心";
            // 
            // menu_TeaInfoQuery
            // 
            menu_TeaInfoQuery.Name = "menu_TeaInfoQuery";
            menu_TeaInfoQuery.Size = new Size(218, 34);
            menu_TeaInfoQuery.Text = "饮品信息查询";
            menu_TeaInfoQuery.Click += menu_TeaInfoQuery_Click;
            // 
            // menu_MemberInfoQuery
            // 
            menu_MemberInfoQuery.Name = "menu_MemberInfoQuery";
            menu_MemberInfoQuery.Size = new Size(218, 34);
            menu_MemberInfoQuery.Text = "会员信息查询";
            menu_MemberInfoQuery.Click += menu_MemberInfoQuery_Click;
            // 
            // menu_OrderInfoQuery
            // 
            menu_OrderInfoQuery.Name = "menu_OrderInfoQuery";
            menu_OrderInfoQuery.Size = new Size(218, 34);
            menu_OrderInfoQuery.Text = "营业信息查询";
            menu_OrderInfoQuery.Click += menu_OrderInfoQuery_Click;
            // 
            // menu_BusinessChart
            // 
            menu_BusinessChart.Name = "menu_BusinessChart";
            menu_BusinessChart.Size = new Size(218, 34);
            menu_BusinessChart.Text = "业绩统计分析";
            menu_BusinessChart.Click += menu_BusinessChart_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(50, 50);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_TeaInfoManage, btn_MemberInfoManage, toolStripSeparator1, btn_selfOrder, btn_Order, btn_PlayMusic });
            toolStrip1.Location = new Point(0, 32);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1159, 110);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_TeaInfoManage
            // 
            btn_TeaInfoManage.AutoSize = false;
            btn_TeaInfoManage.Image = (Image)resources.GetObject("btn_TeaInfoManage.Image");
            btn_TeaInfoManage.ImageTransparentColor = Color.Magenta;
            btn_TeaInfoManage.Name = "btn_TeaInfoManage";
            btn_TeaInfoManage.Size = new Size(122, 115);
            btn_TeaInfoManage.Text = "饮品信息管理";
            btn_TeaInfoManage.TextAlign = ContentAlignment.BottomCenter;
            btn_TeaInfoManage.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_TeaInfoManage.Click += btn_TeaInfoManage_Click;
            // 
            // btn_MemberInfoManage
            // 
            btn_MemberInfoManage.Image = (Image)resources.GetObject("btn_MemberInfoManage.Image");
            btn_MemberInfoManage.ImageTransparentColor = Color.Magenta;
            btn_MemberInfoManage.Name = "btn_MemberInfoManage";
            btn_MemberInfoManage.Size = new Size(122, 105);
            btn_MemberInfoManage.Text = "会员信息管理";
            btn_MemberInfoManage.TextAlign = ContentAlignment.BottomCenter;
            btn_MemberInfoManage.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_MemberInfoManage.Click += btn_MemberInfoManage_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 110);
            // 
            // btn_selfOrder
            // 
            btn_selfOrder.Image = (Image)resources.GetObject("btn_selfOrder.Image");
            btn_selfOrder.ImageTransparentColor = Color.Magenta;
            btn_selfOrder.Name = "btn_selfOrder";
            btn_selfOrder.Size = new Size(86, 105);
            btn_selfOrder.Text = "自助点餐";
            btn_selfOrder.TextAlign = ContentAlignment.BottomCenter;
            btn_selfOrder.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_selfOrder.Click += btn_selfOrder_Click;
            // 
            // btn_Order
            // 
            btn_Order.Image = (Image)resources.GetObject("btn_Order.Image");
            btn_Order.ImageTransparentColor = Color.Magenta;
            btn_Order.Name = "btn_Order";
            btn_Order.Size = new Size(86, 105);
            btn_Order.Text = "点餐收银";
            btn_Order.TextAlign = ContentAlignment.BottomCenter;
            btn_Order.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Order.Click += btn_Order_Click;
            // 
            // btn_PlayMusic
            // 
            btn_PlayMusic.Image = (Image)resources.GetObject("btn_PlayMusic.Image");
            btn_PlayMusic.ImageTransparentColor = Color.Magenta;
            btn_PlayMusic.Name = "btn_PlayMusic";
            btn_PlayMusic.Size = new Size(86, 105);
            btn_PlayMusic.Text = "播放音乐";
            btn_PlayMusic.TextAlign = ContentAlignment.BottomCenter;
            btn_PlayMusic.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_PlayMusic.Click += btn_PlayMusic_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lbl_Name, toolStripStatusLabel3, toolStripStatusLabel4, lbl_Time });
            statusStrip1.Location = new Point(0, 910);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1159, 31);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 24);
            toolStripStatusLabel1.Text = "当前操作员：";
            // 
            // lbl_Name
            // 
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(170, 24);
            lbl_Name.Text = "                                ";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(430, 24);
            toolStripStatusLabel3.Text = "                                                                                    ";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(100, 24);
            toolStripStatusLabel4.Text = "当前时间：";
            // 
            // lbl_Time
            // 
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(125, 24);
            lbl_Time.Text = "                       ";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1159, 771);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 941);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Frm_Main";
            Text = "饮品店点餐收银系统";
            FormClosing += Frm_Main_FormClosing;
            Load += Frm_Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 系统管理ToolStripMenuItem;
        private ToolStripMenuItem menu_TeaInfoManage;
        private ToolStripMenuItem menu_TeaPriceManage;
        private ToolStripMenuItem menu_MemberInfoManage;
        private ToolStripMenuItem menu_UserInfoManage;
        private ToolStripMenuItem menu_ChangePassword;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menu_Exit;
        private ToolStripMenuItem 点餐服务ToolStripMenuItem;
        private ToolStripMenuItem menu_Order;
        private ToolStripMenuItem menu_PlayMusic;
        private ToolStripMenuItem 查询中心ToolStripMenuItem;
        private ToolStripMenuItem menu_TeaInfoQuery;
        private ToolStripMenuItem menu_MemberInfoQuery;
        private ToolStripMenuItem menu_OrderInfoQuery;
        private ToolStripMenuItem menu_BusinessChart;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripButton btn_TeaInfoManage;
        private ToolStripButton btn_MemberInfoManage;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_selfOrder;
        private ToolStripButton btn_Order;
        private ToolStripButton btn_PlayMusic;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lbl_Name;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel lbl_Time;
        private PictureBox pictureBox1;
    }
}