namespace poolAdminMS.Forms
{
    partial class AddEditTrainingGroupForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupNameLable = new System.Windows.Forms.Label();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.fioLable = new System.Windows.Forms.Label();
            this.coachFioComboBox = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorLable = new System.Windows.Forms.Label();
            this.colorPickerPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 50);
            this.panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.MintCream;
            this.cancelButton.Location = new System.Drawing.Point(180, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(170, 48);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.MintCream;
            this.okButton.Location = new System.Drawing.Point(3, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(170, 48);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Подтвердить";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // groupNameLable
            // 
            this.groupNameLable.AutoSize = true;
            this.groupNameLable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameLable.ForeColor = System.Drawing.Color.MintCream;
            this.groupNameLable.Location = new System.Drawing.Point(12, 9);
            this.groupNameLable.Name = "groupNameLable";
            this.groupNameLable.Size = new System.Drawing.Size(259, 20);
            this.groupNameLable.TabIndex = 1;
            this.groupNameLable.Text = "Название тренировочной группы:";
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Location = new System.Drawing.Point(16, 32);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(322, 23);
            this.groupNameTextBox.TabIndex = 2;
            // 
            // fioLable
            // 
            this.fioLable.AutoSize = true;
            this.fioLable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fioLable.ForeColor = System.Drawing.Color.MintCream;
            this.fioLable.Location = new System.Drawing.Point(12, 74);
            this.fioLable.Name = "fioLable";
            this.fioLable.Size = new System.Drawing.Size(63, 20);
            this.fioLable.TabIndex = 3;
            this.fioLable.Text = "Тренер";
            // 
            // coachFioComboBox
            // 
            this.coachFioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coachFioComboBox.FormattingEnabled = true;
            this.coachFioComboBox.Location = new System.Drawing.Point(81, 72);
            this.coachFioComboBox.Name = "coachFioComboBox";
            this.coachFioComboBox.Size = new System.Drawing.Size(257, 25);
            this.coachFioComboBox.TabIndex = 4;
            // 
            // colorLable
            // 
            this.colorLable.AutoSize = true;
            this.colorLable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLable.ForeColor = System.Drawing.Color.MintCream;
            this.colorLable.Location = new System.Drawing.Point(12, 134);
            this.colorLable.Name = "colorLable";
            this.colorLable.Size = new System.Drawing.Size(141, 20);
            this.colorLable.TabIndex = 5;
            this.colorLable.Text = "Цвет маркировки";
            // 
            // colorPickerPanel
            // 
            this.colorPickerPanel.BackColor = System.Drawing.Color.LightGreen;
            this.colorPickerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPickerPanel.Location = new System.Drawing.Point(287, 134);
            this.colorPickerPanel.Name = "colorPickerPanel";
            this.colorPickerPanel.Size = new System.Drawing.Size(51, 29);
            this.colorPickerPanel.TabIndex = 6;
            this.colorPickerPanel.Click += new System.EventHandler(this.colorPickerPanel_Click);
            // 
            // AddEditTrainingGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(350, 241);
            this.Controls.Add(this.colorPickerPanel);
            this.Controls.Add(this.colorLable);
            this.Controls.Add(this.coachFioComboBox);
            this.Controls.Add(this.fioLable);
            this.Controls.Add(this.groupNameTextBox);
            this.Controls.Add(this.groupNameLable);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEditTrainingGroupForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label groupNameLable;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.Label fioLable;
        private System.Windows.Forms.ComboBox coachFioComboBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label colorLable;
        private System.Windows.Forms.Panel colorPickerPanel;
    }
}