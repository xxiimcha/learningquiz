namespace LearningQuiz
{
    partial class LessonsOption
    {
        private MetroFramework.Controls.MetroButton btnComprog;
        private MetroFramework.Controls.MetroButton btnItf;
        private MetroFramework.Controls.MetroButton btnNstp;
        private MetroFramework.Controls.MetroButton btnGranby;
        private MetroFramework.Controls.MetroButton btnComorg;

        private void InitializeComponent()
        {
            this.btnComprog = new MetroFramework.Controls.MetroButton();
            this.btnItf = new MetroFramework.Controls.MetroButton();
            this.btnNstp = new MetroFramework.Controls.MetroButton();
            this.btnGranby = new MetroFramework.Controls.MetroButton();
            this.btnComorg = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnComprog
            // 
            this.btnComprog.Location = new System.Drawing.Point(23, 63);
            this.btnComprog.Name = "btnComprog";
            this.btnComprog.Size = new System.Drawing.Size(200, 40);
            this.btnComprog.TabIndex = 0;
            this.btnComprog.Text = "Computer Programming";
            this.btnComprog.UseSelectable = true;
            this.btnComprog.Click += new System.EventHandler(this.btnComprog_Click);
            // 
            // btnItf
            // 
            this.btnItf.Location = new System.Drawing.Point(23, 109);
            this.btnItf.Name = "btnItf";
            this.btnItf.Size = new System.Drawing.Size(200, 40);
            this.btnItf.TabIndex = 1;
            this.btnItf.Text = "IT Fundamentals";
            this.btnItf.UseSelectable = true;
            this.btnItf.Click += new System.EventHandler(this.btnItf_Click);
            // 
            // btnNstp
            // 
            this.btnNstp.Location = new System.Drawing.Point(23, 155);
            this.btnNstp.Name = "btnNstp";
            this.btnNstp.Size = new System.Drawing.Size(200, 40);
            this.btnNstp.TabIndex = 2;
            this.btnNstp.Text = "NSTP";
            this.btnNstp.UseSelectable = true;
            this.btnNstp.Click += new System.EventHandler(this.btnNstp_Click);
            // 
            // btnGranby
            // 
            this.btnGranby.Location = new System.Drawing.Point(23, 201);
            this.btnGranby.Name = "btnGranby";
            this.btnGranby.Size = new System.Drawing.Size(200, 40);
            this.btnGranby.TabIndex = 3;
            this.btnGranby.Text = "Granby";
            this.btnGranby.UseSelectable = true;
            this.btnGranby.Click += new System.EventHandler(this.btnGranby_Click);
            // 
            // btnComorg
            // 
            this.btnComorg.Location = new System.Drawing.Point(23, 247);
            this.btnComorg.Name = "btnComorg";
            this.btnComorg.Size = new System.Drawing.Size(200, 40);
            this.btnComorg.TabIndex = 4;
            this.btnComorg.Text = "Computer Organization";
            this.btnComorg.UseSelectable = true;
            this.btnComorg.Click += new System.EventHandler(this.btnComorg_Click);
            // 
            // LessonsOption
            // 
            this.ClientSize = new System.Drawing.Size(250, 310);
            this.Controls.Add(this.btnComorg);
            this.Controls.Add(this.btnGranby);
            this.Controls.Add(this.btnNstp);
            this.Controls.Add(this.btnItf);
            this.Controls.Add(this.btnComprog);
            this.Name = "LessonsOption";
            this.Text = "Lessons Options";
            this.ResumeLayout(false);
        }
    }
}
