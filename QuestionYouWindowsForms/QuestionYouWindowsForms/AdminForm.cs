using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuestionYouWindowsForms
{
    public partial class AdminForm : Form
    {
        QuestionSetup Setup = new QuestionSetup();
        public AdminForm()
        {
            InitializeComponent();
            SelectQuestions();
        }
        private void CreateButton_Click(object sender, EventArgs e)
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
        public void SelectQuestions()
        {
            QuestionsGridViewer.DataSource = Setup.GetQuestions();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (QuestionsGridViewer.SelectedRows.Count > 0)
            {
                var question = QuestionsGridViewer.SelectedRows[0].DataBoundItem as Question;
                Setup.Questions.Remove(question);
                Setup.SetQuestions(ChangeIds(Setup.Questions));
                SelectQuestions();
            }
        }
        private List<Question> ChangeIds(List<Question> questions)
        {
            int i = 1;
            foreach (var question in questions)
            {
                question.Id = i++;
            }
            return questions;
        }
        private void EndButton_Click(object sender, EventArgs e)
        {
            Setup.SetQuestions(ChangeIds(Setup.Questions));
            var main = new LoginForm();
            main.Show();
            Close();
        }
    }
}
