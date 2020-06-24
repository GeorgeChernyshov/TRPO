namespace ExplorerWindow
{
    partial class AddFileForm
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
            this.catalogLabel = new System.Windows.Forms.Label();
            this.catalogBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.extensionBox = new System.Windows.Forms.TextBox();
            this.creationDateBox = new System.Windows.Forms.TextBox();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.deleteBox = new System.Windows.Forms.CheckBox();
            this.sectorCountBox = new System.Windows.Forms.DomainUpDown();
            this.sectorCountLabel = new System.Windows.Forms.Label();
            this.readonlyBox = new System.Windows.Forms.CheckBox();
            this.hideBox = new System.Windows.Forms.CheckBox();
            this.systemBox = new System.Windows.Forms.CheckBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.declineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catalogLabel
            // 
            this.catalogLabel.AutoSize = true;
            this.catalogLabel.Location = new System.Drawing.Point(12, 16);
            this.catalogLabel.Name = "catalogLabel";
            this.catalogLabel.Size = new System.Drawing.Size(51, 13);
            this.catalogLabel.TabIndex = 0;
            this.catalogLabel.Text = "Каталог:";
            // 
            // catalogBox
            // 
            this.catalogBox.Location = new System.Drawing.Point(112, 13);
            this.catalogBox.Name = "catalogBox";
            this.catalogBox.Size = new System.Drawing.Size(160, 20);
            this.catalogBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(112, 40);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(160, 20);
            this.nameBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(86, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Наименование:";
            // 
            // extensionLabel
            // 
            this.extensionLabel.AutoSize = true;
            this.extensionLabel.Location = new System.Drawing.Point(12, 70);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(73, 13);
            this.extensionLabel.TabIndex = 4;
            this.extensionLabel.Text = "Расширение:";
            // 
            // extensionBox
            // 
            this.extensionBox.Location = new System.Drawing.Point(112, 67);
            this.extensionBox.Name = "extensionBox";
            this.extensionBox.Size = new System.Drawing.Size(160, 20);
            this.extensionBox.TabIndex = 5;
            // 
            // creationDateBox
            // 
            this.creationDateBox.Location = new System.Drawing.Point(112, 94);
            this.creationDateBox.Name = "creationDateBox";
            this.creationDateBox.Size = new System.Drawing.Size(160, 20);
            this.creationDateBox.TabIndex = 6;
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Location = new System.Drawing.Point(12, 97);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(87, 13);
            this.creationDateLabel.TabIndex = 7;
            this.creationDateLabel.Text = "Дата создания:";
            // 
            // deleteBox
            // 
            this.deleteBox.AutoSize = true;
            this.deleteBox.Location = new System.Drawing.Point(15, 153);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(64, 17);
            this.deleteBox.TabIndex = 8;
            this.deleteBox.Text = "Удалён";
            this.deleteBox.UseVisualStyleBackColor = true;
            // 
            // sectorCountBox
            // 
            this.sectorCountBox.Location = new System.Drawing.Point(112, 120);
            this.sectorCountBox.Name = "sectorCountBox";
            this.sectorCountBox.Size = new System.Drawing.Size(160, 20);
            this.sectorCountBox.TabIndex = 9;
            // 
            // sectorCountLabel
            // 
            this.sectorCountLabel.AutoSize = true;
            this.sectorCountLabel.Location = new System.Drawing.Point(12, 122);
            this.sectorCountLabel.Name = "sectorCountLabel";
            this.sectorCountLabel.Size = new System.Drawing.Size(94, 13);
            this.sectorCountLabel.TabIndex = 10;
            this.sectorCountLabel.Text = "Кол-во секторов:";
            // 
            // readonlyBox
            // 
            this.readonlyBox.AutoSize = true;
            this.readonlyBox.Location = new System.Drawing.Point(15, 176);
            this.readonlyBox.Name = "readonlyBox";
            this.readonlyBox.Size = new System.Drawing.Size(121, 17);
            this.readonlyBox.TabIndex = 11;
            this.readonlyBox.Text = "Только для чтения";
            this.readonlyBox.UseVisualStyleBackColor = true;
            // 
            // hideBox
            // 
            this.hideBox.AutoSize = true;
            this.hideBox.Location = new System.Drawing.Point(15, 199);
            this.hideBox.Name = "hideBox";
            this.hideBox.Size = new System.Drawing.Size(72, 17);
            this.hideBox.TabIndex = 12;
            this.hideBox.Text = "Скрытый";
            this.hideBox.UseVisualStyleBackColor = true;
            // 
            // systemBox
            // 
            this.systemBox.AutoSize = true;
            this.systemBox.Location = new System.Drawing.Point(15, 222);
            this.systemBox.Name = "systemBox";
            this.systemBox.Size = new System.Drawing.Size(84, 17);
            this.systemBox.TabIndex = 13;
            this.systemBox.Text = "Системный";
            this.systemBox.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(15, 248);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(93, 23);
            this.acceptButton.TabIndex = 14;
            this.acceptButton.Text = "Принять";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(179, 248);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(93, 23);
            this.declineButton.TabIndex = 15;
            this.declineButton.Text = "Отмена";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // AddFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 283);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.systemBox);
            this.Controls.Add(this.hideBox);
            this.Controls.Add(this.readonlyBox);
            this.Controls.Add(this.sectorCountLabel);
            this.Controls.Add(this.sectorCountBox);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.creationDateLabel);
            this.Controls.Add(this.creationDateBox);
            this.Controls.Add(this.extensionBox);
            this.Controls.Add(this.extensionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.catalogBox);
            this.Controls.Add(this.catalogLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 322);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 322);
            this.Name = "AddFileForm";
            this.Text = "Добавить запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label catalogLabel;
        private System.Windows.Forms.TextBox catalogBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.TextBox extensionBox;
        private System.Windows.Forms.TextBox creationDateBox;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.CheckBox deleteBox;
        private System.Windows.Forms.DomainUpDown sectorCountBox;
        private System.Windows.Forms.Label sectorCountLabel;
        private System.Windows.Forms.CheckBox readonlyBox;
        private System.Windows.Forms.CheckBox hideBox;
        private System.Windows.Forms.CheckBox systemBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button declineButton;
    }
}