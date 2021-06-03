using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuestionYou
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        QuestionSetup Setup = new QuestionSetup();

        public AdminWindow()
        {
            InitializeComponent();
            SelectQuestions();
        }
        public void SelectQuestions()
        {
            Questions.ItemsSource = Setup.GetQuestions();
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            var value = QuestionTextBox.Text;
            var question = new Question
            {
                Id = Setup.Questions.Count + 1,
                Value = value
            };
            Setup.Questions.Add(question);
            Setup.SetQuestions(Setup.Questions);
            SelectQuestions();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var question = Questions.SelectedItem as Question;
            Setup.Questions.Remove(question);
            Setup.SetQuestions(ChangeIds(Setup.Questions));
            SelectQuestions();
        }
        private List<Question> ChangeIds(List<Question> questions)
        {
            int i = 1;
            foreach(var question in questions)
            {
                question.Id = i++;
            }
            return questions;
        }
        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            Setup.SetQuestions(ChangeIds(Setup.Questions));
            var main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
