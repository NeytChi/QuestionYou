using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace QuestionYou
{
    public class QuestionSetup
    {
        public List<Question> Questions { get; set; }
        public string Path = Directory.GetCurrentDirectory() + "\\";

        public List<Question> GetQuestions()
        {
            var path = Path + "questions.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                Questions = JsonSerializer.Deserialize<List<Question>>(json);
                return Questions;
            }
            return null;
        }
        public void SetQuestions(List<Question> questions)
        {
            Questions = questions;
            var path = Path + "questions.json";
            var json = JsonSerializer.Serialize(questions);
            File.WriteAllText(path, json);
        }
    }
}
