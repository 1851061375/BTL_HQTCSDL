namespace QL_quan_Internet
{
    partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtgv_account = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_accounttype = new System.Windows.Forms.ComboBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.bt_changepass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_displayname = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtgv_revenue = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.bt_static = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dt_revenue = new System.Windows.Forms.DateTimePicker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lb_totalrevenue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_account)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_revenue)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.panel3);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(920, 611);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tài khoản";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 605);
            this.panel3.TabIndex = 9;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dtgv_account);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 77);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(582, 528);
            this.panel10.TabIndex = 8;
            // 
            // dtgv_account
            // 
            this.dtgv_account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_account.Location = new System.Drawing.Point(0, 0);
            this.dtgv_account.Name = "dtgv_account";
            this.dtgv_account.RowHeadersWidth = 62;
            this.dtgv_account.RowTemplate.Height = 28;
            this.dtgv_account.Size = new System.Drawing.Size(582, 528);
            this.dtgv_account.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_delete);
            this.panel2.Controls.Add(this.bt_update);
            this.panel2.Controls.Add(this.bt_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 77);
            this.panel2.TabIndex = 7;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(395, 17);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(86, 45);
            this.bt_delete.TabIndex = 0;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(213, 17);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(86, 45);
            this.bt_update.TabIndex = 0;
            this.bt_update.Text = "Sửa";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(45, 17);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(86, 45);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_accounttype);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.bt_changepass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_displayname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(582, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 605);
            this.panel1.TabIndex = 6;
            // 
            // cb_accounttype
            // 
            this.cb_accounttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_accounttype.FormattingEnabled = true;
            this.cb_accounttype.Items.AddRange(new object[] {
            "staff",
            "admin"});
            this.cb_accounttype.Location = new System.Drawing.Point(143, 278);
            this.cb_accounttype.Name = "cb_accounttype";
            this.cb_accounttype.Size = new System.Drawing.Size(164, 28);
            this.cb_accounttype.TabIndex = 6;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(143, 128);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(164, 26);
            this.tb_username.TabIndex = 0;
            // 
            // bt_changepass
            // 
            this.bt_changepass.Location = new System.Drawing.Point(184, 387);
            this.bt_changepass.Name = "bt_changepass";
            this.bt_changepass.Size = new System.Drawing.Size(123, 46);
            this.bt_changepass.TabIndex = 5;
            this.bt_changepass.Text = "Đổi mật khẩu";
            this.bt_changepass.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hiển thị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // tb_displayname
            // 
            this.tb_displayname.Location = new System.Drawing.Point(143, 202);
            this.tb_displayname.Name = "tb_displayname";
            this.tb_displayname.Size = new System.Drawing.Size(164, 26);
            this.tb_displayname.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(914, 605);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtgv_revenue);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 135);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(914, 470);
            this.panel6.TabIndex = 1;
            // 
            // dtgv_revenue
            // 
            this.dtgv_revenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_revenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_revenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_revenue.Location = new System.Drawing.Point(0, 0);
            this.dtgv_revenue.Name = "dtgv_revenue";
            this.dtgv_revenue.RowHeadersWidth = 62;
            this.dtgv_revenue.RowTemplate.Height = 28;
            this.dtgv_revenue.Size = new System.Drawing.Size(914, 470);
            this.dtgv_revenue.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(914, 135);
            this.panel5.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.bt_static);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(552, 51);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(362, 84);
            this.panel9.TabIndex = 4;
            // 
            // bt_static
            // 
            this.bt_static.Location = new System.Drawing.Point(87, 26);
            this.bt_static.Name = "bt_static";
            this.bt_static.Size = new System.Drawing.Size(104, 42);
            this.bt_static.TabIndex = 1;
            this.bt_static.Text = "Thống kê";
            this.bt_static.UseVisualStyleBackColor = true;
            this.bt_static.Click += new System.EventHandler(this.bt_static_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dt_revenue);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 51);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(552, 84);
            this.panel8.TabIndex = 3;
            // 
            // dt_revenue
            // 
            this.dt_revenue.CustomFormat = "dd/MM/yyyy";
            this.dt_revenue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_revenue.Location = new System.Drawing.Point(296, 32);
            this.dt_revenue.Name = "dt_revenue";
            this.dt_revenue.Size = new System.Drawing.Size(211, 26);
            this.dt_revenue.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lb_totalrevenue);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(914, 51);
            this.panel7.TabIndex = 2;
            // 
            // lb_totalrevenue
            // 
            this.lb_totalrevenue.AutoSize = true;
            this.lb_totalrevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalrevenue.Location = new System.Drawing.Point(208, 11);
            this.lb_totalrevenue.Name = "lb_totalrevenue";
            this.lb_totalrevenue.Size = new System.Drawing.Size(46, 29);
            this.lb_totalrevenue.TabIndex = 1;
            this.lb_totalrevenue.Text = "0 ₫";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng doanh thu: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 644);
            this.tabControl1.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAdmin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tabPage5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_account)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_revenue)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_changepass;
        private System.Windows.Forms.TextBox tb_displayname;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dtgv_revenue;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bt_static;
        private System.Windows.Forms.DateTimePicker dt_revenue;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_totalrevenue;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dtgv_account;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.ComboBox cb_accounttype;
    }
}