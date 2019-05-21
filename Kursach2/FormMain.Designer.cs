namespace ParkingDataBase
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Space = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parked = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Paid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.paymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.debugLog = new System.Windows.Forms.TextBox();
            this.freeSpaceButton = new System.Windows.Forms.Button();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.carBrand = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toTable = new System.Windows.Forms.Button();
            this.getUnpaidButton = new System.Windows.Forms.Button();
            this.deleteBySurname = new System.Windows.Forms.Button();
            this.dateDay = new System.Windows.Forms.NumericUpDown();
            this.dateMonth = new System.Windows.Forms.NumericUpDown();
            this.dateYear = new System.Windows.Forms.NumericUpDown();
            this.changePaymentDateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.placeAfterButton = new System.Windows.Forms.Button();
            this.targetSurname = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateYear)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Space,
            this.FullName,
            this.Car,
            this.Parked,
            this.Paid,
            this.paymentDate,
            this.DelButton});
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(893, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Space
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Space.DefaultCellStyle = dataGridViewCellStyle2;
            this.Space.HeaderText = "№ места";
            this.Space.MinimumWidth = 20;
            this.Space.Name = "Space";
            this.Space.ReadOnly = true;
            this.Space.ToolTipText = "Номер парковочного места";
            this.Space.Width = 120;
            // 
            // FullName
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullName.DefaultCellStyle = dataGridViewCellStyle3;
            this.FullName.HeaderText = "Ф.И.О.";
            this.FullName.MinimumWidth = 100;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.ToolTipText = "Фамилия, имя, отчество клиента";
            this.FullName.Width = 200;
            // 
            // Car
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Car.DefaultCellStyle = dataGridViewCellStyle4;
            this.Car.HeaderText = "Автомобиль";
            this.Car.MinimumWidth = 100;
            this.Car.Name = "Car";
            this.Car.ReadOnly = true;
            this.Car.ToolTipText = "Автомобиль клиента";
            this.Car.Width = 130;
            // 
            // Parked
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parked.DefaultCellStyle = dataGridViewCellStyle5;
            this.Parked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Parked.HeaderText = "Припаркован";
            this.Parked.MinimumWidth = 20;
            this.Parked.Name = "Parked";
            this.Parked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Parked.Text = "";
            this.Parked.ToolTipText = "Наличие автомобиля на парковочном месте";
            this.Parked.Width = 140;
            // 
            // Paid
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Paid.DefaultCellStyle = dataGridViewCellStyle6;
            this.Paid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paid.HeaderText = "Оплачено";
            this.Paid.MinimumWidth = 20;
            this.Paid.Name = "Paid";
            this.Paid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Paid.ToolTipText = "Наличие оплаты парковочного места";
            this.Paid.Width = 110;
            // 
            // paymentDate
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.paymentDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.paymentDate.HeaderText = "Дата оплаты";
            this.paymentDate.MinimumWidth = 40;
            this.paymentDate.Name = "paymentDate";
            this.paymentDate.ReadOnly = true;
            this.paymentDate.ToolTipText = "Дата последней оплаты";
            this.paymentDate.Width = 148;
            // 
            // DelButton
            // 
            this.DelButton.HeaderText = "";
            this.DelButton.Name = "DelButton";
            this.DelButton.ReadOnly = true;
            this.DelButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DelButton.Text = "❌";
            this.DelButton.ToolTipText = "Удалить";
            this.DelButton.UseColumnTextForButtonValue = true;
            this.DelButton.Width = 22;
            // 
            // debugLog
            // 
            this.debugLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debugLog.Location = new System.Drawing.Point(12, 487);
            this.debugLog.Multiline = true;
            this.debugLog.Name = "debugLog";
            this.debugLog.ReadOnly = true;
            this.debugLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugLog.Size = new System.Drawing.Size(893, 132);
            this.debugLog.TabIndex = 1;
            // 
            // freeSpaceButton
            // 
            this.freeSpaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeSpaceButton.Location = new System.Drawing.Point(911, 551);
            this.freeSpaceButton.Name = "freeSpaceButton";
            this.freeSpaceButton.Size = new System.Drawing.Size(176, 48);
            this.freeSpaceButton.TabIndex = 2;
            this.freeSpaceButton.Text = "Свободные места";
            this.freeSpaceButton.UseVisualStyleBackColor = true;
            this.freeSpaceButton.Click += new System.EventHandler(this.FreeSpaceButton_Click);
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(1089, 149);
            this.surname.MaxLength = 40;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(176, 22);
            this.surname.TabIndex = 3;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(1089, 175);
            this.name.MaxLength = 40;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(176, 22);
            this.name.TabIndex = 4;
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastname.Location = new System.Drawing.Point(1089, 201);
            this.lastname.MaxLength = 40;
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(176, 22);
            this.lastname.TabIndex = 5;
            // 
            // carBrand
            // 
            this.carBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carBrand.Location = new System.Drawing.Point(1089, 250);
            this.carBrand.MaxLength = 40;
            this.carBrand.Name = "carBrand";
            this.carBrand.Size = new System.Drawing.Size(176, 22);
            this.carBrand.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(1089, 55);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(176, 22);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1002, 149);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1043, 175);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1000, 201);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1009, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "№ места";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(979, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Автомобиль";
            // 
            // toTable
            // 
            this.toTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toTable.Location = new System.Drawing.Point(983, 278);
            this.toTable.Name = "toTable";
            this.toTable.Size = new System.Drawing.Size(282, 49);
            this.toTable.TabIndex = 13;
            this.toTable.Text = "Занести в таблицу";
            this.toTable.UseVisualStyleBackColor = true;
            this.toTable.Click += new System.EventHandler(this.ToTable_Click);
            // 
            // getUnpaidButton
            // 
            this.getUnpaidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getUnpaidButton.Location = new System.Drawing.Point(1093, 551);
            this.getUnpaidButton.Name = "getUnpaidButton";
            this.getUnpaidButton.Size = new System.Drawing.Size(176, 48);
            this.getUnpaidButton.TabIndex = 14;
            this.getUnpaidButton.Text = "Задолженности";
            this.getUnpaidButton.UseVisualStyleBackColor = true;
            this.getUnpaidButton.Click += new System.EventHandler(this.GetUnpaidButton_Click);
            // 
            // deleteBySurname
            // 
            this.deleteBySurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBySurname.Location = new System.Drawing.Point(1089, 95);
            this.deleteBySurname.Name = "deleteBySurname";
            this.deleteBySurname.Size = new System.Drawing.Size(176, 48);
            this.deleteBySurname.TabIndex = 16;
            this.deleteBySurname.Text = "Удалить по фамилии:";
            this.deleteBySurname.UseVisualStyleBackColor = true;
            this.deleteBySurname.Click += new System.EventHandler(this.DeleteBySurname_Click);
            // 
            // dateDay
            // 
            this.dateDay.Location = new System.Drawing.Point(911, 435);
            this.dateDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dateDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dateDay.Name = "dateDay";
            this.dateDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateDay.Size = new System.Drawing.Size(52, 20);
            this.dateDay.TabIndex = 17;
            this.dateDay.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dateDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateMonth
            // 
            this.dateMonth.Location = new System.Drawing.Point(969, 435);
            this.dateMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.dateMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dateMonth.Name = "dateMonth";
            this.dateMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateMonth.Size = new System.Drawing.Size(52, 20);
            this.dateMonth.TabIndex = 18;
            this.dateMonth.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dateMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dateMonth.ValueChanged += new System.EventHandler(this.DateMonth_ValueChanged);
            // 
            // dateYear
            // 
            this.dateYear.Location = new System.Drawing.Point(1027, 435);
            this.dateYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.dateYear.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.dateYear.Name = "dateYear";
            this.dateYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateYear.Size = new System.Drawing.Size(78, 20);
            this.dateYear.TabIndex = 19;
            this.dateYear.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dateYear.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.dateYear.ValueChanged += new System.EventHandler(this.DateYear_ValueChanged);
            // 
            // changePaymentDateButton
            // 
            this.changePaymentDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePaymentDateButton.Location = new System.Drawing.Point(911, 461);
            this.changePaymentDateButton.Name = "changePaymentDateButton";
            this.changePaymentDateButton.Size = new System.Drawing.Size(354, 48);
            this.changePaymentDateButton.TabIndex = 20;
            this.changePaymentDateButton.Text = "Изменить дату оплаты";
            this.changePaymentDateButton.UseVisualStyleBackColor = true;
            this.changePaymentDateButton.Click += new System.EventHandler(this.ChangePaymentDateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1128, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "(Укажите фамилию)";
            // 
            // placeAfterButton
            // 
            this.placeAfterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeAfterButton.Location = new System.Drawing.Point(911, 370);
            this.placeAfterButton.Name = "placeAfterButton";
            this.placeAfterButton.Size = new System.Drawing.Size(176, 27);
            this.placeAfterButton.TabIndex = 22;
            this.placeAfterButton.Text = "Занести после ->";
            this.placeAfterButton.UseVisualStyleBackColor = true;
            this.placeAfterButton.Click += new System.EventHandler(this.PlaceAfterButton_Click);
            // 
            // targetSurname
            // 
            this.targetSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetSurname.Location = new System.Drawing.Point(1093, 373);
            this.targetSurname.MaxLength = 40;
            this.targetSurname.Name = "targetSurname";
            this.targetSurname.Size = new System.Drawing.Size(176, 22);
            this.targetSurname.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.refreshToolStripMenuItem.Text = "Обновить";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // helpTextBox
            // 
            this.helpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpTextBox.Location = new System.Drawing.Point(0, 27);
            this.helpTextBox.Multiline = true;
            this.helpTextBox.Name = "helpTextBox";
            this.helpTextBox.ReadOnly = true;
            this.helpTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.helpTextBox.Size = new System.Drawing.Size(1277, 603);
            this.helpTextBox.TabIndex = 25;
            this.helpTextBox.Text = resources.GetString("helpTextBox.Text");
            this.helpTextBox.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(911, 96);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(168, 48);
            this.searchButton.TabIndex = 26;
            this.searchButton.Text = "Найти по фамилии";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 631);
            this.Controls.Add(this.helpTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.targetSurname);
            this.Controls.Add(this.placeAfterButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.changePaymentDateButton);
            this.Controls.Add(this.dateYear);
            this.Controls.Add(this.dateMonth);
            this.Controls.Add(this.dateDay);
            this.Controls.Add(this.deleteBySurname);
            this.Controls.Add(this.getUnpaidButton);
            this.Controls.Add(this.toTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.freeSpaceButton);
            this.Controls.Add(this.debugLog);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "База";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateYear)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox debugLog;
        private System.Windows.Forms.Button freeSpaceButton;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox carBrand;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button toTable;
        private System.Windows.Forms.Button getUnpaidButton;
        private System.Windows.Forms.Button deleteBySurname;
        private System.Windows.Forms.NumericUpDown dateDay;
        private System.Windows.Forms.NumericUpDown dateMonth;
        private System.Windows.Forms.NumericUpDown dateYear;
        private System.Windows.Forms.Button changePaymentDateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button placeAfterButton;
        private System.Windows.Forms.TextBox targetSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Space;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car;
        private System.Windows.Forms.DataGridViewButtonColumn Parked;
        private System.Windows.Forms.DataGridViewButtonColumn Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDate;
        private System.Windows.Forms.DataGridViewButtonColumn DelButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox helpTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}

