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
            this.Raschetnayatable = new System.Windows.Forms.DataGridView();
            this.Колонна1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Колонна2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Колонна3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Колонна4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Raschetnayatable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnschet
            // 
            this.btnschet.Location = new System.Drawing.Point(245, 222);
            this.btnschet.Name = "btnschet";
            this.btnschet.Size = new System.Drawing.Size(85, 85);
            this.btnschet.TabIndex = 0;
            this.btnschet.Text = "Сalculate";
            this.btnschet.UseVisualStyleBackColor = true;
            this.btnschet.Click += new System.EventHandler(this.btnschet_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(245, 340);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(85, 85);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Очистить";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
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
            this.labelzaim.Location = new System.Drawing.Point(50, 284);
            this.labelzaim.Name = "labelzaim";
            this.labelzaim.Size = new System.Drawing.Size(102, 13);
            this.labelzaim.TabIndex = 3;
            this.labelzaim.Text = "Срок займа в днях";
            // 
            // labelprocent
            // 
            this.labelprocent.AutoSize = true;
            this.labelprocent.Location = new System.Drawing.Point(49, 170);
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
            this.boxsum.Location = new System.Drawing.Point(52, 72);
            this.boxsum.Name = "boxsum";
            this.boxsum.Size = new System.Drawing.Size(119, 20);
            this.boxsum.TabIndex = 6;
            this.boxsum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxsum_KeyPress);
            // 
            // boxdays
            // 
            this.boxdays.Location = new System.Drawing.Point(52, 340);
            this.boxdays.Name = "boxdays";
            this.boxdays.Size = new System.Drawing.Size(100, 20);
            this.boxdays.TabIndex = 8;
            this.boxdays.TextChanged += new System.EventHandler(this.boxdays_TextChanged);
            this.boxdays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxsum_KeyPress);
            // 
            // boxfullsum
            // 
            this.boxfullsum.Location = new System.Drawing.Point(379, 72);
            this.boxfullsum.Name = "boxfullsum";
            this.boxfullsum.ReadOnly = true;
            this.boxfullsum.Size = new System.Drawing.Size(289, 20);
            this.boxfullsum.TabIndex = 9;
            // 
            // cmbboxprocent
            // 
            this.cmbboxprocent.FormattingEnabled = true;
            this.cmbboxprocent.Items.AddRange(new object[] {
            "c 0 по 5 день-0.9%",
            "с 6 по 10 день-0.7%",
            "с 11 дня включительно-0.6%"});
            this.cmbboxprocent.Location = new System.Drawing.Point(51, 197);
            this.cmbboxprocent.Name = "cmbboxprocent";
            this.cmbboxprocent.Size = new System.Drawing.Size(158, 21);
            this.cmbboxprocent.TabIndex = 10;
            // 
            // Raschetnayatable
            // 
            this.Raschetnayatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Raschetnayatable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Колонна1,
            this.Колонна2,
            this.Колонна3,
            this.Колонна4});
            this.Raschetnayatable.Location = new System.Drawing.Point(379, 119);
            this.Raschetnayatable.Name = "Raschetnayatable";
            this.Raschetnayatable.Size = new System.Drawing.Size(444, 504);
            this.Raschetnayatable.TabIndex = 11;
            this.Raschetnayatable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Raschetnayatable_CellContentClick);
            // 
            // Колонна1
            // 
            this.Колонна1.HeaderText = "День";
            this.Колонна1.Name = "Колонна1";
            this.Колонна1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Колонна1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Колонна2
            // 
            this.Колонна2.HeaderText = "Ставка";
            this.Колонна2.Name = "Колонна2";
            // 
            // Колонна3
            // 
            this.Колонна3.HeaderText = "%Накопительный";
            this.Колонна3.Name = "Колонна3";
            // 
            // Колонна4
            // 
            this.Колонна4.HeaderText = "Сумма выплаты";
            this.Колонна4.Name = "Колонна4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 510);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 670);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Raschetnayatable);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Raschetnayatable)).EndInit();
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
        private System.Windows.Forms.DataGridView Raschetnayatable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Колонна1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Колонна2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Колонна3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Колонна4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

