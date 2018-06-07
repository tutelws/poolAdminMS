namespace poolAdminMS.UserControls
{
    partial class TrainingGroupsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeesDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.employeesLable = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchEmployeesBySurnameButton = new System.Windows.Forms.Button();
            this.trainingGroupLable = new System.Windows.Forms.Label();
            this.showAllGroups = new System.Windows.Forms.Button();
            this.searchGroupsByNameButton = new System.Windows.Forms.Button();
            this.trainingGroupsDataGrid = new System.Windows.Forms.DataGridView();
            this.addEmployee = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.editTrainingGroupButton = new System.Windows.Forms.Button();
            this.deletetrainingGroup = new System.Windows.Forms.Button();
            this.addTrainingGroup = new System.Windows.Forms.Button();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingGroupsDataGrid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesDataGrid
            // 
            this.employeesDataGrid.AllowUserToAddRows = false;
            this.employeesDataGrid.AllowUserToDeleteRows = false;
            this.employeesDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.surname,
            this.name,
            this.secondName,
            this.position,
            this.phone});
            this.employeesDataGrid.Location = new System.Drawing.Point(2, 2);
            this.employeesDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.employeesDataGrid.Name = "employeesDataGrid";
            this.employeesDataGrid.ReadOnly = true;
            this.employeesDataGrid.RowTemplate.Height = 24;
            this.employeesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesDataGrid.Size = new System.Drawing.Size(473, 430);
            this.employeesDataGrid.TabIndex = 0;
            this.employeesDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesDataGrid_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surname.HeaderText = "Фамилия";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // secondName
            // 
            this.secondName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.secondName.HeaderText = "Отчество";
            this.secondName.Name = "secondName";
            this.secondName.ReadOnly = true;
            // 
            // position
            // 
            this.position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.position.HeaderText = "Должность";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 41);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.78864F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.21136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Controls.Add(this.employeesLable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchEmployeesBySurnameButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.trainingGroupLable, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.showAllGroups, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchGroupsByNameButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 41);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // employeesLable
            // 
            this.employeesLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.employeesLable.AutoSize = true;
            this.employeesLable.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesLable.ForeColor = System.Drawing.Color.MintCream;
            this.employeesLable.Location = new System.Drawing.Point(2, 22);
            this.employeesLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeesLable.Name = "employeesLable";
            this.employeesLable.Size = new System.Drawing.Size(93, 19);
            this.employeesLable.TabIndex = 0;
            this.employeesLable.Text = "Сотрудники";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(319, 10);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(151, 21);
            this.searchTextBox.TabIndex = 9;
            // 
            // searchEmployeesBySurnameButton
            // 
            this.searchEmployeesBySurnameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchEmployeesBySurnameButton.FlatAppearance.BorderSize = 0;
            this.searchEmployeesBySurnameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchEmployeesBySurnameButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployeesBySurnameButton.ForeColor = System.Drawing.Color.MintCream;
            this.searchEmployeesBySurnameButton.Location = new System.Drawing.Point(162, 2);
            this.searchEmployeesBySurnameButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchEmployeesBySurnameButton.Name = "searchEmployeesBySurnameButton";
            this.searchEmployeesBySurnameButton.Size = new System.Drawing.Size(151, 36);
            this.searchEmployeesBySurnameButton.TabIndex = 8;
            this.searchEmployeesBySurnameButton.Text = "Искать по фамилии";
            this.searchEmployeesBySurnameButton.UseVisualStyleBackColor = true;
            this.searchEmployeesBySurnameButton.Click += new System.EventHandler(this.searchEmployeesBySurnameButton_Click);
            // 
            // trainingGroupLable
            // 
            this.trainingGroupLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trainingGroupLable.AutoSize = true;
            this.trainingGroupLable.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingGroupLable.ForeColor = System.Drawing.Color.MintCream;
            this.trainingGroupLable.Location = new System.Drawing.Point(783, 22);
            this.trainingGroupLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trainingGroupLable.Name = "trainingGroupLable";
            this.trainingGroupLable.Size = new System.Drawing.Size(169, 19);
            this.trainingGroupLable.TabIndex = 1;
            this.trainingGroupLable.Text = "Тренировочные группы";
            // 
            // showAllGroups
            // 
            this.showAllGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showAllGroups.FlatAppearance.BorderSize = 0;
            this.showAllGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllGroups.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllGroups.ForeColor = System.Drawing.Color.MintCream;
            this.showAllGroups.Location = new System.Drawing.Point(643, 2);
            this.showAllGroups.Margin = new System.Windows.Forms.Padding(2);
            this.showAllGroups.Name = "showAllGroups";
            this.showAllGroups.Size = new System.Drawing.Size(128, 36);
            this.showAllGroups.TabIndex = 7;
            this.showAllGroups.Text = " Сбросить";
            this.showAllGroups.UseVisualStyleBackColor = true;
            this.showAllGroups.Click += new System.EventHandler(this.showAllGroups_Click);
            // 
            // searchGroupsByNameButton
            // 
            this.searchGroupsByNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchGroupsByNameButton.FlatAppearance.BorderSize = 0;
            this.searchGroupsByNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchGroupsByNameButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGroupsByNameButton.ForeColor = System.Drawing.Color.MintCream;
            this.searchGroupsByNameButton.Location = new System.Drawing.Point(477, 2);
            this.searchGroupsByNameButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchGroupsByNameButton.Name = "searchGroupsByNameButton";
            this.searchGroupsByNameButton.Size = new System.Drawing.Size(162, 36);
            this.searchGroupsByNameButton.TabIndex = 10;
            this.searchGroupsByNameButton.Text = "Искать по названию";
            this.searchGroupsByNameButton.UseVisualStyleBackColor = true;
            this.searchGroupsByNameButton.Click += new System.EventHandler(this.searchGroupsByNameButton_Click);
            // 
            // trainingGroupsDataGrid
            // 
            this.trainingGroupsDataGrid.AllowUserToAddRows = false;
            this.trainingGroupsDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.trainingGroupsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.trainingGroupsDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.trainingGroupsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingGroupsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trGroupId,
            this.groupName,
            this.fio});
            this.trainingGroupsDataGrid.Location = new System.Drawing.Point(479, 2);
            this.trainingGroupsDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.trainingGroupsDataGrid.Name = "trainingGroupsDataGrid";
            this.trainingGroupsDataGrid.ReadOnly = true;
            this.trainingGroupsDataGrid.RowTemplate.Height = 24;
            this.trainingGroupsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trainingGroupsDataGrid.Size = new System.Drawing.Size(472, 430);
            this.trainingGroupsDataGrid.TabIndex = 2;
            this.trainingGroupsDataGrid.DoubleClick += new System.EventHandler(this.trainingGroupsDataGrid_DoubleClick);
            // 
            // addEmployee
            // 
            this.addEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addEmployee.FlatAppearance.BorderSize = 0;
            this.addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.ForeColor = System.Drawing.Color.MintCream;
            this.addEmployee.Location = new System.Drawing.Point(2, 436);
            this.addEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(472, 26);
            this.addEmployee.TabIndex = 3;
            this.addEmployee.Text = "Добавить сотрудника";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.editTrainingGroupButton, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.trainingGroupsDataGrid, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.deletetrainingGroup, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.addTrainingGroup, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.employeesDataGrid, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.editEmployeeButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.deleteEmployee, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.addEmployee, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.35294F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(954, 528);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // editTrainingGroupButton
            // 
            this.editTrainingGroupButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editTrainingGroupButton.FlatAppearance.BorderSize = 0;
            this.editTrainingGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTrainingGroupButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTrainingGroupButton.ForeColor = System.Drawing.Color.MintCream;
            this.editTrainingGroupButton.Location = new System.Drawing.Point(479, 498);
            this.editTrainingGroupButton.Margin = new System.Windows.Forms.Padding(2);
            this.editTrainingGroupButton.Name = "editTrainingGroupButton";
            this.editTrainingGroupButton.Size = new System.Drawing.Size(472, 27);
            this.editTrainingGroupButton.TabIndex = 8;
            this.editTrainingGroupButton.Text = "Редактировать";
            this.editTrainingGroupButton.UseVisualStyleBackColor = true;
            this.editTrainingGroupButton.Click += new System.EventHandler(this.editTrainingGroupButton_Click);
            // 
            // deletetrainingGroup
            // 
            this.deletetrainingGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletetrainingGroup.FlatAppearance.BorderSize = 0;
            this.deletetrainingGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletetrainingGroup.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletetrainingGroup.ForeColor = System.Drawing.Color.MintCream;
            this.deletetrainingGroup.Location = new System.Drawing.Point(479, 467);
            this.deletetrainingGroup.Margin = new System.Windows.Forms.Padding(2);
            this.deletetrainingGroup.Name = "deletetrainingGroup";
            this.deletetrainingGroup.Size = new System.Drawing.Size(472, 26);
            this.deletetrainingGroup.TabIndex = 7;
            this.deletetrainingGroup.Text = "Удалить тренировочную группу";
            this.deletetrainingGroup.UseVisualStyleBackColor = true;
            this.deletetrainingGroup.Click += new System.EventHandler(this.deletetrainingGroup_Click);
            // 
            // addTrainingGroup
            // 
            this.addTrainingGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTrainingGroup.FlatAppearance.BorderSize = 0;
            this.addTrainingGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTrainingGroup.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTrainingGroup.ForeColor = System.Drawing.Color.MintCream;
            this.addTrainingGroup.Location = new System.Drawing.Point(479, 436);
            this.addTrainingGroup.Margin = new System.Windows.Forms.Padding(2);
            this.addTrainingGroup.Name = "addTrainingGroup";
            this.addTrainingGroup.Size = new System.Drawing.Size(472, 26);
            this.addTrainingGroup.TabIndex = 6;
            this.addTrainingGroup.Text = "Создать тренировочную группу";
            this.addTrainingGroup.UseVisualStyleBackColor = true;
            this.addTrainingGroup.Click += new System.EventHandler(this.addTrainingGroup_Click);
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editEmployeeButton.FlatAppearance.BorderSize = 0;
            this.editEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEmployeeButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmployeeButton.ForeColor = System.Drawing.Color.MintCream;
            this.editEmployeeButton.Location = new System.Drawing.Point(2, 498);
            this.editEmployeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(472, 27);
            this.editEmployeeButton.TabIndex = 5;
            this.editEmployeeButton.Text = "Редактировать данные";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            this.editEmployeeButton.Click += new System.EventHandler(this.editEmployeeButton_Click);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteEmployee.FlatAppearance.BorderSize = 0;
            this.deleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEmployee.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmployee.ForeColor = System.Drawing.Color.MintCream;
            this.deleteEmployee.Location = new System.Drawing.Point(2, 467);
            this.deleteEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(472, 26);
            this.deleteEmployee.TabIndex = 4;
            this.deleteEmployee.Text = "Удалить сотрудника";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 528);
            this.panel2.TabIndex = 4;
            // 
            // trGroupId
            // 
            this.trGroupId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.trGroupId.HeaderText = "id";
            this.trGroupId.Name = "trGroupId";
            this.trGroupId.ReadOnly = true;
            this.trGroupId.Width = 40;
            // 
            // groupName
            // 
            this.groupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.groupName.HeaderText = "Название тренировочной группы";
            this.groupName.Name = "groupName";
            this.groupName.ReadOnly = true;
            // 
            // fio
            // 
            this.fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fio.HeaderText = "ФИО тренера";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            // 
            // TrainingGroupsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrainingGroupsControl";
            this.Size = new System.Drawing.Size(954, 569);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingGroupsDataGrid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label employeesLable;
        private System.Windows.Forms.DataGridView trainingGroupsDataGrid;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label trainingGroupLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button editTrainingGroupButton;
        private System.Windows.Forms.Button deletetrainingGroup;
        private System.Windows.Forms.Button addTrainingGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button showAllGroups;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchEmployeesBySurnameButton;
        private System.Windows.Forms.Button searchGroupsByNameButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn trGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
    }
}
