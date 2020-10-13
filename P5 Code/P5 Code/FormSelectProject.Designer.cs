namespace P5_Code
{
    partial class FormSelectProject
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SelectProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(464, 238);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(183, 311);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(126, 32);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SelectProject
            // 
            this.SelectProject.Location = new System.Drawing.Point(356, 311);
            this.SelectProject.Name = "SelectProject";
            this.SelectProject.Size = new System.Drawing.Size(126, 32);
            this.SelectProject.TabIndex = 2;
            this.SelectProject.Text = "Select Project";
            this.SelectProject.UseVisualStyleBackColor = true;
            this.SelectProject.Click += new System.EventHandler(this.SelectProject_Click);
            // 
            // FormSelectProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 375);
            this.Controls.Add(this.SelectProject);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.listBox1);
            this.Name = "FormSelectProject";
            this.Text = "Select Project";
            this.Load += new System.EventHandler(this.FormSelectProject_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button SelectProject;
    }
}