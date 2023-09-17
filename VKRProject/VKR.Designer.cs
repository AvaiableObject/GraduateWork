namespace VKRProject
{
    partial class VKR
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
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBoxU = new System.Windows.Forms.NumericUpDown();
            this.textBoxQ1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxQ2 = new System.Windows.Forms.NumericUpDown();
            this.textBoxN = new System.Windows.Forms.NumericUpDown();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxN)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMain
            // 
            this.textBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMain.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMain.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMain.Location = new System.Drawing.Point(12, 57);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ReadOnly = true;
            this.textBoxMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMain.Size = new System.Drawing.Size(626, 627);
            this.textBoxMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Натуральное число N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Натуральное число u:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Первое значение q1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Последнее значение q2:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 289);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(157, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Вывести n, r и k_i";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 319);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(123, 24);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Вывести m_i";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.numericUpDownLimit);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.textBoxU);
            this.groupBox1.Controls.Add(this.textBoxQ1);
            this.groupBox1.Controls.Add(this.textBoxQ2);
            this.groupBox1.Controls.Add(this.textBoxN);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(651, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод значений";
            // 
            // numericUpDownLimit
            // 
            this.numericUpDownLimit.DecimalPlaces = 4;
            this.numericUpDownLimit.Enabled = false;
            this.numericUpDownLimit.Location = new System.Drawing.Point(228, 248);
            this.numericUpDownLimit.Name = "numericUpDownLimit";
            this.numericUpDownLimit.Size = new System.Drawing.Size(184, 26);
            this.numericUpDownLimit.TabIndex = 17;
            this.numericUpDownLimit.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(21, 239);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(188, 44);
            this.checkBox4.TabIndex = 16;
            this.checkBox4.Text = "Ввести ограничение \r\nдля Cm:";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // textBoxU
            // 
            this.textBoxU.Location = new System.Drawing.Point(228, 90);
            this.textBoxU.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.textBoxU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBoxU.Name = "textBoxU";
            this.textBoxU.Size = new System.Drawing.Size(184, 26);
            this.textBoxU.TabIndex = 15;
            this.textBoxU.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxQ1
            // 
            this.textBoxQ1.Location = new System.Drawing.Point(228, 137);
            this.textBoxQ1.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.textBoxQ1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBoxQ1.Name = "textBoxQ1";
            this.textBoxQ1.Size = new System.Drawing.Size(184, 26);
            this.textBoxQ1.TabIndex = 14;
            this.textBoxQ1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBoxQ1.ValueChanged += new System.EventHandler(this.textBoxQ1_ValueChanged);
            // 
            // textBoxQ2
            // 
            this.textBoxQ2.Location = new System.Drawing.Point(228, 181);
            this.textBoxQ2.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.textBoxQ2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.textBoxQ2.Name = "textBoxQ2";
            this.textBoxQ2.Size = new System.Drawing.Size(184, 26);
            this.textBoxQ2.TabIndex = 13;
            this.textBoxQ2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(228, 39);
            this.textBoxN.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.textBoxN.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(184, 26);
            this.textBoxN.TabIndex = 12;
            this.textBoxN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(21, 350);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(272, 24);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "N-адическое разложение дроби";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Вывод значений:";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(775, 458);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(198, 45);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "Запуск вычислений";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(651, 661);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(441, 23);
            this.progressBar.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(798, 629);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Прогресс выполнения:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(775, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Приостановить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(775, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Продолжить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VKR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 696);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1001, 612);
            this.Name = "VKR";
            this.Text = "Вычисление арифметической автокорреляции";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxN)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.NumericUpDown textBoxU;
        private System.Windows.Forms.NumericUpDown textBoxQ1;
        private System.Windows.Forms.NumericUpDown textBoxN;
        private System.Windows.Forms.NumericUpDown textBoxQ2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownLimit;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

