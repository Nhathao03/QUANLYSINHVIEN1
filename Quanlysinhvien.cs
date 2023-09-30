using QUANLYSINHVIEN1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYSINHVIEN1
{
    public partial class Quanlysinhvien : Form
    {
        DATASINHVIEN db;

        public string ID { get; private set; }

        public Quanlysinhvien()
        {
            InitializeComponent();
            db = new DATASINHVIEN();
        }
        
        //SHOW FORM QUẢN LÝ KHOA
        private void btnquanlykhoa_Click(object sender, EventArgs e)
        {
            Quanlykhoa f2 = new Quanlykhoa();
            f2.ShowDialog();
        }

        //SHOW FORM TÌM KIẾM
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            Timkiem f3 = new Timkiem();
            f3.ShowDialog();
        }

        //HÀM HIỂN THỊ DANH SÁCH 
        private void hienthiDS(List<Student> stuLst)
        {
            foreach(Student item in stuLst)
            {
                int index = dgvdata.Rows.Add();
                dgvdata.Rows[index].Cells[0].Value = item.StudentID;
                dgvdata.Rows[index].Cells[1].Value = item.FullName;
                dgvdata.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvdata.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        //HÀM HIỂN THỊ COMBOBOX
        private void hienthiCombobox(List<Faculty> facLst)
        {
            cmbkhoa.DataSource = facLst;
            cmbkhoa.DisplayMember = "FacultyName";
            cmbkhoa.ValueMember = "FacultyID";
        }

        //GỌI HÀM HIỂN THỊ FORM KHOA VÀ COMBOBOX
        private void Quanlysinhvien_Load(object sender, EventArgs e)
        {
            List<Student> stu = db.Students.OrderBy(x => x.CreatedDate).ToList();
            List<Faculty> fac = db.Faculties.ToList();
            hienthiDS(stu);
            hienthiCombobox(fac);
            cmbkhoa.SelectedIndex = 0;
        }

        //BUTTTUN THOÁT
        private void btnthoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại thông báo và kiểm tra kết quả người dùng
            DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục ? "," Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra kết quả người dùng
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        //KIỂM TRA DỮ LIỆU KHI NHẬP VÀO
         private bool CheckData()
        {
            if(string.IsNullOrEmpty(txtmssv.Text)|| string.IsNullOrEmpty(txthoten.Text) || string.IsNullOrEmpty(txtdtb.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            if(txtmssv.TextLength < 3 && txtmssv.TextLength > 100) 
            {
                MessageBox.Show("Mã số sinh viên phải có từ 3 đến 100 ký tự");
                return false;
            }
            if (cmbkhoa.Text == null)
            {
                MessageBox.Show("Vui lòng chọn khoa cho sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbkhoa.Focus();
                return false;
            }
            if (txtdtb.Text == null)
            {
                MessageBox.Show("Vui lòng nhập điểm trung bình cho sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdtb.Focus();
                return false;
            }
            return true;
        }

        //BUTTON THÊM
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                return;
            }

            Student student = new Student();
            student.StudentID = txtmssv.Text;
            student.FullName = txthoten.Text;
            student.FacultyID = Convert.ToInt32(cmbkhoa.SelectedValue);
            student.AverageScore = Convert.ToDouble(txtdtb.Text);
            student.CreatedDate = DateTime.Now;

            db.Students.Add(student);
            db.SaveChanges();

            MessageBox.Show("Thêm dữ liệu thành công !");
            List<Student> stu = db.Students.OrderBy(x => x.CreatedDate).ToList();
            dgvdata.Rows.Clear();
            dgvdata.Refresh();
            hienthiDS(stu);
        }


        //BUTTON QUẢN LÝ KHOA
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Quanlykhoa f2 = new Quanlykhoa();
            f2.ShowDialog();
        }

        //BUTTON TÌM KIẾM
        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timkiem f3 = new Timkiem();
            f3.ShowDialog();
        }

        private void cmbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //BUTTON XÓA
        private void btnxoa_Click(object sender, EventArgs e)
        {
            var st = db.Students.FirstOrDefault(x => x.StudentID == txtmssv.Text);

            if (st == null)
            {
                MessageBox.Show("Không tìm thấy mã số sinh viên cần xóa!");
            }
            else
            {
                db.Students.Remove(st);
                db.SaveChanges();
                MessageBox.Show("Đã xóa dữ liệu thành công !");
                List<Student> stu = db.Students.OrderBy(x => x.CreatedDate).ToList();
                dgvdata.Rows.Clear();
                dgvdata.Refresh();
                hienthiDS(stu);
                
            }
        }

        //BUTTON SỬA
        private void btnsua_Click(object sender, EventArgs e)
        {
            var st = db.Students.FirstOrDefault(x => x.StudentID == txtmssv.Text);

            if (st == null)
            {
                MessageBox.Show("Không tìm thấy mã số sinh viên cần sửa!");
            }
            else
            {
                if(btnsua.Text == "Sửa")
                {
                    // tai thong tin len textbox
                    txtmssv.Text = st.StudentID.ToString();
                    txthoten.Text = st.FullName.ToString();
                    cmbkhoa.SelectedValue = st.FacultyID;
                    txtdtb.Text = st.AverageScore.ToString();

                    btnsua.Text = "Hoàn thành";
                }
                else
                {
                    // luu vao db
                    st.StudentID = txtmssv.Text;
                    st.FullName = txthoten.Text;
                    st.FacultyID = Convert.ToInt32(cmbkhoa.SelectedValue);
                    st.AverageScore = Convert.ToDouble(txtdtb.Text);
                    st.CreatedDate = DateTime.Now;
                    db.SaveChanges();

                    btnsua.Text = "Sửa";
                    MessageBox.Show("Sửa thành công !");

                    List<Student> stu = db.Students.OrderBy(x => x.CreatedDate).ToList();
                    dgvdata.Rows.Clear();
                    dgvdata.Refresh();
                    hienthiDS(stu);
                }

            }
        }

     
    }
}


