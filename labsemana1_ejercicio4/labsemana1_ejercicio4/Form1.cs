using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labsemana1_ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int banderaTurno = 1;
        private void escribir(Button a)
        {
            if(a.Text == "")
            {
                if (banderaTurno == 1)
                {
                    a.Text = "X";

                    banderaTurno = 2;
                }
                else
                    if (banderaTurno == 2)
                    {
                        a.Text = "O";

                        banderaTurno = 1;
                    }
            }
            else
                if (a.Text != "")
            {
                MessageBox.Show("Seleccione otra casilla");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            escribir(btn9);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            escribir(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            escribir(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            escribir(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            escribir(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            escribir(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            escribir(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            escribir(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            escribir(btn8);
        }
    }
}
