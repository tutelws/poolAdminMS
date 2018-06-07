namespace poolAdminMS.Forms
{
    partial class AddEditEmployeeForm
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
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.surnameLable = new System.Windows.Forms.Label();
            this.nameLable = new System.Windows.Forms.Label();
            this.phoneLable = new System.Windows.Forms.Label();
            this.secondNameLable = new System.Windows.Forms.Label();
            this.positionLable = new System.Windows.Forms.Label();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(146, 13);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(167, 28);
            this.surnameTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(146, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(167, 28);
            this.nameTextBox.TabIndex = 1;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(146, 81);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(167, 28);
            this.secondNameTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(146, 115);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(167, 28);
            this.phoneTextBox.TabIndex = 3;
            // 
            // surnameLable
            // 
            this.surnameLable.AutoSize = true;
            this.surnameLable.ForeColor = System.Drawing.Color.MintCream;
            this.surnameLable.Location = new System.Drawing.Point(30, 16);
            this.surnameLable.Name = "surnameLable";
            this.surnameLable.Size = new System.Drawing.Size(89, 21);
            this.surnameLable.TabIndex = 4;
            this.surnameLable.Text = "Фамилия";
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.ForeColor = System.Drawing.Color.MintCream;
            this.nameLable.Location = new System.Drawing.Point(30, 50);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(46, 21);
            this.nameLable.TabIndex = 5;
            this.nameLable.Text = "Имя";
            // 
            // phoneLable
            // 
            this.phoneLable.AutoSize = true;
            this.phoneLable.ForeColor = System.Drawing.Color.MintCream;
            this.phoneLable.Location = new System.Drawing.Point(30, 118);
            this.phoneLable.Name = "phoneLable";
            this.phoneLable.Size = new System.Drawing.Size(88, 21);
            this.phoneLable.TabIndex = 6;
            this.phoneLable.Text = "Телефон";
            // 
            // secondNameLable
            // 
            this.secondNameLable.AutoSize = true;
            this.secondNameLable.ForeColor = System.Drawing.Color.MintCream;
            this.secondNameLable.Location = new System.Drawing.Point(30, 84);
            this.secondNameLable.Name = "secondNameLable";
            this.secondNameLable.Size = new System.Drawing.Size(88, 21);
            this.secondNameLable.TabIndex = 7;
            this.secondNameLable.Text = "Отчество";
            // 
            // positionLable
            // 
            this.positionLable.AutoSize = true;
            this.positionLable.ForeColor = System.Drawing.Color.MintCream;
            this.positionLable.Location = new System.Drawing.Point(30, 155);
            this.positionLable.Name = "positionLable";
            this.positionLable.Size = new System.Drawing.Size(103, 21);
            this.positionLable.TabIndex = 8;
            this.positionLable.Text = "Должность";
            // 
            // positionComboBox
            // 
            this.positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(146, 155);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(167, 29);
            this.positionComboBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 50);
            this.panel1.TabIndex = 10;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.MintCream;
            this.cancelButton.Location = new System.Drawing.Point(175, 3);
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
            this.okButton.Location = new System.Drawing.Point(3, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(170, 48);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Подтвердить";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AddEditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(350, 241);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.positionLable);
            this.Controls.Add(this.secondNameLable);
            this.Controls.Add(this.phoneLable);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.surnameLable);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEditEmployeeForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label surnameLable;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Label phoneLable;
        private System.Windows.Forms.Label secondNameLable;
        private System.Windows.Forms.Label positionLable;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}