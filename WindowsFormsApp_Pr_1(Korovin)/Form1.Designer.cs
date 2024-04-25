namespace WindowsFormsApp_Pr_1_Korovin_
{
    partial class Form1
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программаРасчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Razdelenie = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteMenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.ReferenceMenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgrammMenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(489, 336);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 44);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Выход";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(103, 287);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(100, 44);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Рассчитать";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuTools,
            this.ReferenceMenuTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuTools
            // 
            this.FileMenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.Razdelenie,
            this.DeleteMenuTools,
            this.ExitMenuTools});
            this.FileMenuTools.Name = "FileMenuTools";
            this.FileMenuTools.Size = new System.Drawing.Size(48, 20);
            this.FileMenuTools.Text = "Файл";
            // 
            // рассчитатьToolStripMenuItem
            // 
            this.рассчитатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаРасчётыToolStripMenuItem});
            this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
            this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
            // 
            // программаРасчётыToolStripMenuItem
            // 
            this.программаРасчётыToolStripMenuItem.Name = "программаРасчётыToolStripMenuItem";
            this.программаРасчётыToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.программаРасчётыToolStripMenuItem.Text = "Программа \"Расчёты\"";
            this.программаРасчётыToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // Razdelenie
            // 
            this.Razdelenie.Name = "Razdelenie";
            this.Razdelenie.Size = new System.Drawing.Size(132, 6);
            // 
            // DeleteMenuTools
            // 
            this.DeleteMenuTools.Name = "DeleteMenuTools";
            this.DeleteMenuTools.Size = new System.Drawing.Size(135, 22);
            this.DeleteMenuTools.Text = "Очистить";
            this.DeleteMenuTools.Click += new System.EventHandler(this.DeleteMenuTools_Click);
            // 
            // ExitMenuTools
            // 
            this.ExitMenuTools.Name = "ExitMenuTools";
            this.ExitMenuTools.Size = new System.Drawing.Size(135, 22);
            this.ExitMenuTools.Text = "Выход";
            this.ExitMenuTools.Click += new System.EventHandler(this.ExitMenuTools_Click);
            // 
            // ReferenceMenuTools
            // 
            this.ReferenceMenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgrammMenuTools});
            this.ReferenceMenuTools.Name = "ReferenceMenuTools";
            this.ReferenceMenuTools.Size = new System.Drawing.Size(65, 20);
            this.ReferenceMenuTools.Text = "Справка";
            // 
            // AboutProgrammMenuTools
            // 
            this.AboutProgrammMenuTools.Name = "AboutProgrammMenuTools";
            this.AboutProgrammMenuTools.Size = new System.Drawing.Size(149, 22);
            this.AboutProgrammMenuTools.Text = "О программе";
            this.AboutProgrammMenuTools.Click += new System.EventHandler(this.AboutProgrammMenuTools_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(42, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Рабочий день врача                                                 8 час";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Колличество пациентов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Врач может принять                                         4 чел/час";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(357, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(226, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Сколько пациентов не принял врач:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(226, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Сколько пациентов успел принять врач:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btn_calc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчёты";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(70, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Задание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "сколько пациентов может принять врач за день.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Это приложение создано для того, чтобы рассчитать";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здравствуйте!!!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 383);
            this.tabControl1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(699, 451);
            this.MinimumSize = new System.Drawing.Size(699, 451);
            this.Name = "Form1";
            this.Text = "Моя программка";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuTools;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuTools;
        private System.Windows.Forms.ToolStripMenuItem ReferenceMenuTools;
        private System.Windows.Forms.ToolStripMenuItem AboutProgrammMenuTools;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программаРасчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator Razdelenie;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuTools;
    }
}

