using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Logica;


namespace Capa_Diseño
{
    public partial class Form7 : Form
    {
        clsControlador logi = new clsControlador();
        public Form7()
        {
            InitializeComponent();
        }
        public void mostrar_consulta()
        {
            OdbcDataReader mostrar = logi.consultar("vendedores"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            if (logi.insertar_vendedores(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta();
                string[] valores = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text };

                if (logi.insertar_vendedores(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text }; //valores a ingresar
            if (logi.modificar_vendedores(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();

        }
    }
}
