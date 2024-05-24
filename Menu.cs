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
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quiz_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the splash screen
            quizOptions quizMenu = new quizOptions();
            quizMenu.Show();
        }

        private void study_Click(object sender, EventArgs e)
        {
            this.Hide();
            LessonsOption lessons = new LessonsOption();
            lessons.Show();
        }
    }
}
