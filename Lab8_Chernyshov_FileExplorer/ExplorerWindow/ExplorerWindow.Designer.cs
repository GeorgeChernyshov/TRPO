namespace ExplorerWindow
{
    partial class ExplorerWindow
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
            this.filesDG = new System.Windows.Forms.DataGridView();
            this.catalogLabel = new System.Windows.Forms.Label();
            this.catalogSearchBox = new System.Windows.Forms.TextBox();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.creationDateBox = new System.Windows.Forms.TextBox();
            this.deleteBox = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.source = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.filesDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.source)).BeginInit();
            this.SuspendLayout();
            // 
            // filesDG
            // 
            this.filesDG.AllowUserToAddRows = false;
            this.filesDG.AllowUserToDeleteRows = false;
            this.filesDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filesDG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.filesDG.Location = new System.Drawing.Point(12, 32);
            this.filesDG.Name = "filesDG";
            this.filesDG.ReadOnly = true;
            this.filesDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filesDG.Size = new System.Drawing.Size(560, 386);
            this.filesDG.TabIndex = 0;
            // 
            // catalogLabel
            // 
            this.catalogLabel.AutoSize = true;
            this.catalogLabel.Location = new System.Drawing.Point(12, 9);
            this.catalogLabel.Name = "catalogLabel";
            this.catalogLabel.Size = new System.Drawing.Size(48, 13);
            this.catalogLabel.TabIndex = 1;
            this.catalogLabel.Text = "Каталог";
            // 
            // catalogSearchBox
            // 
            this.catalogSearchBox.Location = new System.Drawing.Point(66, 6);
            this.catalogSearchBox.Name = "catalogSearchBox";
            this.catalogSearchBox.Size = new System.Drawing.Size(123, 20);
            this.catalogSearchBox.TabIndex = 2;
            this.catalogSearchBox.TextChanged += new System.EventHandler(this.catalogSearchBox_TextChanged);
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Location = new System.Drawing.Point(224, 9);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(84, 13);
            this.creationDateLabel.TabIndex = 3;
            this.creationDateLabel.Text = "Дата создания";
            // 
            // creationDateBox
            // 
            this.creationDateBox.Location = new System.Drawing.Point(314, 6);
            this.creationDateBox.Name = "creationDateBox";
            this.creationDateBox.Size = new System.Drawing.Size(124, 20);
            this.creationDateBox.TabIndex = 4;
            this.creationDateBox.TextChanged += new System.EventHandler(this.creationDateBox_TextChanged);
            // 
            // deleteBox
            // 
            this.deleteBox.AutoSize = true;
            this.deleteBox.Checked = true;
            this.deleteBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.deleteBox.Location = new System.Drawing.Point(496, 8);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteBox.Size = new System.Drawing.Size(64, 17);
            this.deleteBox.TabIndex = 5;
            this.deleteBox.Text = "Удален";
            this.deleteBox.ThreeState = true;
            this.deleteBox.UseVisualStyleBackColor = true;
            this.deleteBox.CheckStateChanged += new System.EventHandler(this.deleteBox_CheckStateChanged);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(12, 426);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(132, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Добавить запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(440, 426);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ExplorerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.creationDateBox);
            this.Controls.Add(this.creationDateLabel);
            this.Controls.Add(this.catalogSearchBox);
            this.Controls.Add(this.catalogLabel);
            this.Controls.Add(this.filesDG);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "ExplorerWindow";
            this.Text = "Проводник";
            ((System.ComponentModel.ISupportInitialize)(this.filesDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView filesDG;
        private System.Windows.Forms.BindingSource source;
        private System.Windows.Forms.Label catalogLabel;
        private System.Windows.Forms.TextBox catalogSearchBox;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.TextBox creationDateBox;
        private System.Windows.Forms.CheckBox deleteBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

