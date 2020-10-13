using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_Code
{
    public partial class FormSelectProject : Form
    {
        public FormSelectProject()
        {
            InitializeComponent();
        }

        private void FormSelectProject_Load(object sender, EventArgs e)
        {
            this.CenterTheForm();
            this.FillProjectList();
        }
        private void CenterTheForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void FillProjectList()
        {
            FakeProjectRepository repo = new FakeProjectRepository();

            listBox1.Items.Clear(); 

            foreach(Project prjt in repo.GetAll())
            {
                listBox1.Items.Add(prjt.Id + " - " + prjt.Name);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectProject_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();// ----------------------------------------------------------------------------------------------------------!!
        }
    }
}
