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
    public partial class Quanlykhoa : Form
    {

        DATASINHVIEN db;
        public Quanlykhoa()
        {
            InitializeComponent();
            db = new DATASINHVIEN();
        }

        //BUTTON ĐÓNG
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //HIỂN THỊ DANH SÁCH
        private void hienthiDS(List<Faculty> facLst)
        {
            foreach (Faculty item in facLst)
            {
                int index = dgvqlkhoa.Rows.Add();
                dgvqlkhoa.Rows[index].Cells[0].Value = item.FacultyID;
                dgvqlkhoa.Rows[index].Cells[1].Value = item.FacultyName;
                dgvqlkhoa.Rows[index].Cells[2].Value = item.TotalProfessor;
            }
        }

        //FORM QUẢN LÝ KHOA
        private void Quanlykhoa_Load(object sender, EventArgs e)
        {
            List<Faculty> fac = db.Faculties.ToList();
            hienthiDS(fac);
        }

        //BUTTON XÓA
        private void btnxoa_Click(object sender, EventArgs e)
        {
            var u = Convert.ToInt32(txtmakhoa.Text);
            var fc = db.Faculties.FirstOrDefault(x => x.FacultyID == u);

            if (fc == null)
            {
                MessageBox.Show("Không tìm thấy mã khoa cần xóa!");
            }
            else
            {
                db.Faculties.Remove(fc);
                db.SaveChanges();
                MessageBox.Show("Đã xóa dữ liệu thành công !");
                List<Faculty> fcc = db.Faculties.ToList();
                dgvqlkhoa.Rows.Clear();
                dgvqlkhoa.Refresh();
                hienthiDS(fcc);

            }
        }

        //BUTTON THÊM
        private void btnthem_Click(object sender, EventArgs e)
        {
            Faculty fac = new Faculty();
            fac.FacultyID = Convert.ToInt32(txtmakhoa.Text);
            fac.FacultyName = txttenkhoa.Text;

            fac.TotalProfessor = Convert.ToInt32(txttongsogs.Text);

            db.Faculties.Add(fac);
            db.SaveChanges();

            MessageBox.Show("Thêm dữ liệu cho khoa thành công !");
            List<Faculty> facc = db.Faculties.ToList();
            dgvqlkhoa.Rows.Clear();
            dgvqlkhoa.Refresh();
            hienthiDS(facc);
        }

        //BUTTON SỬA
        private void btnsua_Click(object sender, EventArgs e)
        {
            var y = Convert.ToInt32(txtmakhoa.Text);
            var fc = db.Faculties.FirstOrDefault(x => x.FacultyID == y);

            if (fc == null)
            {
                MessageBox.Show("Không tìm thấy mã số sinh viên cần sửa!");
            }
            else
            {
                if (btnsua.Text == "Sửa")
                {
                    // tai thong tin len textbox
                    txtmakhoa.Text = fc.FacultyID.ToString();
                    txttenkhoa.Text = fc.FacultyName.ToString();
                    txttongsogs.Text = fc.TotalProfessor.ToString();

                    btnsua.Text = "Hoàn thành";
                }
                else
                {
                    var k = Convert.ToInt32(txttongsogs.Text);
                    // luu vao db
                    fc.FacultyID = y;
                    fc.FacultyName = txttenkhoa.Text;
                    fc.TotalProfessor = k;

                    db.SaveChanges();

                    btnsua.Text = "Sửa";
                    MessageBox.Show("Sửa thành công !");

                    List<Faculty> fcc = db.Faculties.ToList();
                    dgvqlkhoa.Rows.Clear();
                    dgvqlkhoa.Refresh();
                    hienthiDS(fcc);
                }

            }
        }
    }
}
