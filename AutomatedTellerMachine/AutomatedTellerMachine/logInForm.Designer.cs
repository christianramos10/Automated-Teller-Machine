namespace AutomatedTellerMachine
{
    partial class logInForm
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
            this.windowBox = new System.Windows.Forms.GroupBox();
            this.pinNumber_textBox = new System.Windows.Forms.TextBox();
            this.accNumber_textBox = new System.Windows.Forms.TextBox();
            this.pinNumber_label = new System.Windows.Forms.Label();
            this.accNumber_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.GroupBox();
            this.enter_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.backspace_button = new System.Windows.Forms.Button();
            this.zero_button = new System.Windows.Forms.Button();
            this.three_button = new System.Windows.Forms.Button();
            this.two_button = new System.Windows.Forms.Button();
            this.one_button = new System.Windows.Forms.Button();
            this.six_button = new System.Windows.Forms.Button();
            this.five_button = new System.Windows.Forms.Button();
            this.four_button = new System.Windows.Forms.Button();
            this.nine_button = new System.Windows.Forms.Button();
            this.eight_button = new System.Windows.Forms.Button();
            this.seven_button = new System.Windows.Forms.Button();
            this.cashBox = new System.Windows.Forms.GroupBox();
            this.windowBox.SuspendLayout();
            this.inputBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowBox
            // 
            this.windowBox.Controls.Add(this.pinNumber_textBox);
            this.windowBox.Controls.Add(this.accNumber_textBox);
            this.windowBox.Controls.Add(this.pinNumber_label);
            this.windowBox.Controls.Add(this.accNumber_label);
            this.windowBox.Controls.Add(this.welcome_label);
            this.windowBox.Location = new System.Drawing.Point(161, 12);
            this.windowBox.Name = "windowBox";
            this.windowBox.Size = new System.Drawing.Size(412, 204);
            this.windowBox.TabIndex = 0;
            this.windowBox.TabStop = false;
            // 
            // pinNumber_textBox
            // 
            this.pinNumber_textBox.Location = new System.Drawing.Point(143, 125);
            this.pinNumber_textBox.Name = "pinNumber_textBox";
            this.pinNumber_textBox.Size = new System.Drawing.Size(100, 20);
            this.pinNumber_textBox.TabIndex = 1;
            // 
            // accNumber_textBox
            // 
            this.accNumber_textBox.Location = new System.Drawing.Point(296, 83);
            this.accNumber_textBox.Name = "accNumber_textBox";
            this.accNumber_textBox.Size = new System.Drawing.Size(100, 20);
            this.accNumber_textBox.TabIndex = 0;
            // 
            // pinNumber_label
            // 
            this.pinNumber_label.AutoSize = true;
            this.pinNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinNumber_label.Location = new System.Drawing.Point(6, 125);
            this.pinNumber_label.Name = "pinNumber_label";
            this.pinNumber_label.Size = new System.Drawing.Size(131, 20);
            this.pinNumber_label.TabIndex = 5;
            this.pinNumber_label.Text = "Enter your pin: ";
            // 
            // accNumber_label
            // 
            this.accNumber_label.AutoSize = true;
            this.accNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNumber_label.Location = new System.Drawing.Point(6, 81);
            this.accNumber_label.Name = "accNumber_label";
            this.accNumber_label.Size = new System.Drawing.Size(293, 20);
            this.accNumber_label.TabIndex = 4;
            this.accNumber_label.Text = "Please enter your account number: ";
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.Location = new System.Drawing.Point(143, 16);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(153, 33);
            this.welcome_label.TabIndex = 3;
            this.welcome_label.Text = "Welcome!";
            // 
            // inputBox
            // 
            this.inputBox.Controls.Add(this.enter_button);
            this.inputBox.Controls.Add(this.cancel_button);
            this.inputBox.Controls.Add(this.clear_button);
            this.inputBox.Controls.Add(this.backspace_button);
            this.inputBox.Controls.Add(this.zero_button);
            this.inputBox.Controls.Add(this.three_button);
            this.inputBox.Controls.Add(this.two_button);
            this.inputBox.Controls.Add(this.one_button);
            this.inputBox.Controls.Add(this.six_button);
            this.inputBox.Controls.Add(this.five_button);
            this.inputBox.Controls.Add(this.four_button);
            this.inputBox.Controls.Add(this.nine_button);
            this.inputBox.Controls.Add(this.eight_button);
            this.inputBox.Controls.Add(this.seven_button);
            this.inputBox.Location = new System.Drawing.Point(12, 222);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(353, 269);
            this.inputBox.TabIndex = 1;
            this.inputBox.TabStop = false;
            // 
            // enter_button
            // 
            this.enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_button.Location = new System.Drawing.Point(249, 141);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(98, 116);
            this.enter_button.TabIndex = 14;
            this.enter_button.Text = "Enter";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(249, 19);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(98, 116);
            this.cancel_button.TabIndex = 12;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(168, 202);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 55);
            this.clear_button.TabIndex = 11;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // backspace_button
            // 
            this.backspace_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace_button.Location = new System.Drawing.Point(87, 202);
            this.backspace_button.Name = "backspace_button";
            this.backspace_button.Size = new System.Drawing.Size(75, 55);
            this.backspace_button.TabIndex = 10;
            this.backspace_button.Text = "←";
            this.backspace_button.UseVisualStyleBackColor = true;
            this.backspace_button.Click += new System.EventHandler(this.backspace_button_Click);
            // 
            // zero_button
            // 
            this.zero_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero_button.Location = new System.Drawing.Point(6, 202);
            this.zero_button.Name = "zero_button";
            this.zero_button.Size = new System.Drawing.Size(75, 55);
            this.zero_button.TabIndex = 9;
            this.zero_button.Text = "0";
            this.zero_button.UseVisualStyleBackColor = true;
            this.zero_button.Click += new System.EventHandler(this.num_Clicked);
            // 
            // three_button
            // 
            this.three_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three_button.Location = new System.Drawing.Point(168, 141);
            this.three_button.Name = "three_button";
            this.three_button.Size = new System.Drawing.Size(75, 55);
            this.three_button.TabIndex = 8;
            this.three_button.Text = "3";
            this.three_button.UseVisualStyleBackColor = true;
            this.three_button.Click += new System.EventHandler(this.num_Clicked);
            // 
            // two_button
            // 
            this.two_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two_button.Location = new System.Drawing.Point(87, 141);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(75, 55);
            this.two_button.TabIndex = 7;
            this.two_button.Text = "2";
            this.two_button.UseVisualStyleBackColor = true;
            this.two_button.Click += new System.EventHandler(this.num_Clicked);
            // 
            // one_button
            // 
            this.one_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one_button.Location = new System.Drawing.Point(6, 141);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(75, 55);
            this.one_button.TabIndex = 6;
            this.one_button.Text = "1";
            this.one_button.UseVisualStyleBackColor = true;
            this.one_button.Click += new System.EventHandler(this.num_Clicked);
            // 
            // six_button
            // 
            this.six_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six_button.Location = new System.Drawing.Point(168, 80);
            this.six_button.Name = "six_button";
            this.six_button.Size = new System.Drawing.Size(75, 55);
            this.six_button.TabIndex = 5;
            this.six_button.Text = "6";
            this.six_button.UseVisualStyleBackColor = true;
            this.six_button.Click += new System.EventHandler(this.num_Clicked);
            // 
            // five_button
            // 
            this.five_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five_button.Location = new System.Drawing.Point(87, 80);
            this.five_button.Name = "five_button";
            this.five_button.Size = new System.Drawing.Size(75, 55);
            this.five_button.TabIndex = 4;
            this.five_button.Text = "5";
            this.five_button.UseVisualStyleBackColor = true;
            this.five_button.Click += new System.EventHandler(this.num_Clicked);
            // 
            // four_button
            // 
            this.four_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four_button.Location = new System.Drawing.Point(6, 80);
            this.four_button.Name = "four_button";
            this.four_button.Size = new System.Drawing.Size(75, 55);
            this.four_button.TabIndex = 3;
            this.four_button.Text = "4";
            this.four_button.UseVisualStyleBackColor = true;
            this.four_button.Click += new System.EventHandler(this.num_Clicked);
            // 
            // nine_button
            // 
            this.nine_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine_button.Location = new System.Drawing.Point(168, 19);
            this.nine_button.Name = "nine_button";
            this.nine_button.Size = new System.Drawing.Size(75, 55);
            this.nine_button.TabIndex = 2;
            this.nine_button.Text = "9";
            this.nine_button.UseVisualStyleBackColor = true;
            this.nine_button.Click += new System.EventHandler(this.num_Clicked);
            // 
            // eight_button
            // 
            this.eight_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight_button.Location = new System.Drawing.Point(87, 19);
            this.eight_button.Name = "eight_button";
            this.eight_button.Size = new System.Drawing.Size(75, 55);
            this.eight_button.TabIndex = 1;
            this.eight_button.Text = "8";
            this.eight_button.UseVisualStyleBackColor = true;
            this.eight_button.Click += new System.EventHandler(this.num_Clicked);
            // 
            // seven_button
            // 
            this.seven_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven_button.Location = new System.Drawing.Point(6, 19);
            this.seven_button.Name = "seven_button";
            this.seven_button.Size = new System.Drawing.Size(75, 55);
            this.seven_button.TabIndex = 0;
            this.seven_button.Text = "7";
            this.seven_button.UseVisualStyleBackColor = true;
            this.seven_button.Click += new System.EventHandler(this.num_Clicked);
            // 
            // cashBox
            // 
            this.cashBox.Location = new System.Drawing.Point(371, 222);
            this.cashBox.Name = "cashBox";
            this.cashBox.Size = new System.Drawing.Size(417, 269);
            this.cashBox.TabIndex = 2;
            this.cashBox.TabStop = false;
            // 
            // logInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.cashBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.windowBox);
            this.Name = "logInForm";
            this.Text = "ATM";
            this.windowBox.ResumeLayout(false);
            this.windowBox.PerformLayout();
            this.inputBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox windowBox;
        private System.Windows.Forms.GroupBox inputBox;
        private System.Windows.Forms.GroupBox cashBox;
        private System.Windows.Forms.Button nine_button;
        private System.Windows.Forms.Button eight_button;
        private System.Windows.Forms.Button seven_button;
        private System.Windows.Forms.Button backspace_button;
        private System.Windows.Forms.Button zero_button;
        private System.Windows.Forms.Button three_button;
        private System.Windows.Forms.Button two_button;
        private System.Windows.Forms.Button one_button;
        private System.Windows.Forms.Button six_button;
        private System.Windows.Forms.Button five_button;
        private System.Windows.Forms.Button four_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox pinNumber_textBox;
        private System.Windows.Forms.TextBox accNumber_textBox;
        private System.Windows.Forms.Label pinNumber_label;
        private System.Windows.Forms.Label accNumber_label;
        private System.Windows.Forms.Label welcome_label;
    }
}

