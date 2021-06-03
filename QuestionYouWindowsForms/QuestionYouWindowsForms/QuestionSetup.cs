using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace QuestionYouWindowsForms
{
    public class QuestionSetup
    {
        public List<Question> Questions { get; set; }
        public string Path = Directory.GetCurrentDirectory() + "\\";
        public QuestionSetup()
        {
            GetQuestions();
        }
        public List<Question> GetQuestions()
        {
            var path = Path + "questions.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                Questions = JsonConvert.DeserializeObject<List<Question>>(json);
                return Questions;
            }
            return null;
        }
        public void SetQuestions(List<Question> questions)
        {
            Questions = questions;
            var path = Path + "questions.json";
            var json = JsonConvert.SerializeObject(questions);
            File.WriteAllText(path, json);
        }
    }
}
