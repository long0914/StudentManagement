using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagement
{
    public partial class dataForm : Form
    {
        StudentManager studentManager;
        private Student selectedStudent;

        public dataForm(StudentManager sm)
        {
            InitializeComponent();
            this.studentManager = sm;
        }

        private void dataForm_Load(object sender, EventArgs e)
        {
            databinding();
        }

        private void databinding() {
            dgvStudents.DataSource = studentManager.GetStudents();
        }




    }
}
