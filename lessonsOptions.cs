using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LearningQuiz
{
    public partial class LessonsOption : MetroForm
    {
        public LessonsOption()
        {
            InitializeComponent();
        }

        private void LoadLessons(string filePath)
        {
            try
            {
                SubjectManager subjectManager = new SubjectManager(filePath);
                var lessons = subjectManager.GetLessons();
                LessonsForm lessonsForm = new LessonsForm(lessons);
                lessonsForm.Show();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComprog_Click(object sender, EventArgs e)
        {
            LoadLessons("lessons_comprog.json");
        }

        private void btnItf_Click(object sender, EventArgs e)
        {
            LoadLessons("lessons_itf.json");
        }

        private void btnNstp_Click(object sender, EventArgs e)
        {
            LoadLessons("lessons_nstp.json");
        }

        private void btnGranby_Click(object sender, EventArgs e)
        {
            LoadLessons("lessons_granby.json");
        }

        private void btnComorg_Click(object sender, EventArgs e)
        {
            LoadLessons("lessons_comorg.json");
        }
    }
}
