using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Clientes
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2EJEG1D ;Initial Catalog = CLIENTES-B;Trusted_Connection=true;");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = textBox1.Text;
            string tipo =  comboBox1.Text;
            string cedula = textBox3.Text;
            string direccion = textBox4.Text;
            string telefono = textBox5.Text;
            string correo = textBox5.Text;
            string fecha_creacion = dateTimePicker1.Text;
            MessageBox.Show("Bienvenido como les va ");
            //string address = textBox4.Text;
        }
    }
}
