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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            if (IsAdmin.Checked)
            {
                var admin = new AdminForm();
                admin.Show();
                return;
            }
            var user = new UserForm();
            user.Show();
        }
    }
}
