
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbltongsogs = new System.Windows.Forms.Label();
            this.lbltenkhoa = new System.Windows.Forms.Label();
            this.lblmakhoa = new System.Windows.Forms.Label();
            this.btnthemsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dgvqlkhoa = new System.Windows.Forms.DataGridView();
            this.dgvmakhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtongsogs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlkhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbltongsogs);
            this.groupBox1.Controls.Add(this.lbltenkhoa);
            this.groupBox1.Controls.Add(this.lblmakhoa);
            this.groupBox1.Location = new System.Drawing.Point(29, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(81, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lbltongsogs
            // 
            this.lbltongsogs.AutoSize = true;
            this.lbltongsogs.Location = new System.Drawing.Point(10, 139);
            this.lbltongsogs.Name = "lbltongsogs";
            this.lbltongsogs.Size = new System.Drawing.Size(64, 13);
            this.lbltongsogs.TabIndex = 2;
            this.lbltongsogs.Text = "Tổng số GS";
            // 
            // lbltenkhoa
            // 
            this.lbltenkhoa.AutoSize = true;
            this.lbltenkhoa.Location = new System.Drawing.Point(10, 96);
            this.lbltenkhoa.Name = "lbltenkhoa";
            this.lbltenkhoa.Size = new System.Drawing.Size(53, 13);
            this.lbltenkhoa.TabIndex = 1;
            this.lbltenkhoa.Text = "Tên khoa";
            // 
            // lblmakhoa
            // 
            this.lblmakhoa.AutoSize = true;
            this.lblmakhoa.Location = new System.Drawing.Point(10, 46);
            this.lblmakhoa.Name = "lblmakhoa";
            this.lblmakhoa.Size = new System.Drawing.Size(49, 13);
            this.lblmakhoa.TabIndex = 0;
            this.lblmakhoa.Text = "Mã khoa";
            // 
            // btnthemsua
            // 
            this.btnthemsua.Location = new System.Drawing.Point(29, 339);
            this.btnthemsua.Name = "btnthemsua";
            this.btnthemsua.Size = new System.Drawing.Size(94, 36);
            this.btnthemsua.TabIndex = 1;
            this.btnthemsua.Text = "Thêm / Sửa";
            this.btnthemsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(136, 339);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(93, 36);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // dgvqlkhoa
            // 
            this.dgvqlkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqlkhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmakhoa,
            this.dgvtenkhoa,
            this.dgvtongsogs});
            this.dgvqlkhoa.Location = new System.Drawing.Point(251, 87);
            this.dgvqlkhoa.Name = "dgvqlkhoa";
            this.dgvqlkhoa.Size = new System.Drawing.Size(406, 288);
            this.dgvqlkhoa.TabIndex = 3;
            // 
            // dgvmakhoa
            // 
            this.dgvmakhoa.HeaderText = "Mã Khoa";
            this.dgvmakhoa.Name = "dgvmakhoa";
            this.dgvmakhoa.Width = 120;
            // 
            // dgvtenkhoa
            // 
            this.dgvtenkhoa.HeaderText = "Tên Khoa";
            this.dgvtenkhoa.Name = "dgvtenkhoa";
            this.dgvtenkhoa.Width = 150;
            // 
            // dgvtongsogs
            // 
            this.dgvtongsogs.HeaderText = "Tống số GS";
            this.dgvtongsogs.Name = "dgvtongsogs";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(582, 398);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 4;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // Quanlykhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.dgvqlkhoa);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthemsua);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnthemsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dgvqlkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmakhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtongsogs;
        private System.Windows.Forms.Button btndong;
    }
}