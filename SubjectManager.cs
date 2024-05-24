using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LearningQuiz
{
    public class SubjectManager
    {
        private List<Lesson> lessons;

        public SubjectManager(string lessonsFilePath) // Corrected the parameter name here
        {
            LoadLessons(lessonsFilePath);
        }

        private void LoadLessons(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("The specified file was not found.", filePath);

            string json = File.ReadAllText(filePath);
            var subject = JsonConvert.DeserializeObject<Subject>(json);
            lessons = subject.Lessons;
        }

        public List<Lesson> GetLessons()
        {
            return lessons;
        }
    }

    public class Subject
    {
        public string Name { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
