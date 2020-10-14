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
    public partial class FormRemoveProject : Form
    {
        public FormRemoveProject()
        {
            InitializeComponent();
            this.CenterTheForm();
            //ProjectToRemoveLabel.Text = ProjectToRemoveLabel.Text + this.Select()
        }
        private void FormRemoveProject_Load(object sender, EventArgs e)
        {

        }

        private void CenterTheForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ProjectToRemoveLabel_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
