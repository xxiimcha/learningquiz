namespace LearningQuiz
{
    partial class ScoreForm
    {
        private System.ComponentModel.IContainer components = null;
        private MetroFramework.Controls.MetroLabel lblScore;
        private MetroFramework.Controls.MetroLabel lblMessage;
        private MetroFramework.Controls.MetroButton btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblScore = new MetroFramework.Controls.MetroLabel();
            this.lblMessage = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(23, 60);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(83, 19);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Your score: ";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(23, 100);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(63, 19);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(23, 140);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ScoreForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblScore);
            this.Name = "ScoreForm";
            this.Text = "Quiz Completed";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
