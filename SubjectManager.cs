using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LearningQuiz
{
    public class SubjectManager
    {
        private Subject subject;

        public SubjectManager(string filePath)
        {
            LoadSubject(filePath);
        }

        private void LoadSubject(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("The specified file was not found.", filePath);

            string json = File.ReadAllText(filePath);
            subject = JsonConvert.DeserializeObject<Subject>(json);
        }

        public List<Lesson> GetLessons()
        {
            return subject.Lessons;
        }
    }

    public class Subject
    {
        public string Name { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<Question> Questions { get; set; }
    }

    public class Lesson
    {
        public string Title { get; set; }
        public List<string> Topics { get; set; }
    }

    public class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public List<int> CorrectOptions { get; set; }
    }
}
