
namespace QUANLYSINHVIEN1
{
    partial class Quanlysinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quanlysinhvien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cmbkhoa = new System.Windows.Forms.ComboBox();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.lbldtb = new System.Windows.Forms.Label();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblmssv = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.dgvmssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnquanlykhoa = new System.Windows.Forms.ToolStripButton();
            this.btntimkiem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.cmbkhoa);
            this.groupBox1.Controls.Add(this.txtdtb);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtmssv);
            this.groupBox1.Controls.Add(this.lbldtb);
            this.groupBox1.Controls.Add(this.lblkhoa);
            this.groupBox1.Controls.Add(this.lblhoten);
            this.groupBox1.Controls.Add(this.lblmssv);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Location = new System.Drawing.Point(16, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(281, 443);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(20, 407);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(209, 28);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(128, 325);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 53);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(20, 325);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 53);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Ngôn ngữ anh",
            "Quản trị kinh doanh",
            "Kế toán",
            "Công nghệ ô tô"});
            this.cmbkhoa.Location = new System.Drawing.Point(91, 196);
            this.cmbkhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(163, 24);
            this.cmbkhoa.TabIndex = 8;
            this.cmbkhoa.SelectedIndexChanged += new System.EventHandler(this.cmbkhoa_SelectedIndexChanged);
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(91, 270);
            this.txtdtb.Margin = new System.Windows.Forms.Padding(4);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(163, 22);
            this.txtdtb.TabIndex = 7;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(91, 133);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(163, 22);
            this.txthoten.TabIndex = 5;
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(91, 68);
            this.txtmssv.Margin = new System.Windows.Forms.Padding(4);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(163, 22);
            this.txtmssv.TabIndex = 4;
            // 
            // lbldtb
            // 
            this.lbldtb.AutoSize = true;
            this.lbldtb.Location = new System.Drawing.Point(16, 270);
            this.lbldtb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldtb.Name = "lbldtb";
            this.lbldtb.Size = new System.Drawing.Size(59, 16);
            this.lbldtb.TabIndex = 3;
            this.lbldtb.Text = "Điểm TB";
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Location = new System.Drawing.Point(16, 207);
            this.lblkhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(38, 16);
            this.lblkhoa.TabIndex = 2;
            this.lblkhoa.Text = "Khoa";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(16, 133);
            this.lblhoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(46, 16);
            this.lblhoten.TabIndex = 1;
            this.lblhoten.Text = "Họ tên";
            // 
            // lblmssv
            // 
            this.lblmssv.AutoSize = true;
            this.lblmssv.Location = new System.Drawing.Point(16, 71);
            this.lblmssv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmssv.Name = "lblmssv";
            this.lblmssv.Size = new System.Drawing.Size(45, 16);
            this.lblmssv.TabIndex = 0;
            this.lblmssv.Text = "MSSV";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tìmKiếmToolStripMenuItem,
            this.btnthoat});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(202, 26);
            this.toolStripMenuItem1.Text = "Quản lý khoa";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmToolStripMenuItem.Image")));
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(202, 26);
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmssv,
            this.dgvhoten,
            this.dgvkhoa,
            this.dgvdtb});
            this.dgvdata.Location = new System.Drawing.Point(305, 96);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.Size = new System.Drawing.Size(551, 443);
            this.dgvdata.TabIndex = 3;
            // 
            // dgvmssv
            // 
            this.dgvmssv.HeaderText = "MSSV";
            this.dgvmssv.MinimumWidth = 6;
            this.dgvmssv.Name = "dgvmssv";
            this.dgvmssv.Width = 125;
            // 
            // dgvhoten
            // 
            this.dgvhoten.HeaderText = "Họ tên";
            this.dgvhoten.MinimumWidth = 6;
            this.dgvhoten.Name = "dgvhoten";
            this.dgvhoten.Width = 125;
            // 
            // dgvkhoa
            // 
            this.dgvkhoa.HeaderText = "Khoa";
            this.dgvkhoa.MinimumWidth = 6;
            this.dgvkhoa.Name = "dgvkhoa";
            this.dgvkhoa.Width = 125;
            // 
            // dgvdtb
            // 
            this.dgvdtb.HeaderText = "Điểm TB";
            this.dgvdtb.MinimumWidth = 6;
            this.dgvdtb.Name = "dgvdtb";
            this.dgvdtb.Width = 125;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnquanlykhoa,
            this.btntimkiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(937, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnquanlykhoa
            // 
            this.btnquanlykhoa.Image = ((System.Drawing.Image)(resources.GetObject("btnquanlykhoa.Image")));
            this.btnquanlykhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnquanlykhoa.Name = "btnquanlykhoa";
            this.btnquanlykhoa.Size = new System.Drawing.Size(119, 24);
            this.btnquanlykhoa.Text = "Quản lý khoa";
            this.btnquanlykhoa.Click += new System.EventHandler(this.btnquanlykhoa_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(94, 24);
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // Quanlysinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 554);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Quanlysinhvien";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Quanlysinhvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldtb;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblmssv;
        private System.Windows.Forms.ComboBox cmbkhoa;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvhoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdtb;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnquanlykhoa;
        private System.Windows.Forms.ToolStripButton btntimkiem;
    }
}

