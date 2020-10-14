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
    public partial class FormMain : Form
    {
        public AppUser activeUser = null;

        public Project currentProject = null;

        public FakePreferenceRepository preferences = new FakePreferenceRepository();

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterTheForm();
            this.LoginLoop();
        }

        private void CenterTheForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void LoginLoop()
        {

            using (FormLogin loginForm = new FormLogin())
            {
                do
                {
                    loginForm.ShowDialog(this);

                } while (loginForm.DialogResult == DialogResult.OK && (!loginForm.ReturnUser?.isAuthenticated ?? true));

                if(!(loginForm.DialogResult == DialogResult.OK))
                {
                    this.Close();
                }

                activeUser = loginForm.ReturnUser;
            }

            if(activeUser == null)
            {
                Environment.Exit(1);
            }

            using (FormSelectProject projectSelectForm = new FormSelectProject())
            {
                do
                {
                    projectSelectForm.ShowDialog(this);

                } while (projectSelectForm.DialogResult == DialogResult.OK && (projectSelectForm.returnProject is null));

                if (!(projectSelectForm.DialogResult == DialogResult.Cancel))
                {
                    this.Close();
                }

                currentProject = projectSelectForm.returnProject;
            }

            if (currentProject == null)
            {
                Environment.Exit(1);
            }


            preferences.SetPreference(activeUser.UserName, currentProject.Name, currentProject.Name);

            this.SetText();
        }

        private void SetText()
        {
            this.Text = $"Main - {currentProject.Name}";
        }

        private void IssueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RequirementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DesignToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CountByAssigneeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListByAssigneeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CountByArtifactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListByArtifactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CountByDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListByDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TrendByDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormSelectProject selectProject = new FormSelectProject())
            {
                do
                {
                    selectProject.ShowDialog(this);

                } while (selectProject.DialogResult == DialogResult.OK);
            }
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateProject createProjectForm = new FormCreateProject();
            
            createProjectForm.ShowDialog();
        }



        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRemoveProject removeProjectForm = new FormRemoveProject();

            removeProjectForm.ShowDialog();
        }

        private void modifyProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModifyProject modifyProjectForm = new FormModifyProject();

            modifyProjectForm.ShowDialog();
        }
    }
}
