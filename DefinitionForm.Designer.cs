namespace LearningQuiz
{
    partial class DefinitionForm
    {
        private MetroFramework.Controls.MetroLabel lblTitle;
        private MetroFramework.Controls.MetroTextBox txtContent;

        private void InitializeComponent()
        {
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.txtContent = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitle.Location = new System.Drawing.Point(23, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Definition";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(23, 70);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(400, 300);
            this.txtContent.TabIndex = 1;
            // 
            // DefinitionForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblTitle);
            this.Name = "DefinitionForm";
            this.Text = "Definition";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
