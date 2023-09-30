using QUANLYSINHVIEN1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYSINHVIEN1
{
    public partial class Timkiem : Form
    {
        DATASINHVIEN db;
        public Timkiem()
        {
            InitializeComponent();
            db = new DATASINHVIEN();
        }

        // HIỂN THỊ DANH SÁCH
        private void hienthiDS(List<Student> stuLst)
        {
            dgvtimkiem.Rows.Clear();
            foreach (Student item in stuLst)
            {
                int index = dgvtimkiem.Rows.Add();
                dgvtimkiem.Rows[index].Cells[0].Value = item.StudentID;
                dgvtimkiem.Rows[index].Cells[1].Value = item.FullName;
                dgvtimkiem.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvtimkiem.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        //BUTTON TÌM KIẾM
        private void btntimkiem_Click(object sender, EventArgs e)
        {         
            dgvtimkiem.Rows.Clear();
            var st = db.Students.Where(x => x.StudentID.Contains(txtmsv.Text)).ToList();

            if (st.Count == 0)
            {
                MessageBox.Show("Không tìm thấy mã số sinh viên!");
            }
            else
            {
                hienthiDS(st);
            }  
        }

        //BUTTTON TRỞ VỀ
        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BUTTON XÓA
        private void btnxoaa_Click(object sender, EventArgs e)
        {
            var st = db.Students.FirstOrDefault(x => x.StudentID == txtmsv.Text);

            if (st == null)
            {
                MessageBox.Show("Không tìm thấy mã số sinh viên cần xóa!");
            }
            else
            {
                db.Students.Remove(st);
                db.SaveChanges();
                MessageBox.Show("Đã xóa dữ liệu thành công !");
                List<Student> stu = db.Students.ToList();
                dgvtimkiem.Rows.Clear();
                dgvtimkiem.Refresh();
                hienthiDS(stu);

            }
        }
    }
}
