namespace Zadanie_number1Krasnov221P
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
            this.btnschet = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.labelsum = new System.Windows.Forms.Label();
            this.labelzaim = new System.Windows.Forms.Label();
            this.labelprocent = new System.Windows.Forms.Label();
            this.labelpolnsum = new System.Windows.Forms.Label();
            this.boxsum = new System.Windows.Forms.TextBox();
            this.boxdays = new System.Windows.Forms.TextBox();
            this.boxfullsum = new System.Windows.Forms.TextBox();
            this.cmbboxprocent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnschet
            // 
            this.btnschet.Location = new System.Drawing.Point(583, 197);
            this.btnschet.Name = "btnschet";
            this.btnschet.Size = new System.Drawing.Size(85, 85);
            this.btnschet.TabIndex = 0;
            this.btnschet.Text = "Сalculate";
            this.btnschet.UseVisualStyleBackColor = true;
            this.btnschet.Click += new System.EventHandler(this.btnschet_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(583, 307);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(85, 85);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Очистить";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // labelsum
            // 
            this.labelsum.AutoSize = true;
            this.labelsum.Location = new System.Drawing.Point(48, 43);
            this.labelsum.Name = "labelsum";
            this.labelsum.Size = new System.Drawing.Size(122, 13);
            this.labelsum.TabIndex = 2;
            this.labelsum.Text = "Сумма займа в рублях";
            // 
            // labelzaim
            // 
            this.labelzaim.AutoSize = true;
            this.labelzaim.Location = new System.Drawing.Point(48, 282);
            this.labelzaim.Name = "labelzaim";
            this.labelzaim.Size = new System.Drawing.Size(102, 13);
            this.labelzaim.TabIndex = 3;
            this.labelzaim.Text = "Срок займа в днях";
            // 
            // labelprocent
            // 
            this.labelprocent.AutoSize = true;
            this.labelprocent.Location = new System.Drawing.Point(48, 165);
            this.labelprocent.Name = "labelprocent";
            this.labelprocent.Size = new System.Drawing.Size(102, 13);
            this.labelprocent.TabIndex = 4;
            this.labelprocent.Text = "Проценты по дням";
            // 
            // labelpolnsum
            // 
            this.labelpolnsum.AutoSize = true;
            this.labelpolnsum.Location = new System.Drawing.Point(376, 43);
            this.labelpolnsum.Name = "labelpolnsum";
            this.labelpolnsum.Size = new System.Drawing.Size(165, 13);
            this.labelpolnsum.TabIndex = 5;
            this.labelpolnsum.Text = "Полная выплачиваемая сумма";
            // 
            // boxsum
            // 
            this.boxsum.Location = new System.Drawing.Point(51, 72);
            this.boxsum.Name = "boxsum";
            this.boxsum.Size = new System.Drawing.Size(119, 20);
            this.boxsum.TabIndex = 6;
            // 
            // boxdays
            // 
            this.boxdays.Location = new System.Drawing.Point(51, 340);
            this.boxdays.Name = "boxdays";
            this.boxdays.Size = new System.Drawing.Size(100, 20);
            this.boxdays.TabIndex = 8;
            // 
            // boxfullsum
            // 
            this.boxfullsum.Location = new System.Drawing.Point(379, 72);
            this.boxfullsum.Name = "boxfullsum";
            this.boxfullsum.Size = new System.Drawing.Size(289, 20);
            this.boxfullsum.TabIndex = 9;
            // 
            // cmbboxprocent
            // 
            this.cmbboxprocent.FormattingEnabled = true;
            this.cmbboxprocent.Items.AddRange(new object[] {
            "c 0 по 5 день-0.9%",
            "с 6 по 10 день-0.7%",
            "с 11 дня включительно-0.6 %"});
            this.cmbboxprocent.Location = new System.Drawing.Point(51, 197);
            this.cmbboxprocent.Name = "cmbboxprocent";
            this.cmbboxprocent.Size = new System.Drawing.Size(121, 21);
            this.cmbboxprocent.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbboxprocent);
            this.Controls.Add(this.boxfullsum);
            this.Controls.Add(this.boxdays);
            this.Controls.Add(this.boxsum);
            this.Controls.Add(this.labelpolnsum);
            this.Controls.Add(this.labelprocent);
            this.Controls.Add(this.labelzaim);
            this.Controls.Add(this.labelsum);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnschet);
            this.Name = "Form1";
            this.Text = "Калькулятор микрокредита";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnschet;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label labelsum;
        private System.Windows.Forms.Label labelzaim;
        private System.Windows.Forms.Label labelprocent;
        private System.Windows.Forms.Label labelpolnsum;
        private System.Windows.Forms.TextBox boxsum;
        private System.Windows.Forms.TextBox boxdays;
        private System.Windows.Forms.TextBox boxfullsum;
        private System.Windows.Forms.ComboBox cmbboxprocent;
    }
}

