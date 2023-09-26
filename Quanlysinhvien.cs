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
    public partial class Quanlysinhvien : Form
    {
        DATASINHVIEN db;

        public string ID { get; private set; }

        public Quanlysinhvien()
        {
            InitializeComponent();
            db = new DATASINHVIEN();
        }
        
        private void btnquanlykhoa_Click(object sender, EventArgs e)
        {
            Quanlykhoa f2 = new Quanlykhoa();
            f2.ShowDialog();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            Timkiem f3 = new Timkiem();
            f3.ShowDialog();
        }

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

        private void hienthiCombobox(List<Faculty> facLst)
        {
            cmbkhoa.DataSource = facLst;
            cmbkhoa.DisplayMember = "FacultyName";
            cmbkhoa.ValueMember = "FacultyID";
        }
        private void Quanlysinhvien_Load(object sender, EventArgs e)
        {
            List<Student> stu = db.Students.ToList();
            List<Faculty> fac = db.Faculties.ToList();
            hienthiDS(stu);
            hienthiCombobox(fac);
            cmbkhoa.SelectedIndex = 0;
            /*
            //luôn luôn sử dụng context để làm việc với các class
            DATASINHVIEN context = new DATASINHVIEN();
            //1. lấy tất cả các sinh viên từ bảng Student
            List<Student> listStudent = context.Students.ToList();
            //2. lấy sinh viên đầu tiên có StudentID = ID cho trước
            Student db = context.Students.FirstOrDefault(p => p.StudentID == ID);
            //3. insert 1 đối tượng sinh viên s vào database
            Student s = new Student()
            {
                StudentID = "99",
                FullName = "test insert",
                AverageScore
            = 100
            };
            context.Students.Add(s);
            context.SaveChanges();
            //4. Update sinh viên -> lấy item ra và cần update thuộc tính nào thì set thuộc tinh đó
            Student dbUpdate = context.Students.FirstOrDefault(p => p.StudentID == ID);
            if (dbUpdate != null)
            {
                dbUpdate.FullName = "Update FullName"; //....
                context.SaveChanges(); //lưu thay đổi
            }
            //5. Xóa Student có ID cho trước , tương tự update
            Student dbDelete = context.Students.FirstOrDefault(p => p.StudentID == ID);
            if (dbDelete != null)
            {
                context.Students.Remove(db);
                context.SaveChanges(); // lưu thay dổi
            }
            //6. Lưu ý: Nếu sử dụng using System.Data.Entity.Migrations; có thể sử dụng hàm AddOrUpdate để thay thế Add và Update từ EntityFrameWork 6.0.0.0
            context.Students.AddOrUpdate(s); //Add or Update sinh viên s
            context.SaveChanges();*/

        }

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

         private bool CheckData()
        {
            if(string.IsNullOrEmpty(txtmssv.Text)|| string.IsNullOrEmpty(txthoten.Text) || string.IsNullOrEmpty(txtdtb.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            else if(txtmssv.TextLength <= 3 && txtmssv.TextLength > 100) 
            {
                MessageBox.Show("Mã số sinh viên phải có từ 3 đến 100 ký tự");
                return false;
            }
            return true;
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                return;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Quanlykhoa f2 = new Quanlykhoa();
            f2.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timkiem f3 = new Timkiem();
            f3.ShowDialog();
        }
    }
}


