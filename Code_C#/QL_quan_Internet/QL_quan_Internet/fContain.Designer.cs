namespace QL_quan_Internet
{
    partial class fContain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tất cả");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fContain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.item_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.item_store = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p_inforComputer = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lv_billinfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_totalprice = new System.Windows.Forms.TextBox();
            this.tb_foodprice = new System.Windows.Forms.TextBox();
            this.tb_timeprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_finalminute = new System.Windows.Forms.Label();
            this.lb_finalhour = new System.Windows.Forms.Label();
            this.lb_startminute = new System.Windows.Forms.Label();
            this.lb_starthour = new System.Windows.Forms.Label();
            this.lb_computername = new System.Windows.Forms.Label();
            this.lb_totaltime = new System.Windows.Forms.Label();
            this.bt_final = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtt_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lv_menu = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tv_menu = new System.Windows.Forms.TreeView();
            this.fl_computer = new System.Windows.Forms.FlowLayoutPanel();
            this.p_main = new System.Windows.Forms.Panel();
            this.gb_computerList = new System.Windows.Forms.GroupBox();
            this.p_btn = new System.Windows.Forms.Panel();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_decrease = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.n_quantity = new System.Windows.Forms.NumericUpDown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.p_inforComputer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.p_main.SuspendLayout();
            this.gb_computerList.SuspendLayout();
            this.p_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_admin,
            this.item_store,
            this.trợGiúpToolStripMenuItem,
            this.item_logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // item_admin
            // 
            this.item_admin.Name = "item_admin";
            this.item_admin.Size = new System.Drawing.Size(81, 29);
            this.item_admin.Text = "Admin";
            this.item_admin.Click += new System.EventHandler(this.item_admin_Click);
            // 
            // item_store
            // 
            this.item_store.Name = "item_store";
            this.item_store.Size = new System.Drawing.Size(104, 29);
            this.item_store.Text = "Kho hàng";
            this.item_store.Click += new System.EventHandler(this.item_khohang_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // item_logout
            // 
            this.item_logout.Name = "item_logout";
            this.item_logout.Size = new System.Drawing.Size(109, 29);
            this.item_logout.Text = "Đăng xuất";
            this.item_logout.Click += new System.EventHandler(this.item_dangxuat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // p_inforComputer
            // 
            this.p_inforComputer.Controls.Add(this.groupBox2);
            this.p_inforComputer.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_inforComputer.Location = new System.Drawing.Point(396, 0);
            this.p_inforComputer.Name = "p_inforComputer";
            this.p_inforComputer.Size = new System.Drawing.Size(340, 611);
            this.p_inforComputer.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 611);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lv_billinfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 172);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 302);
            this.panel4.TabIndex = 2;
            // 
            // lv_billinfo
            // 
            this.lv_billinfo.BackColor = System.Drawing.SystemColors.Window;
            this.lv_billinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.lv_billinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_billinfo.FullRowSelect = true;
            this.lv_billinfo.GridLines = true;
            this.lv_billinfo.HideSelection = false;
            this.lv_billinfo.Location = new System.Drawing.Point(0, 0);
            this.lv_billinfo.Name = "lv_billinfo";
            this.lv_billinfo.Scrollable = false;
            this.lv_billinfo.Size = new System.Drawing.Size(334, 302);
            this.lv_billinfo.TabIndex = 0;
            this.lv_billinfo.UseCompatibleStateImageBehavior = false;
            this.lv_billinfo.View = System.Windows.Forms.View.Details;
            this.lv_billinfo.SelectedIndexChanged += new System.EventHandler(this.lv_billinfo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SL";
            this.columnHeader2.Width = 45;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 185;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tb_totalprice);
            this.panel3.Controls.Add(this.tb_foodprice);
            this.panel3.Controls.Add(this.tb_timeprice);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 474);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 134);
            this.panel3.TabIndex = 1;
            // 
            // tb_totalprice
            // 
            this.tb_totalprice.Location = new System.Drawing.Point(150, 93);
            this.tb_totalprice.Name = "tb_totalprice";
            this.tb_totalprice.ReadOnly = true;
            this.tb_totalprice.Size = new System.Drawing.Size(175, 26);
            this.tb_totalprice.TabIndex = 1;
            this.tb_totalprice.Text = "0,00 ₫";
            this.tb_totalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_foodprice
            // 
            this.tb_foodprice.Location = new System.Drawing.Point(150, 59);
            this.tb_foodprice.Name = "tb_foodprice";
            this.tb_foodprice.ReadOnly = true;
            this.tb_foodprice.Size = new System.Drawing.Size(175, 26);
            this.tb_foodprice.TabIndex = 1;
            this.tb_foodprice.Text = "0,00 ₫";
            this.tb_foodprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_timeprice
            // 
            this.tb_timeprice.Location = new System.Drawing.Point(150, 22);
            this.tb_timeprice.Name = "tb_timeprice";
            this.tb_timeprice.ReadOnly = true;
            this.tb_timeprice.Size = new System.Drawing.Size(175, 26);
            this.tb_timeprice.TabIndex = 1;
            this.tb_timeprice.Text = "0,00 ₫";
            this.tb_timeprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng cộng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tiền nước";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiền giờ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 150);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.lb_finalminute);
            this.panel6.Controls.Add(this.lb_finalhour);
            this.panel6.Controls.Add(this.lb_startminute);
            this.panel6.Controls.Add(this.lb_starthour);
            this.panel6.Controls.Add(this.lb_computername);
            this.panel6.Controls.Add(this.lb_totaltime);
            this.panel6.Controls.Add(this.bt_final);
            this.panel6.Controls.Add(this.bt_start);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(334, 95);
            this.panel6.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // lb_finalminute
            // 
            this.lb_finalminute.AutoSize = true;
            this.lb_finalminute.Location = new System.Drawing.Point(201, 61);
            this.lb_finalminute.Name = "lb_finalminute";
            this.lb_finalminute.Size = new System.Drawing.Size(27, 20);
            this.lb_finalminute.TabIndex = 7;
            this.lb_finalminute.Text = "00";
            // 
            // lb_finalhour
            // 
            this.lb_finalhour.AutoSize = true;
            this.lb_finalhour.Location = new System.Drawing.Point(166, 61);
            this.lb_finalhour.Name = "lb_finalhour";
            this.lb_finalhour.Size = new System.Drawing.Size(27, 20);
            this.lb_finalhour.TabIndex = 8;
            this.lb_finalhour.Text = "00";
            // 
            // lb_startminute
            // 
            this.lb_startminute.AutoSize = true;
            this.lb_startminute.Location = new System.Drawing.Point(203, 21);
            this.lb_startminute.Name = "lb_startminute";
            this.lb_startminute.Size = new System.Drawing.Size(27, 20);
            this.lb_startminute.TabIndex = 6;
            this.lb_startminute.Text = "00";
            // 
            // lb_starthour
            // 
            this.lb_starthour.AutoSize = true;
            this.lb_starthour.Location = new System.Drawing.Point(167, 21);
            this.lb_starthour.Name = "lb_starthour";
            this.lb_starthour.Size = new System.Drawing.Size(27, 20);
            this.lb_starthour.TabIndex = 6;
            this.lb_starthour.Text = "00";
            // 
            // lb_computername
            // 
            this.lb_computername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_computername.Location = new System.Drawing.Point(12, 17);
            this.lb_computername.Name = "lb_computername";
            this.lb_computername.Size = new System.Drawing.Size(88, 34);
            this.lb_computername.TabIndex = 4;
            this.lb_computername.Text = "Máy";
            // 
            // lb_totaltime
            // 
            this.lb_totaltime.AutoSize = true;
            this.lb_totaltime.Location = new System.Drawing.Point(13, 61);
            this.lb_totaltime.Name = "lb_totaltime";
            this.lb_totaltime.Size = new System.Drawing.Size(92, 20);
            this.lb_totaltime.TabIndex = 5;
            this.lb_totaltime.Text = "0 giờ 0 phút";
            // 
            // bt_final
            // 
            this.bt_final.Location = new System.Drawing.Point(233, 54);
            this.bt_final.Name = "bt_final";
            this.bt_final.Size = new System.Drawing.Size(94, 34);
            this.bt_final.TabIndex = 1;
            this.bt_final.Text = "Kết thúc";
            this.bt_final.UseVisualStyleBackColor = true;
            this.bt_final.Click += new System.EventHandler(this.bt_final_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(233, 13);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(94, 34);
            this.bt_start.TabIndex = 1;
            this.bt_start.Text = "Bắt đầu";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.dtt_date);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(334, 55);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày";
            // 
            // dtt_date
            // 
            this.dtt_date.CustomFormat = "dd/MM/yyyy";
            this.dtt_date.Enabled = false;
            this.dtt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtt_date.Location = new System.Drawing.Point(195, 3);
            this.dtt_date.Name = "dtt_date";
            this.dtt_date.Size = new System.Drawing.Size(139, 26);
            this.dtt_date.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(810, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 611);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thực đơn";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lv_menu);
            this.panel7.Controls.Add(this.tv_menu);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 22);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(292, 586);
            this.panel7.TabIndex = 0;
            // 
            // lv_menu
            // 
            this.lv_menu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_menu.FullRowSelect = true;
            this.lv_menu.GridLines = true;
            this.lv_menu.HideSelection = false;
            this.lv_menu.Location = new System.Drawing.Point(0, 102);
            this.lv_menu.Name = "lv_menu";
            this.lv_menu.Scrollable = false;
            this.lv_menu.Size = new System.Drawing.Size(292, 484);
            this.lv_menu.TabIndex = 1;
            this.lv_menu.UseCompatibleStateImageBehavior = false;
            this.lv_menu.View = System.Windows.Forms.View.Details;
            this.lv_menu.SelectedIndexChanged += new System.EventHandler(this.lv_menu_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ĐVT";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Đơn giá";
            this.columnHeader7.Width = 168;
            // 
            // tv_menu
            // 
            this.tv_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tv_menu.Location = new System.Drawing.Point(0, 0);
            this.tv_menu.Name = "tv_menu";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Tất cả";
            this.tv_menu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tv_menu.Size = new System.Drawing.Size(292, 102);
            this.tv_menu.TabIndex = 0;
            this.tv_menu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_menu_AfterSelect);
            // 
            // fl_computer
            // 
            this.fl_computer.AutoScroll = true;
            this.fl_computer.BackColor = System.Drawing.SystemColors.Control;
            this.fl_computer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fl_computer.Location = new System.Drawing.Point(3, 22);
            this.fl_computer.Name = "fl_computer";
            this.fl_computer.Size = new System.Drawing.Size(390, 586);
            this.fl_computer.TabIndex = 2;
            // 
            // p_main
            // 
            this.p_main.Controls.Add(this.gb_computerList);
            this.p_main.Controls.Add(this.p_inforComputer);
            this.p_main.Controls.Add(this.p_btn);
            this.p_main.Controls.Add(this.groupBox1);
            this.p_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_main.Location = new System.Drawing.Point(0, 33);
            this.p_main.Name = "p_main";
            this.p_main.Size = new System.Drawing.Size(1108, 611);
            this.p_main.TabIndex = 1;
            // 
            // gb_computerList
            // 
            this.gb_computerList.Controls.Add(this.fl_computer);
            this.gb_computerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_computerList.Location = new System.Drawing.Point(0, 0);
            this.gb_computerList.Name = "gb_computerList";
            this.gb_computerList.Size = new System.Drawing.Size(396, 611);
            this.gb_computerList.TabIndex = 5;
            this.gb_computerList.TabStop = false;
            this.gb_computerList.Text = "Danh sách máy trạm";
            // 
            // p_btn
            // 
            this.p_btn.BackColor = System.Drawing.SystemColors.Control;
            this.p_btn.Controls.Add(this.bt_delete);
            this.p_btn.Controls.Add(this.bt_decrease);
            this.p_btn.Controls.Add(this.bt_add);
            this.p_btn.Controls.Add(this.n_quantity);
            this.p_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_btn.Location = new System.Drawing.Point(736, 0);
            this.p_btn.Name = "p_btn";
            this.p_btn.Size = new System.Drawing.Size(74, 611);
            this.p_btn.TabIndex = 4;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(0, 356);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(74, 44);
            this.bt_delete.TabIndex = 1;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_decrease
            // 
            this.bt_decrease.Location = new System.Drawing.Point(0, 287);
            this.bt_decrease.Name = "bt_decrease";
            this.bt_decrease.Size = new System.Drawing.Size(74, 44);
            this.bt_decrease.TabIndex = 1;
            this.bt_decrease.Text = "Giảm";
            this.bt_decrease.UseVisualStyleBackColor = true;
            this.bt_decrease.Click += new System.EventHandler(this.bt_decrease_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(0, 219);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(74, 44);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // n_quantity
            // 
            this.n_quantity.Location = new System.Drawing.Point(0, 172);
            this.n_quantity.Name = "n_quantity";
            this.n_quantity.ReadOnly = true;
            this.n_quantity.Size = new System.Drawing.Size(74, 26);
            this.n_quantity.TabIndex = 0;
            this.n_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // fContain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 644);
            this.Controls.Add(this.p_main);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fContain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán PES";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.p_inforComputer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.p_main.ResumeLayout(false);
            this.gb_computerList.ResumeLayout(false);
            this.p_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.n_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item_admin;
        private System.Windows.Forms.ToolStripMenuItem item_store;
        private System.Windows.Forms.ToolStripMenuItem item_logout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel p_inforComputer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lv_billinfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_totalprice;
        private System.Windows.Forms.TextBox tb_foodprice;
        private System.Windows.Forms.TextBox tb_timeprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_finalminute;
        private System.Windows.Forms.Label lb_finalhour;
        private System.Windows.Forms.Label lb_startminute;
        private System.Windows.Forms.Label lb_starthour;
        private System.Windows.Forms.Label lb_computername;
        private System.Windows.Forms.Label lb_totaltime;
        private System.Windows.Forms.Button bt_final;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtt_date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.FlowLayoutPanel fl_computer;
        private System.Windows.Forms.Panel p_main;
        private System.Windows.Forms.GroupBox gb_computerList;
        private System.Windows.Forms.Button bt_decrease;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.NumericUpDown n_quantity;
        private System.Windows.Forms.ListView lv_menu;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TreeView tv_menu;
        private System.Windows.Forms.Panel p_btn;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
    }
}