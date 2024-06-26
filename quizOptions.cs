﻿using System;
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

        private void metroButton4_Click(object sender, EventArgs e)
        {
            LoadQuiz("questions_granby.json");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            LoadQuiz("questions_itf.json");
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            LoadQuiz("questions_comorg.json");
        }
    }
}
