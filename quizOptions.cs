using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LearningQuiz
{
    public partial class quizOptions : MetroForm
    {
        public quizOptions()
        {
            InitializeComponent();
        }

        private void comprog_Click(object sender, EventArgs e)
        {
            LoadQuiz("questions_comprog.json");
        }


        private void itf_Click(object sender, EventArgs e)
        {
            LoadQuiz("questions_itf.json");
        }

        private void LoadQuiz(string filePath)
        {
            try
            {
                QuizManager quizManager = new QuizManager(filePath);
                var questions = quizManager.GetRandomQuestions(5);
                QuizForm quizForm = new QuizForm(questions);
                quizForm.Show();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nstp_Click_1(object sender, EventArgs e)
        {
            LoadQuiz("questions_nstp.json");
        }

        private void comprog_Click_1(object sender, EventArgs e)
        {
            LoadQuiz("questions_comprog.json");
        }
    }
}
