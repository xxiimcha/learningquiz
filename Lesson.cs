using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningQuiz
{
    public class Lesson
    {
        public string Title { get; set; }
        public List<Topic> Topics { get; set; }
    }

    public class Topic
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}