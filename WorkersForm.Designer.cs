namespace HotelManagementSystem
{
    partial class WorkersForm
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
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.workerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxFindWorker = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.textBoxWorkerDelete = new System.Windows.Forms.TextBox();
            this.buttonCountOfClients = new System.Windows.Forms.Button();
            this.textBoxCountOfWorkers = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxChooseGender = new System.Windows.Forms.CheckBox();
            this.checkBoxChoosePosition = new System.Windows.Forms.CheckBox();
            this.checkBoxSort1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSort2 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxSumm = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBoxSalary = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1534, 111);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(407, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Workers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genderDataGridViewTextBoxColumn,
            this.workerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.workPositionDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 327);
            this.dataGridView1.TabIndex = 1;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.genderDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.genderDataGridViewTextBoxColumn.Width = 150;
            // 
            // workerIDDataGridViewTextBoxColumn
            // 
            this.workerIDDataGridViewTextBoxColumn.DataPropertyName = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.HeaderText = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.workerIDDataGridViewTextBoxColumn.Name = "workerIDDataGridViewTextBoxColumn";
            this.workerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // workPositionDataGridViewTextBoxColumn
            // 
            this.workPositionDataGridViewTextBoxColumn.DataPropertyName = "WorkPosition";
            this.workPositionDataGridViewTextBoxColumn.HeaderText = "WorkPosition";
            this.workPositionDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Менеджер отдела продаж",
            "Менеджер отдела питания",
            "Главная горничная",
            "Администратор",
            "Бухгалтер",
            "Горничная",
            "Секретарь-ресепшионист",
            "Шеф-повар",
            "Повар",
            "Бармен",
            "Официант",
            "Маркетолог",
            "Электрик",
            "Сантехник",
            "Портье"});
            this.workPositionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.workPositionDataGridViewTextBoxColumn.Name = "workPositionDataGridViewTextBoxColumn";
            this.workPositionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workPositionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1397, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.новыйToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = global::HotelManagementSystem.Properties.Resources.открыть;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(233, 34);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Image = global::HotelManagementSystem.Properties.Resources.новый_файл;
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(233, 34);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = global::HotelManagementSystem.Properties.Resources.save;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(233, 34);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Image = global::HotelManagementSystem.Properties.Resources.сохранить_как;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(233, 34);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить Как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "workers.txt";
            this.openFileDialog1.Filter = "Текстовый файл|*.txt|Все файлы|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Текстовый файл|*.txt|Все файлы|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(383, 468);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 31);
            this.button8.TabIndex = 38;
            this.button8.Text = "Last";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 468);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 31);
            this.button7.TabIndex = 37;
            this.button7.Text = "First";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(126, 468);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 31);
            this.button6.TabIndex = 36;
            this.button6.Text = "Previous";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(252, 468);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 31);
            this.button5.TabIndex = 35;
            this.button5.Text = "Next";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxFindWorker
            // 
            this.textBoxFindWorker.Location = new System.Drawing.Point(922, 657);
            this.textBoxFindWorker.Name = "textBoxFindWorker";
            this.textBoxFindWorker.Size = new System.Drawing.Size(87, 26);
            this.textBoxFindWorker.TabIndex = 45;
            this.textBoxFindWorker.TextChanged += new System.EventHandler(this.textBoxFindClient_TextChanged);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.MediumOrchid;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(737, 605);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(179, 86);
            this.button9.TabIndex = 44;
            this.button9.Text = "Поиск по работникам";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBoxWorkerDelete
            // 
            this.textBoxWorkerDelete.Location = new System.Drawing.Point(921, 558);
            this.textBoxWorkerDelete.Name = "textBoxWorkerDelete";
            this.textBoxWorkerDelete.Size = new System.Drawing.Size(88, 26);
            this.textBoxWorkerDelete.TabIndex = 43;
            // 
            // buttonCountOfClients
            // 
            this.buttonCountOfClients.BackColor = System.Drawing.Color.Plum;
            this.buttonCountOfClients.Location = new System.Drawing.Point(1062, 544);
            this.buttonCountOfClients.Name = "buttonCountOfClients";
            this.buttonCountOfClients.Size = new System.Drawing.Size(105, 46);
            this.buttonCountOfClients.TabIndex = 42;
            this.buttonCountOfClients.Text = "Посчитать";
            this.buttonCountOfClients.UseVisualStyleBackColor = false;
            this.buttonCountOfClients.Click += new System.EventHandler(this.buttonCountOfClients_Click);
            // 
            // textBoxCountOfWorkers
            // 
            this.textBoxCountOfWorkers.Location = new System.Drawing.Point(1293, 505);
            this.textBoxCountOfWorkers.Name = "textBoxCountOfWorkers";
            this.textBoxCountOfWorkers.ReadOnly = true;
            this.textBoxCountOfWorkers.Size = new System.Drawing.Size(100, 26);
            this.textBoxCountOfWorkers.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1046, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Общее кол-во работников =";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumOrchid;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(737, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 85);
            this.button3.TabIndex = 39;
            this.button3.Text = "Удалить работника по ID";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.checkBoxChooseGender);
            this.panel3.Controls.Add(this.checkBoxChoosePosition);
            this.panel3.Location = new System.Drawing.Point(235, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 70);
            this.panel3.TabIndex = 50;
            // 
            // checkBoxChooseGender
            // 
            this.checkBoxChooseGender.AutoSize = true;
            this.checkBoxChooseGender.Location = new System.Drawing.Point(3, 7);
            this.checkBoxChooseGender.Name = "checkBoxChooseGender";
            this.checkBoxChooseGender.Size = new System.Drawing.Size(162, 24);
            this.checkBoxChooseGender.TabIndex = 15;
            this.checkBoxChooseGender.Text = "Выборка по полу";
            this.checkBoxChooseGender.UseVisualStyleBackColor = true;
            // 
            // checkBoxChoosePosition
            // 
            this.checkBoxChoosePosition.AutoSize = true;
            this.checkBoxChoosePosition.Location = new System.Drawing.Point(3, 35);
            this.checkBoxChoosePosition.Name = "checkBoxChoosePosition";
            this.checkBoxChoosePosition.Size = new System.Drawing.Size(212, 24);
            this.checkBoxChoosePosition.TabIndex = 9;
            this.checkBoxChoosePosition.Text = "Выборка по должности";
            this.checkBoxChoosePosition.UseVisualStyleBackColor = true;
            // 
            // checkBoxSort1
            // 
            this.checkBoxSort1.AutoSize = true;
            this.checkBoxSort1.Location = new System.Drawing.Point(3, 3);
            this.checkBoxSort1.Name = "checkBoxSort1";
            this.checkBoxSort1.Size = new System.Drawing.Size(174, 24);
            this.checkBoxSort1.TabIndex = 46;
            this.checkBoxSort1.Text = "Сортировать по id";
            this.checkBoxSort1.UseVisualStyleBackColor = true;
            // 
            // checkBoxSort2
            // 
            this.checkBoxSort2.AutoSize = true;
            this.checkBoxSort2.Location = new System.Drawing.Point(3, 33);
            this.checkBoxSort2.Name = "checkBoxSort2";
            this.checkBoxSort2.Size = new System.Drawing.Size(209, 24);
            this.checkBoxSort2.TabIndex = 47;
            this.checkBoxSort2.Text = "Сортировать по имени";
            this.checkBoxSort2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.comboBoxGender);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.comboBoxPosition);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(0, 505);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 181);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(479, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 69);
            this.button2.TabIndex = 59;
            this.button2.Text = "Выбрать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumOrchid;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 69);
            this.button1.TabIndex = 46;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkBoxSalary);
            this.panel4.Controls.Add(this.checkBoxSort2);
            this.panel4.Controls.Add(this.checkBoxSort1);
            this.panel4.Location = new System.Drawing.Point(479, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 90);
            this.panel4.TabIndex = 58;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(235, 64);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(118, 28);
            this.comboBoxGender.TabIndex = 57;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Менеджер отдела продаж",
            "Менеджер отдела питания",
            "Главная горничная",
            "Администратор",
            "Бухгалтер",
            "Горничная",
            "Секретарь-ресепшионист",
            "Шеф-повар",
            "Повар",
            "Бармен",
            "Официант",
            "Маркетолог",
            "Электрик",
            "Сантехник",
            "Портье"});
            this.comboBoxPosition.Location = new System.Drawing.Point(235, 20);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(116, 28);
            this.comboBoxPosition.TabIndex = 56;
            this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosition_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(357, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(99, 26);
            this.textBox2.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 32);
            this.label5.TabIndex = 54;
            this.label5.Text = "Пол";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 52;
            this.label2.Text = "Должность";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(99, 26);
            this.textBox1.TabIndex = 53;
            // 
            // textBoxSumm
            // 
            this.textBoxSumm.Location = new System.Drawing.Point(1283, 286);
            this.textBoxSumm.Name = "textBoxSumm";
            this.textBoxSumm.Size = new System.Drawing.Size(100, 26);
            this.textBoxSumm.TabIndex = 46;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Plum;
            this.button4.Location = new System.Drawing.Point(1062, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 68);
            this.button4.TabIndex = 47;
            this.button4.Text = "Изменить сумму прочих расходов";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBoxSalary
            // 
            this.checkBoxSalary.AutoSize = true;
            this.checkBoxSalary.Location = new System.Drawing.Point(3, 63);
            this.checkBoxSalary.Name = "checkBoxSalary";
            this.checkBoxSalary.Size = new System.Drawing.Size(234, 24);
            this.checkBoxSalary.TabIndex = 48;
            this.checkBoxSalary.Text = "Сортировать по зарплате";
            this.checkBoxSalary.UseVisualStyleBackColor = true;
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1397, 760);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxSumm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxFindWorker);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBoxWorkerDelete);
            this.Controls.Add(this.buttonCountOfClients);
            this.Controls.Add(this.textBoxCountOfWorkers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorkersForm";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.WorkersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewComboBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn workPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxFindWorker;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBoxWorkerDelete;
        private System.Windows.Forms.Button buttonCountOfClients;
        private System.Windows.Forms.TextBox textBoxCountOfWorkers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxChooseGender;
        private System.Windows.Forms.CheckBox checkBoxChoosePosition;
        private System.Windows.Forms.CheckBox checkBoxSort1;
        private System.Windows.Forms.CheckBox checkBoxSort2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxSumm;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBoxSalary;
    }
}