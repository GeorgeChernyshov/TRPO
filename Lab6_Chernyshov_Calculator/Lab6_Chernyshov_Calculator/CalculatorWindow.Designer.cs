namespace Calculator
{
    partial class CalculatorWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ioDisplay = new System.Windows.Forms.Label();
            this.operationDisplay = new System.Windows.Forms.Label();
            this.bufferDisplay = new System.Windows.Forms.Label();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.delimeterButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ioDisplay
            // 
            this.ioDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ioDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.ioDisplay.Location = new System.Drawing.Point(46, 46);
            this.ioDisplay.Name = "ioDisplay";
            this.ioDisplay.Size = new System.Drawing.Size(226, 35);
            this.ioDisplay.TabIndex = 0;
            this.ioDisplay.Text = "8000000000000000";
            this.ioDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // operationDisplay
            // 
            this.operationDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.operationDisplay.Location = new System.Drawing.Point(12, 45);
            this.operationDisplay.Name = "operationDisplay";
            this.operationDisplay.Size = new System.Drawing.Size(28, 36);
            this.operationDisplay.TabIndex = 1;
            this.operationDisplay.Text = "+";
            this.operationDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bufferDisplay
            // 
            this.bufferDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bufferDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.bufferDisplay.Location = new System.Drawing.Point(46, 9);
            this.bufferDisplay.Name = "bufferDisplay";
            this.bufferDisplay.Size = new System.Drawing.Size(226, 35);
            this.bufferDisplay.TabIndex = 2;
            this.bufferDisplay.Text = "8000000000000000";
            this.bufferDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sevenButton
            // 
            this.sevenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.sevenButton.Location = new System.Drawing.Point(12, 84);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(61, 49);
            this.sevenButton.TabIndex = 3;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.eightButton.Location = new System.Drawing.Point(79, 84);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(61, 49);
            this.eightButton.TabIndex = 4;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nineButton.Location = new System.Drawing.Point(146, 84);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(61, 49);
            this.nineButton.TabIndex = 5;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusButton.Location = new System.Drawing.Point(213, 84);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(61, 49);
            this.plusButton.TabIndex = 6;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.fourButton.Location = new System.Drawing.Point(12, 139);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(61, 49);
            this.fourButton.TabIndex = 7;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.fiveButton.Location = new System.Drawing.Point(79, 139);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(61, 49);
            this.fiveButton.TabIndex = 8;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.sixButton.Location = new System.Drawing.Point(146, 139);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(61, 49);
            this.sixButton.TabIndex = 9;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusButton.Location = new System.Drawing.Point(213, 139);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(59, 49);
            this.minusButton.TabIndex = 10;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.oneButton.Location = new System.Drawing.Point(12, 194);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(61, 49);
            this.oneButton.TabIndex = 11;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.twoButton.Location = new System.Drawing.Point(79, 194);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(61, 49);
            this.twoButton.TabIndex = 12;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.threeButton.Location = new System.Drawing.Point(146, 194);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(61, 49);
            this.threeButton.TabIndex = 13;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.multiplyButton.Location = new System.Drawing.Point(213, 194);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(61, 49);
            this.multiplyButton.TabIndex = 14;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eraseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.eraseButton.Location = new System.Drawing.Point(12, 249);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(61, 49);
            this.eraseButton.TabIndex = 15;
            this.eraseButton.Text = "CE";
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.EraseButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.zeroButton.Location = new System.Drawing.Point(79, 249);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(61, 49);
            this.zeroButton.TabIndex = 16;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // delimeterButton
            // 
            this.delimeterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delimeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.delimeterButton.Location = new System.Drawing.Point(146, 249);
            this.delimeterButton.Name = "delimeterButton";
            this.delimeterButton.Size = new System.Drawing.Size(61, 49);
            this.delimeterButton.TabIndex = 17;
            this.delimeterButton.Text = ".";
            this.delimeterButton.UseVisualStyleBackColor = true;
            this.delimeterButton.Click += new System.EventHandler(this.DelimeterButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.divideButton.Location = new System.Drawing.Point(213, 249);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(61, 49);
            this.divideButton.TabIndex = 18;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.equalsButton.Location = new System.Drawing.Point(12, 304);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(262, 49);
            this.equalsButton.TabIndex = 19;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // CalculatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.delimeterButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.bufferDisplay);
            this.Controls.Add(this.operationDisplay);
            this.Controls.Add(this.ioDisplay);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "CalculatorWindow";
            this.Text = "Калькулятор";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorWindow_KeyPress);
            this.Resize += new System.EventHandler(this.CalculatorWindow_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ioDisplay;
        private System.Windows.Forms.Label operationDisplay;
        private System.Windows.Forms.Label bufferDisplay;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button delimeterButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button equalsButton;
    }
}

