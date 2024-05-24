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

        public QuizForm(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
            DisplayQuestion();
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
            }
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroButton button = sender as MetroFramework.Controls.MetroButton;
            if (button == null)
                return;

            var question = questions[currentQuestionIndex];
            int selectedOptionIndex = (int)button.Tag;

            if (question.CorrectOptions.Contains(selectedOptionIndex))
            {
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
                MessageBox.Show("Quiz completed!");
                this.Close(); // Close the form when quiz is completed
            }
        }
    }
}
