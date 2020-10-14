using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_Code
{
    public partial class FormCreateProject : Form
    {
        public FormCreateProject()
        {
            InitializeComponent();
            this.CenterTheForm();
        }

        private void FormCreateProject_Load(object sender, EventArgs e)
        {

        }

        private void CenterTheForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ProjectNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
