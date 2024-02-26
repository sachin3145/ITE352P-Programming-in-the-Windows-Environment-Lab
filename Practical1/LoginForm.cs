using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical1
{
    public partial class LoginForm : Form
    {
        private string userId, password;
        public LoginForm()
        {
            InitializeComponent();
            userId = "batman";
            password = "password";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userId == userIDText.Text && password == passwordText.Text)
            {
                this.Hide();
                CalculatorForm calculatorForm = new CalculatorForm();
                calculatorForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show($"Incorrect Credentials\nUse Reset Button to set entered text as credentials.");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            userId = userIDText.Text;
            password = passwordText.Text;
            MessageBox.Show("Credentials reset successful\nPlease click LOGIN to continue.");
        }
    }
}
