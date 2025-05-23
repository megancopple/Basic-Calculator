namespace Basic_Calculator
{
    partial class BasicCalculatorForm
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
            lblOperand1 = new Label();
            lblOperator = new Label();
            lblOperand2 = new Label();
            lblResult = new Label();
            CalculateButton = new Button();
            ExitButton = new Button();
            txtOperand2 = new TextBox();
            txtOperand1 = new TextBox();
            txtOperator = new TextBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // lblOperand1
            // 
            lblOperand1.AutoSize = true;
            lblOperand1.Location = new Point(35, 35);
            lblOperand1.Name = "lblOperand1";
            lblOperand1.Size = new Size(65, 15);
            lblOperand1.TabIndex = 0;
            lblOperand1.Text = "Operand 1:";
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Location = new Point(35, 70);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(57, 15);
            lblOperator.TabIndex = 1;
            lblOperator.Text = "Operator:";
            // 
            // lblOperand2
            // 
            lblOperand2.AutoSize = true;
            lblOperand2.Location = new Point(35, 104);
            lblOperand2.Name = "lblOperand2";
            lblOperand2.Size = new Size(65, 15);
            lblOperand2.TabIndex = 2;
            lblOperand2.Text = "Operand 2:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(35, 140);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result:";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(35, 191);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(75, 23);
            CalculateButton.TabIndex = 4;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(138, 191);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // txtOperand2
            // 
            txtOperand2.Location = new Point(113, 101);
            txtOperand2.Name = "txtOperand2";
            txtOperand2.Size = new Size(100, 23);
            txtOperand2.TabIndex = 6;
            // 
            // txtOperand1
            // 
            txtOperand1.Location = new Point(113, 35);
            txtOperand1.Name = "txtOperand1";
            txtOperand1.Size = new Size(100, 23);
            txtOperand1.TabIndex = 7;
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(113, 67);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(100, 23);
            txtOperator.TabIndex = 8;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(113, 140);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 9;
            // 
            // BasicCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 226);
            Controls.Add(txtResult);
            Controls.Add(txtOperator);
            Controls.Add(txtOperand1);
            Controls.Add(txtOperand2);
            Controls.Add(ExitButton);
            Controls.Add(CalculateButton);
            Controls.Add(lblResult);
            Controls.Add(lblOperand2);
            Controls.Add(lblOperator);
            Controls.Add(lblOperand1);
            Name = "BasicCalculatorForm";
            Text = "Basic Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOperand1;
        private Label lblOperator;
        private Label lblOperand2;
        private Label lblResult;
        private Button CalculateButton;
        private Button ExitButton;
        private TextBox txtOperand2;
        private TextBox txtOperand1;
        private TextBox txtOperator;
        private TextBox txtResult;
    }
}
