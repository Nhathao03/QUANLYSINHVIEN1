
namespace QUANLYSINHVIEN1
{
    partial class Quanlykhoa
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
            this.txttongsogs = new System.Windows.Forms.TextBox();
            this.txttenkhoa = new System.Windows.Forms.TextBox();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.lbltongsogs = new System.Windows.Forms.Label();
            this.lbltenkhoa = new System.Windows.Forms.Label();
            this.lblmakhoa = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dgvqlkhoa = new System.Windows.Forms.DataGridView();
            this.dgvmakhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtongsogs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndong = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlkhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttongsogs);
            this.groupBox1.Controls.Add(this.txttenkhoa);
            this.groupBox1.Controls.Add(this.txtmakhoa);
            this.groupBox1.Controls.Add(this.lbltongsogs);
            this.groupBox1.Controls.Add(this.lbltenkhoa);
            this.groupBox1.Controls.Add(this.lblmakhoa);
            this.groupBox1.Location = new System.Drawing.Point(39, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // txttongsogs
            // 
            this.txttongsogs.Location = new System.Drawing.Point(108, 171);
            this.txttongsogs.Margin = new System.Windows.Forms.Padding(4);
            this.txttongsogs.Name = "txttongsogs";
            this.txttongsogs.Size = new System.Drawing.Size(132, 22);
            this.txttongsogs.TabIndex = 5;
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Location = new System.Drawing.Point(108, 110);
            this.txttenkhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Size = new System.Drawing.Size(132, 22);
            this.txttenkhoa.TabIndex = 4;
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(108, 48);
            this.txtmakhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(132, 22);
            this.txtmakhoa.TabIndex = 3;
            // 
            // lbltongsogs
            // 
            this.lbltongsogs.AutoSize = true;
            this.lbltongsogs.Location = new System.Drawing.Point(13, 171);
            this.lbltongsogs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltongsogs.Name = "lbltongsogs";
            this.lbltongsogs.Size = new System.Drawing.Size(79, 16);
            this.lbltongsogs.TabIndex = 2;
            this.lbltongsogs.Text = "Tổng số GS";
            // 
            // lbltenkhoa
            // 
            this.lbltenkhoa.AutoSize = true;
            this.lbltenkhoa.Location = new System.Drawing.Point(13, 118);
            this.lbltenkhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltenkhoa.Name = "lbltenkhoa";
            this.lbltenkhoa.Size = new System.Drawing.Size(64, 16);
            this.lbltenkhoa.TabIndex = 1;
            this.lbltenkhoa.Text = "Tên khoa";
            // 
            // lblmakhoa
            // 
            this.lblmakhoa.AutoSize = true;
            this.lblmakhoa.Location = new System.Drawing.Point(13, 57);
            this.lblmakhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmakhoa.Name = "lblmakhoa";
            this.lblmakhoa.Size = new System.Drawing.Size(59, 16);
            this.lblmakhoa.TabIndex = 0;
            this.lblmakhoa.Text = "Mã khoa";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(55, 364);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 44);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(55, 416);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(233, 45);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dgvqlkhoa
            // 
            this.dgvqlkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqlkhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmakhoa,
            this.dgvtenkhoa,
            this.dgvtongsogs});
            this.dgvqlkhoa.Location = new System.Drawing.Point(335, 107);
            this.dgvqlkhoa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvqlkhoa.Name = "dgvqlkhoa";
            this.dgvqlkhoa.RowHeadersWidth = 51;
            this.dgvqlkhoa.Size = new System.Drawing.Size(666, 354);
            this.dgvqlkhoa.TabIndex = 3;
            // 
            // dgvmakhoa
            // 
            this.dgvmakhoa.HeaderText = "Mã Khoa";
            this.dgvmakhoa.MinimumWidth = 6;
            this.dgvmakhoa.Name = "dgvmakhoa";
            this.dgvmakhoa.Width = 150;
            // 
            // dgvtenkhoa
            // 
            this.dgvtenkhoa.HeaderText = "Tên Khoa";
            this.dgvtenkhoa.MinimumWidth = 6;
            this.dgvtenkhoa.Name = "dgvtenkhoa";
            this.dgvtenkhoa.Width = 205;
            // 
            // dgvtongsogs
            // 
            this.dgvtongsogs.HeaderText = "Tống số GS";
            this.dgvtongsogs.MinimumWidth = 6;
            this.dgvtongsogs.Name = "dgvtongsogs";
            this.dgvtongsogs.Width = 135;
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(776, 490);
            this.btndong.Margin = new System.Windows.Forms.Padding(4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(100, 28);
            this.btndong.TabIndex = 4;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(171, 364);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(117, 44);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // Quanlykhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 709);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.dgvqlkhoa);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Quanlykhoa";
            this.Text = "Quản lý khoa";
            this.Load += new System.EventHandler(this.Quanlykhoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlkhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltenkhoa;
        private System.Windows.Forms.Label lblmakhoa;
        private System.Windows.Forms.Label lbltongsogs;
        private System.Windows.Forms.TextBox txttongsogs;
        private System.Windows.Forms.TextBox txttenkhoa;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dgvqlkhoa;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmakhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtongsogs;
        private System.Windows.Forms.Button btnsua;
    }
}