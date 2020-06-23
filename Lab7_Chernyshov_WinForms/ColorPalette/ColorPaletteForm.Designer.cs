namespace ColorPalette
{
    partial class ColorPaletteForm
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
            this.components = new System.ComponentModel.Container();
            this.redBar = new System.Windows.Forms.TrackBar();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenBar = new System.Windows.Forms.TrackBar();
            this.blueBar = new System.Windows.Forms.TrackBar();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.colorTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).BeginInit();
            this.SuspendLayout();
            // 
            // redBar
            // 
            this.redBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.redBar.Location = new System.Drawing.Point(211, 12);
            this.redBar.Margin = new System.Windows.Forms.Padding(0);
            this.redBar.Maximum = 255;
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(161, 45);
            this.redBar.TabIndex = 1;
            this.redBar.Value = 125;
            this.redBar.Scroll += new System.EventHandler(this.redBar_Scroll);
            // 
            // redLabel
            // 
            this.redLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(178, 12);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(30, 13);
            this.redLabel.TabIndex = 2;
            this.redLabel.Text = "Red:";
            // 
            // greenBar
            // 
            this.greenBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.greenBar.Location = new System.Drawing.Point(211, 57);
            this.greenBar.Margin = new System.Windows.Forms.Padding(0);
            this.greenBar.Maximum = 255;
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(161, 45);
            this.greenBar.TabIndex = 3;
            this.greenBar.Value = 125;
            this.greenBar.Scroll += new System.EventHandler(this.greenBar_Scroll);
            // 
            // blueBar
            // 
            this.blueBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.blueBar.Location = new System.Drawing.Point(211, 102);
            this.blueBar.Margin = new System.Windows.Forms.Padding(0);
            this.blueBar.Maximum = 255;
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(161, 45);
            this.blueBar.TabIndex = 4;
            this.blueBar.Value = 125;
            this.blueBar.Scroll += new System.EventHandler(this.blueBar_Scroll);
            // 
            // greenLabel
            // 
            this.greenLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(178, 57);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(39, 13);
            this.greenLabel.TabIndex = 5;
            this.greenLabel.Text = "Green:";
            // 
            // blueLabel
            // 
            this.blueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(178, 102);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(31, 13);
            this.blueLabel.TabIndex = 6;
            this.blueLabel.Text = "Blue:";
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(12, 12);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(137, 137);
            this.colorPanel.TabIndex = 7;
            // 
            // ColorPaletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.blueBar);
            this.Controls.Add(this.greenBar);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.redBar);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "ColorPaletteForm";
            this.Text = "Цветовая палитра";
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar redBar;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.TrackBar greenBar;
        private System.Windows.Forms.TrackBar blueBar;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.ToolTip colorTooltip;
    }
}

