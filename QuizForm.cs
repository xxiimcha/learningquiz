using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                metroLabel1.Text = question.Text;
                metroButton1.Text = question.Options[0];
                metroButton2.Text = question.Options[1];
                metroButton3.Text = question.Options[2];
                metroButton4.Text = question.Options[3];
            }
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
                return;

            var question = questions[currentQuestionIndex];
            int selectedOptionIndex = int.Parse(button.Tag.ToString());

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

        private MetroFramework.Controls.MetroLabel lblQuestion;
        private MetroFramework.Controls.MetroButton btnOption1;
        private MetroFramework.Controls.MetroButton btnOption2;
        private MetroFramework.Controls.MetroButton btnOption3;
        private MetroFramework.Controls.MetroButton btnOption4;
    }
}