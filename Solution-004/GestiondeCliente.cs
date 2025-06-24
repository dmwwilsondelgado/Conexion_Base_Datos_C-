using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //agregamos estos dos
using System.Data;//agregamos
namespace Solution_004
{
    public partial class GestiondeCliente : Form
    {
        string cadenaConexion = "Server=localhost;Database=base_datos_solution004;Uid=wilsondelgado;Pwd=1102717619;";
        public GestiondeCliente()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO clientes (nombre, documento, correo, telefono) VALUES (@nombre, @documento, @correo, @telefono)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
                    cmd.Parameters.AddWithValue("@documento", textBox2.Text);
                    cmd.Parameters.AddWithValue("@correo", textBox3.Text);
                    cmd.Parameters.AddWithValue("@telefono", textBox4.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente agregado exitosamente.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar cliente: " + ex.Message);
                }
            }
        }
    }
}
