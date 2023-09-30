
namespace QUANLYSINHVIEN1
{
    partial class Timkiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbkhoaa = new System.Windows.Forms.ComboBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtmsv = new System.Windows.Forms.TextBox();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblmssv = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnxoaa = new System.Windows.Forms.Button();
            this.btntrove = new System.Windows.Forms.Button();
            this.dgvtimkiem = new System.Windows.Forms.DataGridView();
            this.dgvmssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.lblkqtimkiem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbkhoaa);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.txtmsv);
            this.groupBox1.Controls.Add(this.lblkhoa);
            this.groupBox1.Controls.Add(this.lblhoten);
            this.groupBox1.Controls.Add(this.lblmssv);
            this.groupBox1.Location = new System.Drawing.Point(265, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(332, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tim kiếm";
            // 
            // cmbkhoaa
            // 
            this.cmbkhoaa.FormattingEnabled = true;
            this.cmbkhoaa.Location = new System.Drawing.Point(121, 139);
            this.cmbkhoaa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbkhoaa.Name = "cmbkhoaa";
            this.cmbkhoaa.Size = new System.Drawing.Size(171, 24);
            this.cmbkhoaa.TabIndex = 5;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(121, 87);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(171, 22);
            this.txtten.TabIndex = 4;
            // 
            // txtmsv
            // 
            this.txtmsv.Location = new System.Drawing.Point(121, 39);
            this.txtmsv.Margin = new System.Windows.Forms.Padding(4);
            this.txtmsv.Name = "txtmsv";
            this.txtmsv.Size = new System.Drawing.Size(171, 22);
            this.txtmsv.TabIndex = 3;
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Location = new System.Drawing.Point(28, 150);
            this.lblkhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(38, 16);
            this.lblkhoa.TabIndex = 2;
            this.lblkhoa.Text = "Khoa";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(28, 96);
            this.lblhoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(46, 16);
            this.lblhoten.TabIndex = 1;
            this.lblhoten.Text = "Họ tên";
            // 
            // lblmssv
            // 
            this.lblmssv.AutoSize = true;
            this.lblmssv.Location = new System.Drawing.Point(28, 49);
            this.lblmssv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmssv.Name = "lblmssv";
            this.lblmssv.Size = new System.Drawing.Size(65, 16);
            this.lblmssv.TabIndex = 0;
            this.lblmssv.Text = "Mã số SV";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(297, 239);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(100, 28);
            this.btntimkiem.TabIndex = 1;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnxoaa
            // 
            this.btnxoaa.Location = new System.Drawing.Point(459, 239);
            this.btnxoaa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoaa.Name = "btnxoaa";
            this.btnxoaa.Size = new System.Drawing.Size(100, 28);
            this.btnxoaa.TabIndex = 2;
            this.btnxoaa.Text = "Xoá";
            this.btnxoaa.UseVisualStyleBackColor = true;
            this.btnxoaa.Click += new System.EventHandler(this.btnxoaa_Click);
            // 
            // btntrove
            // 
            this.btntrove.Location = new System.Drawing.Point(736, 239);
            this.btntrove.Margin = new System.Windows.Forms.Padding(4);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(100, 28);
            this.btntrove.TabIndex = 3;
            this.btntrove.Text = "Trở về";
            this.btntrove.UseVisualStyleBackColor = true;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // dgvtimkiem
            // 
            this.dgvtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimkiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmssv,
            this.dgvhoten,
            this.dgvkhoa,
            this.dgvdtb});
            this.dgvtimkiem.Location = new System.Drawing.Point(25, 274);
            this.dgvtimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvtimkiem.Name = "dgvtimkiem";
            this.dgvtimkiem.RowHeadersWidth = 51;
            this.dgvtimkiem.Size = new System.Drawing.Size(1006, 233);
            this.dgvtimkiem.TabIndex = 4;
            // 
            // dgvmssv
            // 
            this.dgvmssv.HeaderText = "MSSV";
            this.dgvmssv.MinimumWidth = 6;
            this.dgvmssv.Name = "dgvmssv";
            this.dgvmssv.Width = 200;
            // 
            // dgvhoten
            // 
            this.dgvhoten.HeaderText = "Họ tên";
            this.dgvhoten.MinimumWidth = 6;
            this.dgvhoten.Name = "dgvhoten";
            this.dgvhoten.Width = 200;
            // 
            // dgvkhoa
            // 
            this.dgvkhoa.HeaderText = "Khoa";
            this.dgvkhoa.MinimumWidth = 6;
            this.dgvkhoa.Name = "dgvkhoa";
            this.dgvkhoa.Width = 200;
            // 
            // dgvdtb
            // 
            this.dgvdtb.HeaderText = "Điểm TB";
            this.dgvdtb.MinimumWidth = 6;
            this.dgvdtb.Name = "dgvdtb";
            this.dgvdtb.Width = 180;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(725, 514);
            this.txtkq.Margin = new System.Windows.Forms.Padding(4);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(132, 22);
            this.txtkq.TabIndex = 5;
            this.txtkq.Text = "0";
            this.txtkq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblkqtimkiem
            // 
            this.lblkqtimkiem.AutoSize = true;
            this.lblkqtimkiem.Location = new System.Drawing.Point(604, 518);
            this.lblkqtimkiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkqtimkiem.Name = "lblkqtimkiem";
            this.lblkqtimkiem.Size = new System.Drawing.Size(104, 16);
            this.lblkqtimkiem.TabIndex = 6;
            this.lblkqtimkiem.Text = "Kết quả tìm kiếm";
            // 
            // Timkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblkqtimkiem);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.dgvtimkiem);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btnxoaa);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Timkiem";
            this.Text = "Tìm kiếm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblmssv;
        private System.Windows.Forms.ComboBox cmbkhoaa;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtmsv;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnxoaa;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.DataGridView dgvtimkiem;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Label lblkqtimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvhoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdtb;
    }
}