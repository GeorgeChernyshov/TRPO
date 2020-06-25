namespace BrownianMotionSimulation
{
    partial class BrownianMotionForm
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
            this.simulationPanel = new System.Windows.Forms.Panel();
            this.moleculeNumberLabel = new System.Windows.Forms.Label();
            this.moleculeNumberTrack = new System.Windows.Forms.TrackBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedTrack = new System.Windows.Forms.TrackBar();
            this.repaintTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.moleculeNumberTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // simulationPanel
            // 
            this.simulationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simulationPanel.BackColor = System.Drawing.Color.White;
            this.simulationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.simulationPanel.Location = new System.Drawing.Point(12, 12);
            this.simulationPanel.Name = "simulationPanel";
            this.simulationPanel.Size = new System.Drawing.Size(600, 600);
            this.simulationPanel.TabIndex = 0;
            this.simulationPanel.SizeChanged += new System.EventHandler(this.simulationPanel_SizeChanged);
            this.simulationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.simulationPanel_Paint);
            // 
            // moleculeNumberLabel
            // 
            this.moleculeNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moleculeNumberLabel.AutoSize = true;
            this.moleculeNumberLabel.Location = new System.Drawing.Point(12, 626);
            this.moleculeNumberLabel.Name = "moleculeNumberLabel";
            this.moleculeNumberLabel.Size = new System.Drawing.Size(112, 13);
            this.moleculeNumberLabel.TabIndex = 1;
            this.moleculeNumberLabel.Text = "Количество молекул";
            // 
            // moleculeNumberTrack
            // 
            this.moleculeNumberTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moleculeNumberTrack.Location = new System.Drawing.Point(130, 618);
            this.moleculeNumberTrack.Maximum = 50;
            this.moleculeNumberTrack.Name = "moleculeNumberTrack";
            this.moleculeNumberTrack.Size = new System.Drawing.Size(178, 45);
            this.moleculeNumberTrack.TabIndex = 2;
            this.moleculeNumberTrack.TickFrequency = 5;
            this.moleculeNumberTrack.Value = 1;
            this.moleculeNumberTrack.Scroll += new System.EventHandler(this.moleculeNumberTrack_Scroll);
            // 
            // speedLabel
            // 
            this.speedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(373, 626);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(55, 13);
            this.speedLabel.TabIndex = 3;
            this.speedLabel.Text = "Скорость";
            // 
            // speedTrack
            // 
            this.speedTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speedTrack.Location = new System.Drawing.Point(434, 618);
            this.speedTrack.Maximum = 25;
            this.speedTrack.Name = "speedTrack";
            this.speedTrack.Size = new System.Drawing.Size(178, 45);
            this.speedTrack.TabIndex = 4;
            this.speedTrack.TickFrequency = 5;
            this.speedTrack.Value = 5;
            this.speedTrack.Scroll += new System.EventHandler(this.speedTrack_Scroll);
            // 
            // repaintTimer
            // 
            this.repaintTimer.Interval = 15;
            this.repaintTimer.Tick += new System.EventHandler(this.repaintTimer_Tick);
            // 
            // BrownianMotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 671);
            this.Controls.Add(this.speedTrack);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.moleculeNumberTrack);
            this.Controls.Add(this.moleculeNumberLabel);
            this.Controls.Add(this.simulationPanel);
            this.MinimumSize = new System.Drawing.Size(640, 710);
            this.Name = "BrownianMotionForm";
            this.Text = "Броуновское движение";
            this.Load += new System.EventHandler(this.BrownianMotionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moleculeNumberTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel simulationPanel;
        private System.Windows.Forms.Label moleculeNumberLabel;
        private System.Windows.Forms.TrackBar moleculeNumberTrack;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TrackBar speedTrack;
        private System.Windows.Forms.Timer repaintTimer;
    }
}

