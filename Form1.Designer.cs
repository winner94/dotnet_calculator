namespace Calculator
{
    partial class Form1
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
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButtno = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.SlashButton = new System.Windows.Forms.Button();
            this.MultipleButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(12, 12);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.ReadOnly = true;
            this.SumTextBox.Size = new System.Drawing.Size(158, 20);
            this.SumTextBox.TabIndex = 0;
            this.SumTextBox.Text = "0";
            this.SumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SevenButton
            // 
            this.SevenButton.Location = new System.Drawing.Point(12, 38);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(35, 35);
            this.SevenButton.TabIndex = 1;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // EightButtno
            // 
            this.EightButtno.Location = new System.Drawing.Point(53, 38);
            this.EightButtno.Name = "EightButtno";
            this.EightButtno.Size = new System.Drawing.Size(35, 35);
            this.EightButtno.TabIndex = 2;
            this.EightButtno.Text = "8";
            this.EightButtno.UseVisualStyleBackColor = true;
            this.EightButtno.Click += new System.EventHandler(this.EightButtno_Click);
            // 
            // NineButton
            // 
            this.NineButton.Location = new System.Drawing.Point(94, 38);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(35, 35);
            this.NineButton.TabIndex = 3;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // SlashButton
            // 
            this.SlashButton.Location = new System.Drawing.Point(135, 38);
            this.SlashButton.Name = "SlashButton";
            this.SlashButton.Size = new System.Drawing.Size(35, 35);
            this.SlashButton.TabIndex = 4;
            this.SlashButton.Text = "/";
            this.SlashButton.UseVisualStyleBackColor = true;
            this.SlashButton.Click += new System.EventHandler(this.SlashButton_Click);
            // 
            // MultipleButton
            // 
            this.MultipleButton.Location = new System.Drawing.Point(135, 79);
            this.MultipleButton.Name = "MultipleButton";
            this.MultipleButton.Size = new System.Drawing.Size(35, 35);
            this.MultipleButton.TabIndex = 8;
            this.MultipleButton.Text = "*";
            this.MultipleButton.UseVisualStyleBackColor = true;
            this.MultipleButton.Click += new System.EventHandler(this.MultipleButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Location = new System.Drawing.Point(94, 79);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(35, 35);
            this.SixButton.TabIndex = 7;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Location = new System.Drawing.Point(53, 79);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(35, 35);
            this.FiveButton.TabIndex = 6;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Location = new System.Drawing.Point(12, 79);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(35, 35);
            this.FourButton.TabIndex = 5;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(135, 161);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(35, 35);
            this.PlusButton.TabIndex = 16;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Location = new System.Drawing.Point(94, 161);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(35, 35);
            this.EqualButton.TabIndex = 15;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // CButton
            // 
            this.CButton.Location = new System.Drawing.Point(53, 161);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(35, 35);
            this.CButton.TabIndex = 14;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(12, 161);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(35, 35);
            this.ZeroButton.TabIndex = 13;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(135, 120);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(35, 35);
            this.MinusButton.TabIndex = 12;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Location = new System.Drawing.Point(94, 120);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(35, 35);
            this.ThreeButton.TabIndex = 11;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Location = new System.Drawing.Point(53, 120);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(35, 35);
            this.TwoButton.TabIndex = 10;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(12, 120);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(35, 35);
            this.OneButton.TabIndex = 9;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 206);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.MultipleButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.SlashButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButtno);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.SumTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButtno;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button SlashButton;
        private System.Windows.Forms.Button MultipleButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
    }
}

