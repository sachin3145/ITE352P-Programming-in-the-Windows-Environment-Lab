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
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            long  num1, num2;
            if (long .TryParse(num1Text.Text, out num1) && long .TryParse(num2Text.Text, out num2))
            {
                operationLabel.Text = "+";
                ResultLabel.Text = (num1 + num2).ToString();
            }
            else
            {
                MessageBox.Show("Could not parse numbers!\nPlease ensure data entered is numeric and in resonable range.");
            }

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            long  num1, num2;
            if (long .TryParse(num1Text.Text, out num1) && long .TryParse(num2Text.Text, out num2))
            {
                operationLabel.Text = "-";
                ResultLabel.Text = (num1 - num2).ToString();
            }
            else
            {
                MessageBox.Show("Could not parse numbers!\nPlease ensure data entered is numeric and in resonable range.");
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            long  num1, num2;
            if (long .TryParse(num1Text.Text, out num1) && long .TryParse(num2Text.Text, out num2))
            {
                operationLabel.Text = "*";
                ResultLabel.Text = (num1 * num2).ToString();
            }
            else
            {
                MessageBox.Show("Could not parse numbers!\nPlease ensure data entered is numeric and in resonable range.");
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            long  num1, num2;
            if (long .TryParse(num1Text.Text, out num1) && long .TryParse(num2Text.Text, out num2))
            {
                operationLabel.Text = "/";
                ResultLabel.Text = (num1 / num2).ToString();
            }
            else
            {
                MessageBox.Show("Could not parse numbers!\nPlease ensure data entered is numeric and in resonable range.");
            }
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            long  num1;
            if (long .TryParse(num1Text.Text, out num1))
            {
                
                MessageBox.Show($"{num1} squared is {(num1 * num1).ToString()}.");
            }
            else
            {
                MessageBox.Show("Could not parse first number!\nPlease ensure data entered is numeric and in resonable range.");
            }
        }
    }
}
