using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Question
{
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public List<int> CorrectOptions { get; set; }
}

public class Subject
{
    public string Name { get; set; }
    public List<Question> Questions { get; set; }
}

public class QuizManager
{
    private Subject subject;

    public QuizManager(string filePath)
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

    public List<Question> GetRandomQuestions(int count)
    {
        var random = new Random();
        List<Question> randomizedQuestions = new List<Question>(subject.Questions);

        // Shuffle the questions
        for (int i = randomizedQuestions.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            var tempQuestion = randomizedQuestions[i];
            randomizedQuestions[i] = randomizedQuestions[j];
            randomizedQuestions[j] = tempQuestion;
        }

        // Shuffle the options for each question
        foreach (var question in randomizedQuestions)
        {
            List<string> options = question.Options;
            for (int i = options.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                var tempOption = options[i];
                options[i] = options[j];
                options[j] = tempOption;
            }

            // Update correct options to match shuffled options
            List<int> newCorrectOptions = new List<int>();
            foreach (int correctIndex in question.CorrectOptions)
            {
                newCorrectOptions.Add(options.IndexOf(question.Options[correctIndex]));
            }
            question.CorrectOptions = newCorrectOptions;
        }

        // Return only the requested number of questions
        return randomizedQuestions.GetRange(0, Math.Min(count, randomizedQuestions.Count));
    }
}
