using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LearningQuiz
{
    public partial class DefinitionForm : MetroForm
    {
        public DefinitionForm(string title, string content)
        {
            InitializeComponent();
            lblTitle.Text = title;
            txtContent.Text = content;
        }
    }
}
