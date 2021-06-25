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
            switch (cmbboxprocent.Text)
            {
                case "c 0 по 5 день-0.9%":
                    if (days > 0 && days < 6)
                    {
                        boxfullsum.Text = Convert.ToString((a / 100)* 0.9 * days + a);
                        break;
                    }
                    MessageBox.Show("Принимает дни от 0 до 5!");
                    Application.Restart();
                    break;
                case "С 6 по 10 день 0.7%":
                    if (days > 5 && days < 11)
                    {
                        boxfullsum.Text = Convert.ToString(((a / 100) * 0.9 * 5) + ((a / 100) * 0.7 * (days - 5) + a));
                        break;
                    }
                    MessageBox.Show("Принимает дни от 6 до 10!");
                    Application.Restart();
                    break;
                case "с 6 по 10 день - 0.7 %":
                    boxfullsum.Text = Convert.ToString((a / 100) * 0.7 * days + a);
                    break;
                    case "с 11 дня включительно -0.6 %":
                    boxfullsum.Text = Convert.ToString((a / 100) * 0.6 * days + a);
                    break;
        


            }
        }
    }
}
