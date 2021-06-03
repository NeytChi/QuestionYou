using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionYouWindowsForms
{
    public partial class UserForm : Form
    {
        Question currentQuestion;
        QuestionSetup Setup = new QuestionSetup();
        List<Answer> Answers = new List<Answer>();
        public UserForm()
        {
            InitializeComponent();
            StartUp();
            LastButton.Visible = false;
        }
        public void StartUp()
        {
            var questions = Setup.GetQuestions();
            foreach (var question in questions)
            {
                Answers.Add(new Answer
                {
                    Id = question.Id,
                    Value = ""
                });
            }
            if (questions.Count != 0)
            {
                currentQuestion = questions.First();
                ShowCurrentQuestion(currentQuestion);
            }
        }
        private void ShowCurrentQuestion(Question question)
        {
            var answer = Answers.First(a => a.Id == currentQuestion.Id);
            QuestionLabel.Text = question.Value;
            AnswerTextBox.Text = answer.Value;
        }
        private void SetAnswer()
        {
            foreach (var answer in Answers)
            {
                if (answer.Id == currentQuestion.Id)
                {
                    answer.Value = AnswerTextBox.Text;
                }
            }
        }
        private void LastButton_Click(object sender, EventArgs e)
        {
            currentQuestion = Setup.Questions.First(q => q.Id == currentQuestion.Id - 1);
            ShowCurrentQuestion(currentQuestion);
            if (0 == currentQuestion.Id - 1)
            {
                LastButton.Visible = false;
                return;
            }
            NextButton.Visible = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            SetAnswer();
            currentQuestion = Setup.Questions.First(q => q.Id == currentQuestion.Id + 1);
            ShowCurrentQuestion(currentQuestion);
            if (Setup.Questions.Count == currentQuestion.Id)
            {
                NextButton.Visible = false;
                return;
            }
            LastButton.Visible = true;
        }
        private void EndButton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            Close();
        }
    }
}
