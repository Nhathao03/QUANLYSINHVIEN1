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

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hienthiDS(List<Student> stuLst)
        {
            foreach (Student item in stuLst)
            {
                int index = dgvqlkhoa.Rows.Add();
                dgvqlkhoa.Rows[index].Cells[0].Value = item.FacultyID;
                dgvqlkhoa.Rows[index].Cells[1].Value = item.Faculty.FacultyName;
            }
        }

        private void Quanlykhoa_Load(object sender, EventArgs e)
        {
            List<Student> stu = db.Students.ToList();
            List<Faculty> fac = db.Faculties.ToList();
            hienthiDS(stu);
        }
    }
}
