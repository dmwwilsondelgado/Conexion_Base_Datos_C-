using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace solution_002
{
    public partial class GestiondePeliculas : Form
    {
        public GestiondePeliculas()
        {
            InitializeComponent();
        }
        string cadenaConexion = "Server=localhost;Database=base_datos_solution002;Uid=wilsondelgado;Pwd=1102717619;";

        private void btnAgregarPelicula_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open(); // abrimos la conexion
                    string consulta = "INSERT INTO peliculas (titulo,genero,duracion,clasificacion) values (@titulo,@genero,@duracion,@clasificacion)";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@titulo", txtTituloPelicula.Text); // los campos se agregan alas consultas en el insert 
                    comando.Parameters.AddWithValue("@genero", txtGeneroPelicula.Text); // los campos se agregan alas consultas en el insert 
                    comando.Parameters.AddWithValue("@duracion",numericDuracionPelicula.Text);
                    comando.Parameters.AddWithValue("@clasificacion",cmbxClasificacionPelicula.Text.ToString());
                    comando.ExecuteNonQuery(); // metodo que crea modifica y elemina tablas 

                    MessageBox.Show("Contacto Guardado"); // mostramos un mensaje que nos muestra si este se envio ala base de datos 

                    txtTituloPelicula.Clear();
                    txtGeneroPelicula.Clear();
                    cmbxClasificacionPelicula.Items.Clear();
                   
                    
                    GestiondePeliculas f2 = new GestiondePeliculas();
                    f2.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errro" + ex.Message);
                }
            }
        }
    }
}
