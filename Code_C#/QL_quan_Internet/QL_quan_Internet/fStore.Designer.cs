namespace QL_quan_Internet
{
    partial class fStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStorage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_remove = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.num_quantity = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lv_store = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_remove);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Controls.Add(this.num_quantity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(603, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 644);
            this.panel1.TabIndex = 0;
            // 
            // bt_remove
            // 
            this.bt_remove.Location = new System.Drawing.Point(198, 360);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(80, 46);
            this.bt_remove.TabIndex = 1;
            this.bt_remove.Text = "Giảm";
            this.bt_remove.UseVisualStyleBackColor = true;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(86, 360);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(80, 46);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // num_quantity
            // 
            this.num_quantity.Location = new System.Drawing.Point(86, 205);
            this.num_quantity.Name = "num_quantity";
            this.num_quantity.Size = new System.Drawing.Size(192, 26);
            this.num_quantity.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lv_store);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 644);
            this.panel2.TabIndex = 1;
            // 
            // lv_store
            // 
            this.lv_store.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_store.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_store.FullRowSelect = true;
            this.lv_store.GridLines = true;
            this.lv_store.HideSelection = false;
            this.lv_store.Location = new System.Drawing.Point(0, 0);
            this.lv_store.Name = "lv_store";
            this.lv_store.Scrollable = false;
            this.lv_store.Size = new System.Drawing.Size(603, 644);
            this.lv_store.TabIndex = 0;
            this.lv_store.UseCompatibleStateImageBehavior = false;
            this.lv_store.View = System.Windows.Forms.View.Details;
            this.lv_store.SelectedIndexChanged += new System.EventHandler(this.lv_store_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ĐVT";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tồn kho";
            this.columnHeader4.Width = 299;
            // 
            // fStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho hàng";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.NumericUpDown num_quantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lv_store;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}