namespace poolAdminMS
{
    partial class MainForm
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
            this.calendarButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.clientsButton = new System.Windows.Forms.Button();
            this.trainingGroupsMenuButton = new System.Windows.Forms.Button();
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarButton
            // 
            this.calendarButton.FlatAppearance.BorderSize = 0;
            this.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.ForeColor = System.Drawing.Color.MintCream;
            this.calendarButton.Location = new System.Drawing.Point(3, 0);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.calendarButton.Size = new System.Drawing.Size(180, 90);
            this.calendarButton.TabIndex = 1;
            this.calendarButton.Text = "Расписание";
            this.calendarButton.UseVisualStyleBackColor = true;
            this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.slidePanel);
            this.panel1.Controls.Add(this.clientsButton);
            this.panel1.Controls.Add(this.calendarButton);
            this.panel1.Controls.Add(this.trainingGroupsMenuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 711);
            this.panel1.TabIndex = 2;
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.slidePanel.Location = new System.Drawing.Point(3, 0);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(12, 90);
            this.slidePanel.TabIndex = 3;
            // 
            // clientsButton
            // 
            this.clientsButton.FlatAppearance.BorderSize = 0;
            this.clientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsButton.ForeColor = System.Drawing.Color.MintCream;
            this.clientsButton.Location = new System.Drawing.Point(3, 90);
            this.clientsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.clientsButton.Size = new System.Drawing.Size(180, 90);
            this.clientsButton.TabIndex = 2;
            this.clientsButton.Text = "Посетители";
            this.clientsButton.UseVisualStyleBackColor = true;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // trainingGroupsMenuButton
            // 
            this.trainingGroupsMenuButton.FlatAppearance.BorderSize = 0;
            this.trainingGroupsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainingGroupsMenuButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingGroupsMenuButton.ForeColor = System.Drawing.Color.MintCream;
            this.trainingGroupsMenuButton.Location = new System.Drawing.Point(3, 180);
            this.trainingGroupsMenuButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trainingGroupsMenuButton.Name = "trainingGroupsMenuButton";
            this.trainingGroupsMenuButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.trainingGroupsMenuButton.Size = new System.Drawing.Size(188, 90);
            this.trainingGroupsMenuButton.TabIndex = 4;
            this.trainingGroupsMenuButton.Text = "Тренировочные группы";
            this.trainingGroupsMenuButton.UseVisualStyleBackColor = true;
            this.trainingGroupsMenuButton.Click += new System.EventHandler(this.trainingGroupsMenuButton_Click);
            // 
            // userControlPanel
            // 
            this.userControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPanel.Location = new System.Drawing.Point(184, 0);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(1100, 711);
            this.userControlPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.userControlPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "MainForm";
            this.Text = "PoolAdmin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Panel slidePanel;
        private System.Windows.Forms.Panel userControlPanel;
        private System.Windows.Forms.Button trainingGroupsMenuButton;
    }
}

