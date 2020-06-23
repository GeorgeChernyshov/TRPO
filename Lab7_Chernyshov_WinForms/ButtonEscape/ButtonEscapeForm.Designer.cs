namespace ButtonEscape
{
    partial class ButtonEscapeForm
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
            this.winButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winButton
            // 
            this.winButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.winButton.Location = new System.Drawing.Point(232, 173);
            this.winButton.Margin = new System.Windows.Forms.Padding(0);
            this.winButton.Name = "winButton";
            this.winButton.Size = new System.Drawing.Size(120, 40);
            this.winButton.TabIndex = 0;
            this.winButton.Text = "Push me";
            this.winButton.UseVisualStyleBackColor = true;
            this.winButton.Click += new System.EventHandler(this.WinButton_Click);
            // 
            // ButtonEscapeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.winButton);
            this.MinimumSize = new System.Drawing.Size(120, 80);
            this.Name = "ButtonEscapeForm";
            this.Text = "Убегающая кнопка";
            this.Load += new System.EventHandler(this.ButtonEscapeForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonEscapeForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button winButton;
    }
}

