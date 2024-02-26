namespace Practical1
{
    partial class CalculatorForm
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
            operationLabel = new Label();
            num1Text = new TextBox();
            num2Text = new TextBox();
            equalToLabel = new Label();
            ResultLabel = new Label();
            addButton = new Button();
            subtractButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            squareButton = new Button();
            SuspendLayout();
            // 
            // operationLabel
            // 
            operationLabel.AutoSize = true;
            operationLabel.Location = new Point(269, 121);
            operationLabel.Name = "operationLabel";
            operationLabel.Size = new Size(0, 38);
            operationLabel.TabIndex = 0;
            // 
            // num1Text
            // 
            num1Text.Location = new Point(45, 118);
            num1Text.Name = "num1Text";
            num1Text.Size = new Size(214, 45);
            num1Text.TabIndex = 1;
            num1Text.Text = "first number";
            // 
            // num2Text
            // 
            num2Text.Location = new Point(315, 118);
            num2Text.Name = "num2Text";
            num2Text.Size = new Size(243, 45);
            num2Text.TabIndex = 3;
            num2Text.Text = "second number";
            // 
            // equalToLabel
            // 
            equalToLabel.AutoSize = true;
            equalToLabel.Location = new Point(581, 121);
            equalToLabel.Name = "equalToLabel";
            equalToLabel.Size = new Size(36, 38);
            equalToLabel.TabIndex = 2;
            equalToLabel.Text = "=";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(634, 121);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(0, 38);
            ResultLabel.TabIndex = 4;
            // 
            // addButton
            // 
            addButton.Location = new Point(45, 231);
            addButton.Name = "addButton";
            addButton.Size = new Size(214, 67);
            addButton.TabIndex = 5;
            addButton.Text = "SUM";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(315, 231);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(243, 67);
            subtractButton.TabIndex = 6;
            subtractButton.Text = "DIFFERENCE";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += subtractButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(45, 333);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(214, 67);
            multiplyButton.TabIndex = 7;
            multiplyButton.Text = "PRODUCT";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(315, 333);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(243, 67);
            divideButton.TabIndex = 8;
            divideButton.Text = "QUOTIENT";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // squareButton
            // 
            squareButton.Location = new Point(45, 426);
            squareButton.Name = "squareButton";
            squareButton.Size = new Size(513, 67);
            squareButton.TabIndex = 9;
            squareButton.Text = "SQUARE FIRST NUMBER";
            squareButton.UseVisualStyleBackColor = true;
            squareButton.Click += squareButton_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 584);
            Controls.Add(squareButton);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            Controls.Add(ResultLabel);
            Controls.Add(num2Text);
            Controls.Add(equalToLabel);
            Controls.Add(num1Text);
            Controls.Add(operationLabel);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CalculatorForm";
            Text = "Integer Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label operationLabel;
        private TextBox num1Text;
        private TextBox num2Text;
        private Label equalToLabel;
        private Label ResultLabel;
        private Button addButton;
        private Button subtractButton;
        private Button multiplyButton;
        private Button divideButton;
        private Button squareButton;
    }
}