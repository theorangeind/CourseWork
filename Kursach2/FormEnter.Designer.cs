namespace ParkingDataBase
{
    partial class FormEnter
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
            this.tableLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createPassword = new System.Windows.Forms.TextBox();
            this.checkPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableLength)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLength
            // 
            this.tableLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLength.Location = new System.Drawing.Point(351, 59);
            this.tableLength.Margin = new System.Windows.Forms.Padding(4);
            this.tableLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tableLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tableLength.Name = "tableLength";
            this.tableLength.Size = new System.Drawing.Size(136, 26);
            this.tableLength.TabIndex = 0;
            this.tableLength.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начало работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите количество парковочных мест:";
            // 
            // createPassword
            // 
            this.createPassword.Location = new System.Drawing.Point(368, 134);
            this.createPassword.Name = "createPassword";
            this.createPassword.PasswordChar = '•';
            this.createPassword.Size = new System.Drawing.Size(187, 22);
            this.createPassword.TabIndex = 3;
            // 
            // checkPassword
            // 
            this.checkPassword.Location = new System.Drawing.Point(368, 197);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.PasswordChar = '•';
            this.checkPassword.Size = new System.Drawing.Size(187, 22);
            this.checkPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(531, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите пароль, который будет использоваться для получения доступа к базе:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "( Используйте буквенные символы, цифры и знак \'_\' )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Подтвердите пароль:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(147, 240);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(292, 56);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Начать работу";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(345, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Пароль должен содержать минимум 4 буквы/цифры";
            // 
            // FormEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 319);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkPassword);
            this.Controls.Add(this.createPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLength);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEnter";
            this.ShowIcon = false;
            this.Text = "Создание базы данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEnter_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tableLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown tableLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox createPassword;
        private System.Windows.Forms.TextBox checkPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label6;
    }
}