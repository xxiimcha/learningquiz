using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LearningQuiz
{
    public partial class SplashScreenForm : MetroForm
    {
        private Timer timer;
        private int progressValue = 0;

        public SplashScreenForm()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 100; // Update every 100 milliseconds
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressValue += 1; // Increment progress value
            if (progressValue <= 100)
            {
                metroProgressBar1.Value = progressValue;
                lblLoading.Text = $"Loading... {progressValue}%";
            }
            else
            {
                timer.Stop();
                this.Hide(); // Hide the splash screen
                Menu menuForm = new Menu();
                menuForm.Show();
            }
        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {
            // Handle progress bar click event if needed
        }
    }
}
