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
    public partial class Form6 : Form
    {
        clsControlador logi = new clsControlador();
        public Form6()
        {
            InitializeComponent();
        }
        public void mostrar_consulta()
        {
            OdbcDataReader mostrar = logi.consultar("existencias"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox1.Text, textBox2.Text, textBox3.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            if (logi.insertar_existencias(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta();
                string[] valores = { textBox1.Text, textBox2.Text, textBox3.Text };

                if (logi.insertar_existencias(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox1.Text, textBox2.Text, textBox3.Text }; //valores a ingresar
            if (logi.modificar_existencias(valores) == null)
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
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

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
