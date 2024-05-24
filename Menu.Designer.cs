
namespace LearningQuiz
{
    partial class Menu
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
            this.study = new MetroFramework.Controls.MetroButton();
            this.quiz = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // study
            // 
            this.study.Location = new System.Drawing.Point(97, 92);
            this.study.Name = "study";
            this.study.Size = new System.Drawing.Size(138, 49);
            this.study.TabIndex = 2;
            this.study.Text = "Study";
            this.study.UseSelectable = true;
            // 
            // quiz
            // 
            this.quiz.Location = new System.Drawing.Point(97, 184);
            this.quiz.Name = "quiz";
            this.quiz.Size = new System.Drawing.Size(138, 49);
            this.quiz.TabIndex = 3;
            this.quiz.Text = "Taks A Quiz";
            this.quiz.UseSelectable = true;
            this.quiz.Click += new System.EventHandler(this.quiz_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 328);
            this.Controls.Add(this.quiz);
            this.Controls.Add(this.study);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton study;
        private MetroFramework.Controls.MetroButton quiz;
    }
}