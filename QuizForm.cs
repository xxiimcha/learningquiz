using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LearningQuiz
{
    public partial class QuizForm : MetroForm
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private Timer timer;
        private int timeLeft = 30; // 30 seconds for each question

        public QuizForm(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
            InitializeTimer();
            DisplayQuestion();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second intervals
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTimer.Text = $"Time left: {timeLeft} seconds";
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Time's up!");
                currentQuestionIndex++;
                if (currentQuestionIndex < questions.Count)
                {
                    DisplayQuestion();
                }
                else
                {
                    ShowScoreForm();
                }
            }
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                var question = questions[currentQuestionIndex];
                lblQuestion.Text = question.Text;
                btnOption1.Text = question.Options[0];
                btnOption1.Tag = 0;
                btnOption2.Text = question.Options[1];
                btnOption2.Tag = 1;
                btnOption3.Text = question.Options[2];
                btnOption3.Tag = 2;
                btnOption4.Text = question.Options[3];
                btnOption4.Tag = 3;

                timeLeft = 30; // reset timer for each question
                lblTimer.Text = $"Time left: {timeLeft} seconds";
                timer.Start();
            }
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            timer.Stop();
            MetroFramework.Controls.MetroButton button = sender as MetroFramework.Controls.MetroButton;
            if (button == null)
                return;

            var question = questions[currentQuestionIndex];
            int selectedOptionIndex = (int)button.Tag;

            if (question.CorrectOptions.Contains(selectedOptionIndex))
            {
                score++;
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }

            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                DisplayQuestion();
            }
            else
            {
                ShowScoreForm();
            }
        }

        private void ShowScoreForm()
        {
            ScoreForm scoreForm = new ScoreForm(score, questions.Count);
            scoreForm.ShowDialog();
            this.Close(); // Close the form when the score form is displayed
        }
    }

}
