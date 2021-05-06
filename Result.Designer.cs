namespace HotelManagementSystem
{
    partial class Result
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofArivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofDepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelCount = new System.Windows.Forms.Label();
            this.labelDohod = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.genderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelProfit = new System.Windows.Forms.Label();
            this.labelExpensesforPeriod = new System.Windows.Forms.Label();
            this.labelCountOfDaysForPeriod = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.checkBoxDiagram = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1511, 110);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(414, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 91);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Profit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.telephoneNumberDataGridViewTextBoxColumn,
            this.dateofArivalDataGridViewTextBoxColumn,
            this.dateofDepartureDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.mealDataGridViewTextBoxColumn,
            this.totalDaysDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(565, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 150;
            // 
            // telephoneNumberDataGridViewTextBoxColumn
            // 
            this.telephoneNumberDataGridViewTextBoxColumn.DataPropertyName = "TelephoneNumber";
            this.telephoneNumberDataGridViewTextBoxColumn.HeaderText = "TelephoneNumber";
            this.telephoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telephoneNumberDataGridViewTextBoxColumn.Name = "telephoneNumberDataGridViewTextBoxColumn";
            this.telephoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephoneNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateofArivalDataGridViewTextBoxColumn
            // 
            this.dateofArivalDataGridViewTextBoxColumn.DataPropertyName = "DateofArival";
            this.dateofArivalDataGridViewTextBoxColumn.HeaderText = "DateofArival";
            this.dateofArivalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateofArivalDataGridViewTextBoxColumn.Name = "dateofArivalDataGridViewTextBoxColumn";
            this.dateofArivalDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateofArivalDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateofDepartureDataGridViewTextBoxColumn
            // 
            this.dateofDepartureDataGridViewTextBoxColumn.DataPropertyName = "DateofDeparture";
            this.dateofDepartureDataGridViewTextBoxColumn.HeaderText = "DateofDeparture";
            this.dateofDepartureDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateofDepartureDataGridViewTextBoxColumn.Name = "dateofDepartureDataGridViewTextBoxColumn";
            this.dateofDepartureDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateofDepartureDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // mealDataGridViewTextBoxColumn
            // 
            this.mealDataGridViewTextBoxColumn.DataPropertyName = "Meal";
            this.mealDataGridViewTextBoxColumn.HeaderText = "Meal";
            this.mealDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mealDataGridViewTextBoxColumn.Name = "mealDataGridViewTextBoxColumn";
            this.mealDataGridViewTextBoxColumn.ReadOnly = true;
            this.mealDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalDaysDataGridViewTextBoxColumn
            // 
            this.totalDaysDataGridViewTextBoxColumn.DataPropertyName = "TotalDays";
            this.totalDaysDataGridViewTextBoxColumn.HeaderText = "TotalDays";
            this.totalDaysDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDaysDataGridViewTextBoxColumn.Name = "totalDaysDataGridViewTextBoxColumn";
            this.totalDaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDaysDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCostDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(HotelManagementSystem.Client);
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LabelCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelCount.Location = new System.Drawing.Point(12, 490);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(235, 32);
            this.LabelCount.TabIndex = 8;
            this.LabelCount.Text = "Кол-во клиентов";
            this.LabelCount.Click += new System.EventHandler(this.LabelCount_Click);
            // 
            // labelDohod
            // 
            this.labelDohod.AutoSize = true;
            this.labelDohod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDohod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDohod.Location = new System.Drawing.Point(12, 419);
            this.labelDohod.Name = "labelDohod";
            this.labelDohod.Size = new System.Drawing.Size(99, 32);
            this.labelDohod.TabIndex = 7;
            this.labelDohod.Text = "Доход";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genderDataGridViewTextBoxColumn1,
            this.workerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.workPositionDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.workersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(731, 103);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(757, 150);
            this.dataGridView2.TabIndex = 9;
            // 
            // genderDataGridViewTextBoxColumn1
            // 
            this.genderDataGridViewTextBoxColumn1.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn1.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn1.Name = "genderDataGridViewTextBoxColumn1";
            this.genderDataGridViewTextBoxColumn1.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn1.Width = 150;
            // 
            // workerIDDataGridViewTextBoxColumn
            // 
            this.workerIDDataGridViewTextBoxColumn.DataPropertyName = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.HeaderText = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.workerIDDataGridViewTextBoxColumn.Name = "workerIDDataGridViewTextBoxColumn";
            this.workerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // workPositionDataGridViewTextBoxColumn
            // 
            this.workPositionDataGridViewTextBoxColumn.DataPropertyName = "WorkPosition";
            this.workPositionDataGridViewTextBoxColumn.HeaderText = "WorkPosition";
            this.workPositionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.workPositionDataGridViewTextBoxColumn.Name = "workPositionDataGridViewTextBoxColumn";
            this.workPositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.workPositionDataGridViewTextBoxColumn.Width = 150;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataSource = typeof(HotelManagementSystem.Workers);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "MyWorkerBase";
            // 
            // labelProfit
            // 
            this.labelProfit.AutoSize = true;
            this.labelProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelProfit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProfit.Location = new System.Drawing.Point(12, 553);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(134, 32);
            this.labelProfit.TabIndex = 10;
            this.labelProfit.Text = "Прибыль";
            // 
            // labelExpensesforPeriod
            // 
            this.labelExpensesforPeriod.AutoSize = true;
            this.labelExpensesforPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelExpensesforPeriod.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelExpensesforPeriod.Location = new System.Drawing.Point(12, 364);
            this.labelExpensesforPeriod.Name = "labelExpensesforPeriod";
            this.labelExpensesforPeriod.Size = new System.Drawing.Size(333, 32);
            this.labelExpensesforPeriod.TabIndex = 11;
            this.labelExpensesforPeriod.Text = "Расходы за этот период";
            // 
            // labelCountOfDaysForPeriod
            // 
            this.labelCountOfDaysForPeriod.AutoSize = true;
            this.labelCountOfDaysForPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelCountOfDaysForPeriod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCountOfDaysForPeriod.Location = new System.Drawing.Point(12, 306);
            this.labelCountOfDaysForPeriod.Name = "labelCountOfDaysForPeriod";
            this.labelCountOfDaysForPeriod.Size = new System.Drawing.Size(383, 32);
            this.labelCountOfDaysForPeriod.TabIndex = 12;
            this.labelCountOfDaysForPeriod.Text = "Количество дней в периоде";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(408, 259);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 31);
            this.button8.TabIndex = 38;
            this.button8.Text = "Last";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 259);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 31);
            this.button7.TabIndex = 37;
            this.button7.Text = "First";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(142, 259);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 31);
            this.button6.TabIndex = 36;
            this.button6.Text = "Previous";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(269, 259);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 31);
            this.button5.TabIndex = 35;
            this.button5.Text = "Next";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1330, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 42;
            this.button1.Text = "Last";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(795, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 31);
            this.button2.TabIndex = 41;
            this.button2.Text = "First";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(967, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 31);
            this.button3.TabIndex = 40;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1137, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 31);
            this.button4.TabIndex = 39;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1170, 490);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(161, 55);
            this.button9.TabIndex = 43;
            this.button9.Text = "Передать в Excel";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(926, 490);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(161, 55);
            this.button10.TabIndex = 44;
            this.button10.Text = "Передать в Word";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(676, 490);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(161, 56);
            this.button11.TabIndex = 45;
            this.button11.Text = "Диаграмма";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // checkBoxDiagram
            // 
            this.checkBoxDiagram.AutoSize = true;
            this.checkBoxDiagram.Location = new System.Drawing.Point(520, 521);
            this.checkBoxDiagram.Name = "checkBoxDiagram";
            this.checkBoxDiagram.Size = new System.Drawing.Size(112, 24);
            this.checkBoxDiagram.TabIndex = 46;
            this.checkBoxDiagram.Text = "Подробно";
            this.checkBoxDiagram.UseVisualStyleBackColor = true;
            this.checkBoxDiagram.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1500, 585);
            this.Controls.Add(this.checkBoxDiagram);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labelCountOfDaysForPeriod);
            this.Controls.Add(this.labelExpensesforPeriod);
            this.Controls.Add(this.labelProfit);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.labelDohod);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сведения о доходах гостиницы";
            this.Load += new System.EventHandler(this.Result_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofArivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofDepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.Label labelDohod;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelProfit;
        private System.Windows.Forms.Label labelExpensesforPeriod;
        private System.Windows.Forms.Label labelCountOfDaysForPeriod;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.CheckBox checkBoxDiagram;
    }
}