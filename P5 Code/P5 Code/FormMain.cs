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

            using (FormSelectProject SelectProjectForm = new FormSelectProject())
            {
                DialogResult result;
                do
                {
                    result = SelectProjectForm.ShowDialog();
                } while (result != DialogResult.OK);

                currentProject = SelectProjectForm.SelectedProject;
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
            string NewProjectName = "";

            bool validresult = false;
            using (FormCreateProject CreateProjectForm = new FormCreateProject())
            {
                do
                {
                    if (CreateProjectForm.ShowDialog() == DialogResult.OK)
                    {
                        if (CreateProjectForm.NewProjectsName == "")
                        {
                            MessageBox.Show("Project name is empty or blank", "Attention");
                        }
                        else
                        {
                            NewProjectName = CreateProjectForm.NewProjectsName;
                            validresult = true;
                        }
                    }
                    else if (CreateProjectForm.ShowDialog() == DialogResult.Cancel)
                    {
                        validresult = true;
                    }
                } while (!validresult);
            }

            if (NewProjectName != "")
            {
                // instantiate new project and add to repo
            }
        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project ProjectToRemove = null;

            using (FormSelectProject SelectProjectForm = new FormSelectProject())
            {
                bool validresult = false;
                do
                {
                    if (SelectProjectForm.ShowDialog() == DialogResult.OK)
                    {
                        if (SelectProjectForm.SelectedProject == currentProject)
                        {
                            MessageBox.Show("Cannot remove your current session project.", "Attention");
                        }
                        else
                        {
                            ProjectToRemove = SelectProjectForm.SelectedProject;
                            validresult = true;
                        }
                    }
                    else if (SelectProjectForm.ShowDialog() == DialogResult.No)
                    {
                        MessageBox.Show("No project found.", "Attention");
                    }
                    else if (SelectProjectForm.ShowDialog() == DialogResult.Cancel)
                    {
                        validresult = true;
                    }
                } while (!validresult);
            }

            if (ProjectToRemove != null)
            {
                // remove project from repo
            }
        }

        private void modifyProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project ProjectToModify = null;

            using (FormSelectProject SelectProjectForm = new FormSelectProject())
            {
                bool validresult = false;
                do
                {
                    if (SelectProjectForm.ShowDialog() == DialogResult.OK)
                    {
                        if (SelectProjectForm.SelectedProject == currentProject)
                        {
                            MessageBox.Show("Cannot modify your current session project.", "Attention");
                        }
                        else
                        {
                            ProjectToModify = SelectProjectForm.SelectedProject;
                            validresult = true;
                        }
                    }
                    else if (SelectProjectForm.ShowDialog() == DialogResult.Cancel)
                    {
                        validresult = true;
                    }
                } while (!validresult);
            }

            if (ProjectToModify != null)
            {
                using (FormModifyProject ModifyProjectForm = new FormModifyProject())
                {
                    if (ModifyProjectForm.ShowDialog() == DialogResult.OK)
                    {
                        if (ModifyProjectForm.ProjectsNewName == "")
                        {
                            MessageBox.Show("Project name is empty or blank.", "Attention");
                        }
                        else
                        {
                            ProjectToModify.Name = ModifyProjectForm.ProjectsNewName;
                        }
                    }
                }
            }
        }
    }
}
