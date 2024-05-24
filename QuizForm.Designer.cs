namespace LearningQuiz
{
    partial class QuizForm
    {
        private System.Windows.Forms.Label lblQuestion;
        private MetroFramework.Controls.MetroButton btnOption1;
        private MetroFramework.Controls.MetroButton btnOption2;
        private MetroFramework.Controls.MetroButton btnOption3;
        private MetroFramework.Controls.MetroButton btnOption4;

        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnOption1 = new MetroFramework.Controls.MetroButton();
            this.btnOption2 = new MetroFramework.Controls.MetroButton();
            this.btnOption3 = new MetroFramework.Controls.MetroButton();
            this.btnOption4 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = false;
            this.lblQuestion.Location = new System.Drawing.Point(23, 60);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(350, 60); // Adjust height as needed
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // btnOption1
            // 
            this.btnOption1.Location = new System.Drawing.Point(23, 130);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(350, 23);
            this.btnOption1.TabIndex = 1;
            this.btnOption1.Text = "Option 1";
            this.btnOption1.UseSelectable = true;
            this.btnOption1.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.Location = new System.Drawing.Point(23, 170);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(350, 23);
            this.btnOption2.TabIndex = 2;
            this.btnOption2.Text = "Option 2";
            this.btnOption2.UseSelectable = true;
            this.btnOption2.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.Location = new System.Drawing.Point(23, 210);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(350, 23);
            this.btnOption3.TabIndex = 3;
            this.btnOption3.Text = "Option 3";
            this.btnOption3.UseSelectable = true;
            this.btnOption3.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnOption4
            // 
            this.btnOption4.Location = new System.Drawing.Point(23, 250);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(350, 23);
            this.btnOption4.TabIndex = 4;
            this.btnOption4.Text = "Option 4";
            this.btnOption4.UseSelectable = true;
            this.btnOption4.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // QuizForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnOption1);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption4);
            this.Name = "QuizForm";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
