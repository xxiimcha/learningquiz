
namespace LearningQuiz
{
    partial class quizOptions
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
            this.nstp = new MetroFramework.Controls.MetroButton();
            this.comprog = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // nstp
            // 
            this.nstp.Location = new System.Drawing.Point(162, 94);
            this.nstp.Name = "nstp";
            this.nstp.Size = new System.Drawing.Size(178, 57);
            this.nstp.TabIndex = 3;
            this.nstp.Text = "NSTP";
            this.nstp.UseSelectable = true;
            this.nstp.Click += new System.EventHandler(this.nstp_Click_1);
            // 
            // comprog
            // 
            this.comprog.Location = new System.Drawing.Point(162, 157);
            this.comprog.Name = "comprog";
            this.comprog.Size = new System.Drawing.Size(178, 55);
            this.comprog.TabIndex = 4;
            this.comprog.Text = "Computer Programming";
            this.comprog.UseSelectable = true;
            this.comprog.Click += new System.EventHandler(this.comprog_Click_1);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(162, 218);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(178, 52);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "IT Fundamentals";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(162, 334);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(178, 52);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "Granby Values";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(162, 276);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(178, 52);
            this.metroButton5.TabIndex = 7;
            this.metroButton5.Text = "Computer Organization Arhictecture";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // quizOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.comprog);
            this.Controls.Add(this.nstp);
            this.Name = "quizOptions";
            this.Text = "quizOptions";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton nstp;
        private MetroFramework.Controls.MetroButton comprog;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
    }
}