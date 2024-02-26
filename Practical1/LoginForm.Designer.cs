namespace Practical1
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userIDLabel = new Label();
            userIDText = new TextBox();
            passwordText = new TextBox();
            passwordLabel = new Label();
            resetButton = new Button();
            loginButton = new Button();
            SuspendLayout();
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new Point(205, 155);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new Size(100, 38);
            userIDLabel.TabIndex = 0;
            userIDLabel.Text = "UserID";
            // 
            // userIDText
            // 
            userIDText.Location = new Point(352, 155);
            userIDText.Name = "userIDText";
            userIDText.Size = new Size(443, 45);
            userIDText.TabIndex = 1;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(352, 215);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(443, 45);
            passwordText.TabIndex = 2;
            passwordText.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(205, 222);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(132, 38);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // resetButton
            // 
            resetButton.Location = new Point(205, 352);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(256, 80);
            resetButton.TabIndex = 4;
            resetButton.Text = "RESET";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(539, 352);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(256, 80);
            loginButton.TabIndex = 3;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 584);
            Controls.Add(loginButton);
            Controls.Add(resetButton);
            Controls.Add(passwordText);
            Controls.Add(passwordLabel);
            Controls.Add(userIDText);
            Controls.Add(userIDLabel);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userIDLabel;
        private TextBox userIDText;
        private TextBox passwordText;
        private Label passwordLabel;
        private Button resetButton;
        private Button loginButton;
    }
}