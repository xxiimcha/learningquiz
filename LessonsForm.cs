using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LearningQuiz
{
    public partial class LessonsForm : MetroForm
    {
        private List<Lesson> lessons;

        public LessonsForm(List<Lesson> lessons)
        {
            InitializeComponent();
            this.lessons = lessons;
            InitializeBackButton();
            DisplayLessons();
        }

        private void InitializeBackButton()
        {
            var backButton = new MetroFramework.Controls.MetroButton
            {
                Text = "Back",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(10),
                Dock = DockStyle.Top
            };
            backButton.Click += BackButton_Click;

            this.Controls.Add(backButton);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the LessonsForm to return to the previous form
        }

        private void DisplayLessons()
        {
            var scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            var tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                ColumnCount = 1
            };

            foreach (var lesson in lessons)
            {
                var lessonTitle = new Label
                {
                    Text = lesson.Title,
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    AutoSize = true,
                    Padding = new Padding(10, 10, 0, 10)
                };
                tableLayoutPanel.Controls.Add(lessonTitle);

                foreach (var topic in lesson.Topics)
                {
                    var topicButton = new Button
                    {
                        Text = topic.Title,
                        Font = new Font("Segoe UI", 10F),
                        AutoSize = true,
                        Margin = new Padding(20, 5, 0, 5),
                        Tag = topic.Content // Store the content in the Tag property
                    };
                    topicButton.Click += TopicButton_Click;
                    tableLayoutPanel.Controls.Add(topicButton);
                }
            }

            scrollablePanel.Controls.Add(tableLayoutPanel);
            this.Controls.Add(scrollablePanel);
        }

        private void TopicButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                string title = button.Text;
                string content = button.Tag as string;
                DefinitionForm definitionForm = new DefinitionForm(title, content);
                definitionForm.ShowDialog();
            }
        }
    }
}
