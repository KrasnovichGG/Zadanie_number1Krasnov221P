using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_number1Krasnov221P
{
    public partial class Form1 : Form
    {
        int days = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnschet_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(boxsum.Text);
            days = Convert.ToInt32(boxdays.Text);
            if (a >= 500001)
            {
                MessageBox.Show("Более 500 тысяч не даём!");
                Application.Restart();
            }
            if (days > 0 && days < 6)
            {
                cmbboxprocent.Text = "c 0 по 5 день-0.9%";
            }
            if(days > 5 && days < 11)
            {
                cmbboxprocent.Text = "с 6 по 10 день-0.7%";
            }
            if(days > 10 && days < 366)
            {
                cmbboxprocent.Text = "с 11 дня включительно-0.6%";
            }
            switch (cmbboxprocent.Text)
            {
                case "c 0 по 5 день-0.9%":
                    if (days > 0 && days < 6)
                    {
                        double h = (a / 100) * 0.9 * days + a;
                        if((a * 2.5) < h)
                        {
                            h = a * 2.5;
                            MessageBox.Show("Размер выплаты по микрозайму не может превышать 2,5-кратного размера суммы займа");
                        }
                        boxfullsum.Text = Convert.ToString(h);
                        break;
                    }
                    MessageBox.Show("Принимает дни от 0 до 5!");
                    Application.Restart();
                    break;
                case "с 6 по 10 день-0.7%":
                    if (days > 5 && days < 11)
                    {
                        double v = ((a / 100) * 0.9 * 5) + ((a / 100) * 0.7 * (days - 5) + a);
                        if ((a * 2.5) < v)
                        {
                            v = a * 2.5;
                            MessageBox.Show("Размер выплаты по микрозайму не может превышать 2,5-кратного размера суммы займа");
                        }
                        boxfullsum.Text = Convert.ToString(v);
                        break;
                    }
                    MessageBox.Show("Принимает дни от 6 до 10!");
                    Application.Restart();
                    break;
                case "с 11 дня включительно-0.6%":
                    if (days > 10 && days < 366)
                    {
                        double d = ((a / 100) * 0.9 * 5) + ((a / 100) * 0.7 * 5) + ((a / 100) * 0.6 * (days - 10) + a);
                        if ((a * 2.5) < d)
                        {
                            d = a * 2.5;
                            MessageBox.Show("Размер выплаты по микрозайму не может превышать 2,5-кратного размера суммы займа");
                        }
                        boxfullsum.Text = Convert.ToString(d);
                        break;
                    }
                    MessageBox.Show("Принимает дни от 11 до 365!");
                    Application.Restart();
                    break;
            }
            //Raschetnayatable.Rows.Add(row);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            boxdays.Text = "";
            boxfullsum.Text = "";
            boxsum.Text = "";
            cmbboxprocent.Text = "";
        }

        private void Raschetnayatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void boxsum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void boxdays_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(boxsum, "Введите сумму вашего займа");
            t.SetToolTip(boxdays, "На сколько дней хотите займ");
            t.SetToolTip(boxfullsum, "Сумма вашей выплаты");
            t.SetToolTip(cmbboxprocent, "Проценты по вашим дням");

        }
    }
}
