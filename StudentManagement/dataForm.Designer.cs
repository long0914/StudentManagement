namespace StudentManagement
{
    partial class dataForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.studentManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(109, 75);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 62;
            this.dgvStudents.RowTemplate.Height = 28;
            this.dgvStudents.Size = new System.Drawing.Size(953, 596);
            this.dgvStudents.TabIndex = 0;
            // 
            // studentManagerBindingSource
            // 
            this.studentManagerBindingSource.DataSource = typeof(StudentManagement.StudentManager);
            // 
            // studentManagerBindingSource1
            // 
            this.studentManagerBindingSource1.DataSource = typeof(StudentManagement.StudentManager);
            // 
            // dataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 783);
            this.Controls.Add(this.dgvStudents);
            this.Name = "dataForm";
            this.Text = "dataForm";
            this.Load += new System.EventHandler(this.dataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.BindingSource studentManagerBindingSource;
        private System.Windows.Forms.BindingSource studentManagerBindingSource1;
    }
}