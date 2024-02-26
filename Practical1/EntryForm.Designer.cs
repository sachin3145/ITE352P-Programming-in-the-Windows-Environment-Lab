namespace Practical1
{
    partial class EntryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            displayMessageLabel = new Label();
            setButton = new Button();
            cancelButton = new Button();
            loginButton = new Button();
            SuspendLayout();
            // 
            // displayMessageLabel
            // 
            displayMessageLabel.AutoSize = true;
            displayMessageLabel.Location = new Point(163, 148);
            displayMessageLabel.Name = "displayMessageLabel";
            displayMessageLabel.Size = new Size(317, 38);
            displayMessageLabel.TabIndex = 0;
            displayMessageLabel.Text = "WAITING FOR INPUT . . .";
            // 
            // setButton
            // 
            setButton.Location = new Point(163, 350);
            setButton.Name = "setButton";
            setButton.Size = new Size(192, 80);
            setButton.TabIndex = 1;
            setButton.Text = "SET";
            setButton.UseVisualStyleBackColor = true;
            setButton.Click += setButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(419, 350);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(192, 80);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(675, 350);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(192, 80);
            loginButton.TabIndex = 3;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 584);
            Controls.Add(loginButton);
            Controls.Add(cancelButton);
            Controls.Add(setButton);
            Controls.Add(displayMessageLabel);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EntryForm";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label displayMessageLabel;
        private Button setButton;
        private Button cancelButton;
        private Button loginButton;
    }
}
