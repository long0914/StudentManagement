using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {

        StudentManager studentManager;

        public Form1(StudentManager sm)
        {
            InitializeComponent();
            this.studentManager = sm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //    dgvStudents.DataSource = studentManager.GetStudents();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            studentManager.AddStudent(new Student(
                lblName.Text,
                Convert.ToInt32(txtSem.Text),
                txtAddress.Text,
                txtPhone.Text
                ));

            MessageBox.Show("New Student Added");




        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            dataForm df = new dataForm(studentManager);
            df.Show();
        }
    }
}
