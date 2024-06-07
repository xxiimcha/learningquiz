using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LearningQuiz
{
    public partial class ScoreForm : MetroForm
    {
        public ScoreForm(int score, int totalQuestions)
        {
            InitializeComponent();
            lblScore.Text = $"Your score: {score}/{totalQuestions}";
            lblMessage.Text = GetScoreMessage(score, totalQuestions);
        }

        private string GetScoreMessage(int score, int totalQuestions)
        {
            double percentage = (double)score / totalQuestions * 100;

            if (percentage == 100)
            {
                return "Perfect score! Excellent job!";
            }
            else if (percentage >= 75)
            {
                return "Great job! You scored very well.";
            }
            else if (percentage >= 50)
            {
                return "Good effort! Keep practicing.";
            }
            else
            {
                return "Don't worry, keep trying!";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
