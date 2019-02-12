namespace poolAdminMS.UserControls
{
    partial class CalendarDayLarge
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayTimeTableDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sunButton = new System.Windows.Forms.Button();
            this.satButton = new System.Windows.Forms.Button();
            this.friButton = new System.Windows.Forms.Button();
            this.thuButton = new System.Windows.Forms.Button();
            this.wenButton = new System.Windows.Forms.Button();
            this.tueButton = new System.Windows.Forms.Button();
            this.monButton = new System.Windows.Forms.Button();
            this.previousWeek = new System.Windows.Forms.Button();
            this.nextWeek = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dayLable = new System.Windows.Forms.Label();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.discardChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dayTimeTableDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayTimeTableDataGrid
            // 
            this.dayTimeTableDataGrid.AllowUserToAddRows = false;
            this.dayTimeTableDataGrid.AllowUserToDeleteRows = false;
            this.dayTimeTableDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dayTimeTableDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayTimeTableDataGrid.Location = new System.Drawing.Point(0, 0);
            this.dayTimeTableDataGrid.Margin = new System.Windows.Forms.Padding(6);
            this.dayTimeTableDataGrid.Name = "dayTimeTableDataGrid";
            this.dayTimeTableDataGrid.Size = new System.Drawing.Size(1900, 810);
            this.dayTimeTableDataGrid.TabIndex = 0;
            this.dayTimeTableDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dayTimeTableDataGrid_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1900, 1077);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 879);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1900, 198);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Controls.Add(this.sunButton, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.satButton, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.friButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.thuButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.wenButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tueButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.monButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.previousWeek, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextWeek, 8, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1900, 198);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sunButton
            // 
            this.sunButton.FlatAppearance.BorderSize = 0;
            this.sunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunButton.ForeColor = System.Drawing.Color.MintCream;
            this.sunButton.Location = new System.Drawing.Point(1483, 6);
            this.sunButton.Margin = new System.Windows.Forms.Padding(6);
            this.sunButton.Name = "sunButton";
            this.sunButton.Size = new System.Drawing.Size(198, 186);
            this.sunButton.TabIndex = 12;
            this.sunButton.Text = "ВС";
            this.sunButton.UseVisualStyleBackColor = true;
            this.sunButton.Click += new System.EventHandler(this.sunButton_Click);
            // 
            // satButton
            // 
            this.satButton.FlatAppearance.BorderSize = 0;
            this.satButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satButton.ForeColor = System.Drawing.Color.MintCream;
            this.satButton.Location = new System.Drawing.Point(1272, 6);
            this.satButton.Margin = new System.Windows.Forms.Padding(6);
            this.satButton.Name = "satButton";
            this.satButton.Size = new System.Drawing.Size(198, 186);
            this.satButton.TabIndex = 11;
            this.satButton.Text = "СБ";
            this.satButton.UseVisualStyleBackColor = true;
            this.satButton.Click += new System.EventHandler(this.satButton_Click);
            // 
            // friButton
            // 
            this.friButton.FlatAppearance.BorderSize = 0;
            this.friButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friButton.ForeColor = System.Drawing.Color.MintCream;
            this.friButton.Location = new System.Drawing.Point(1061, 6);
            this.friButton.Margin = new System.Windows.Forms.Padding(6);
            this.friButton.Name = "friButton";
            this.friButton.Size = new System.Drawing.Size(198, 186);
            this.friButton.TabIndex = 10;
            this.friButton.Text = "ПТ";
            this.friButton.UseVisualStyleBackColor = true;
            this.friButton.Click += new System.EventHandler(this.friButton_Click);
            // 
            // thuButton
            // 
            this.thuButton.FlatAppearance.BorderSize = 0;
            this.thuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thuButton.ForeColor = System.Drawing.Color.MintCream;
            this.thuButton.Location = new System.Drawing.Point(850, 6);
            this.thuButton.Margin = new System.Windows.Forms.Padding(6);
            this.thuButton.Name = "thuButton";
            this.thuButton.Size = new System.Drawing.Size(198, 186);
            this.thuButton.TabIndex = 9;
            this.thuButton.Text = "ЧТ";
            this.thuButton.UseVisualStyleBackColor = true;
            this.thuButton.Click += new System.EventHandler(this.thuButton_Click);
            // 
            // wenButton
            // 
            this.wenButton.FlatAppearance.BorderSize = 0;
            this.wenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wenButton.ForeColor = System.Drawing.Color.MintCream;
            this.wenButton.Location = new System.Drawing.Point(639, 6);
            this.wenButton.Margin = new System.Windows.Forms.Padding(6);
            this.wenButton.Name = "wenButton";
            this.wenButton.Size = new System.Drawing.Size(198, 186);
            this.wenButton.TabIndex = 8;
            this.wenButton.Text = "СР";
            this.wenButton.UseVisualStyleBackColor = true;
            this.wenButton.Click += new System.EventHandler(this.wenButton_Click);
            // 
            // tueButton
            // 
            this.tueButton.FlatAppearance.BorderSize = 0;
            this.tueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tueButton.ForeColor = System.Drawing.Color.MintCream;
            this.tueButton.Location = new System.Drawing.Point(428, 6);
            this.tueButton.Margin = new System.Windows.Forms.Padding(6);
            this.tueButton.Name = "tueButton";
            this.tueButton.Size = new System.Drawing.Size(198, 186);
            this.tueButton.TabIndex = 7;
            this.tueButton.Text = "ВТ";
            this.tueButton.UseVisualStyleBackColor = true;
            this.tueButton.Click += new System.EventHandler(this.tueButton_Click);
            // 
            // monButton
            // 
            this.monButton.FlatAppearance.BorderSize = 0;
            this.monButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monButton.ForeColor = System.Drawing.Color.MintCream;
            this.monButton.Location = new System.Drawing.Point(217, 6);
            this.monButton.Margin = new System.Windows.Forms.Padding(6);
            this.monButton.Name = "monButton";
            this.monButton.Size = new System.Drawing.Size(198, 186);
            this.monButton.TabIndex = 6;
            this.monButton.Text = "ПН";
            this.monButton.UseVisualStyleBackColor = true;
            this.monButton.Click += new System.EventHandler(this.monButton_Click);
            // 
            // previousWeek
            // 
            this.previousWeek.FlatAppearance.BorderSize = 0;
            this.previousWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousWeek.ForeColor = System.Drawing.Color.MintCream;
            this.previousWeek.Location = new System.Drawing.Point(6, 6);
            this.previousWeek.Margin = new System.Windows.Forms.Padding(6);
            this.previousWeek.Name = "previousWeek";
            this.previousWeek.Size = new System.Drawing.Size(198, 186);
            this.previousWeek.TabIndex = 4;
            this.previousWeek.Text = "<";
            this.previousWeek.UseVisualStyleBackColor = true;
            this.previousWeek.Click += new System.EventHandler(this.previousWeek_Click);
            // 
            // nextWeek
            // 
            this.nextWeek.FlatAppearance.BorderSize = 0;
            this.nextWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextWeek.ForeColor = System.Drawing.Color.MintCream;
            this.nextWeek.Location = new System.Drawing.Point(1694, 6);
            this.nextWeek.Margin = new System.Windows.Forms.Padding(6);
            this.nextWeek.Name = "nextWeek";
            this.nextWeek.Size = new System.Drawing.Size(200, 186);
            this.nextWeek.TabIndex = 5;
            this.nextWeek.Text = ">";
            this.nextWeek.UseVisualStyleBackColor = true;
            this.nextWeek.Click += new System.EventHandler(this.nextWeek_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dayTimeTableDataGrid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 75);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1900, 810);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1900, 75);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.31579F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.68421F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 335F));
            this.tableLayoutPanel2.Controls.Add(this.dayLable, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveChangesButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.discardChangesButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1900, 75);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(529, 22);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(392, 31);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dayLable
            // 
            this.dayLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dayLable.AutoSize = true;
            this.dayLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLable.ForeColor = System.Drawing.Color.MintCream;
            this.dayLable.Location = new System.Drawing.Point(17, 0);
            this.dayLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dayLable.Name = "dayLable";
            this.dayLable.Size = new System.Drawing.Size(210, 75);
            this.dayLable.TabIndex = 4;
            this.dayLable.Text = "СРЕДА 16.05.2018";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChangesButton.FlatAppearance.BorderSize = 0;
            this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.ForeColor = System.Drawing.Color.MintCream;
            this.saveChangesButton.Location = new System.Drawing.Point(1211, 6);
            this.saveChangesButton.Margin = new System.Windows.Forms.Padding(6);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(347, 63);
            this.saveChangesButton.TabIndex = 10;
            this.saveChangesButton.Text = "Сохранить изменения";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            // 
            // discardChangesButton
            // 
            this.discardChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discardChangesButton.FlatAppearance.BorderSize = 0;
            this.discardChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discardChangesButton.ForeColor = System.Drawing.Color.MintCream;
            this.discardChangesButton.Location = new System.Drawing.Point(1570, 6);
            this.discardChangesButton.Margin = new System.Windows.Forms.Padding(6);
            this.discardChangesButton.Name = "discardChangesButton";
            this.discardChangesButton.Size = new System.Drawing.Size(324, 63);
            this.discardChangesButton.TabIndex = 11;
            this.discardChangesButton.Text = "Отменить";
            this.discardChangesButton.UseVisualStyleBackColor = true;
            // 
            // CalendarDayLarge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CalendarDayLarge";
            this.Size = new System.Drawing.Size(1900, 1077);
            ((System.ComponentModel.ISupportInitialize)(this.dayTimeTableDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dayTimeTableDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button previousWeek;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button sunButton;
        private System.Windows.Forms.Button satButton;
        private System.Windows.Forms.Button friButton;
        private System.Windows.Forms.Button thuButton;
        private System.Windows.Forms.Button wenButton;
        private System.Windows.Forms.Button tueButton;
        private System.Windows.Forms.Button monButton;
        private System.Windows.Forms.Button nextWeek;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label dayLable;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button discardChangesButton;
    }
}
