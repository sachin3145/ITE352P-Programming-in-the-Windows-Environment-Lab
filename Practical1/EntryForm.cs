namespace Practical1
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            displayMessageLabel.Text = $"I'm Vengeance 🦇";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            displayMessageLabel.Text = $"Why So Serious? 🤡";
        }
    }
}
