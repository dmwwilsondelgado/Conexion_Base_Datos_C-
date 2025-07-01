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

namespace Solution_005
{
    public partial class Empleados : Form
    {
        string cadenaConexion = "Server=localhost;Database=base_datos_solution005;Uid=wilsondelgado;Pwd=1102717619";
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnRegistarEmpleado_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO empleados (nombre, documento, rol, correo) VALUES (@nombre, @documento, @rol, @correo)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", txtName.Text);
                    cmd.Parameters.AddWithValue("@documento", txtDocumento.Text);
                    cmd.Parameters.AddWithValue("@rol", txtRol.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("cliente agregado exitoxamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }
        }
    }
}
