using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form4();
            formulario.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new Form5();
            formulario.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new Form6();
            formulario.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new Form7();
            formulario.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formulario = new Form8();
            formulario.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9();
            formulario.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formulario = new Form10();
            formulario.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form formulario = new Form11();
            formulario.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form formulario = new Form12();
            formulario.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form formulario = new Form13();
            formulario.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
