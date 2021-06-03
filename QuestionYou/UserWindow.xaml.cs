using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace QuestionYou
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        Question currentQuestion;
        QuestionSetup Setup = new QuestionSetup();
        List<Answer> Answers = new List<Answer>();
        public UserWindow()
        {
            InitializeComponent();
            StartUp();
            PrevQuestionBtn.Visibility = Visibility.Hidden;
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
            QuestionLabel.Content = question.Value;
            AnswerTextBox.Text = answer.Value;
        }
        private void NextQuestionBtn_Click(object sender, RoutedEventArgs e)
        {
            SetAnswer();
            currentQuestion = Setup.Questions.First(q => q.Id == currentQuestion.Id + 1);
            if (Setup.Questions.Count == currentQuestion.Id)
            {
                NextQuestionBtn.Visibility = Visibility.Hidden;
            }
            else
                PrevQuestionBtn.Visibility = Visibility.Visible;
            ShowCurrentQuestion(currentQuestion);
        }
        private void PrevQuestionBtn_Click(object sender, RoutedEventArgs e)
        {
            currentQuestion = Setup.Questions.First(q => q.Id == currentQuestion.Id - 1);
            if (0 == currentQuestion.Id - 1)
            {
                PrevQuestionBtn.Visibility = Visibility.Hidden;
            }
            else
                NextQuestionBtn.Visibility = Visibility.Visible;
            ShowCurrentQuestion(currentQuestion);
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

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
