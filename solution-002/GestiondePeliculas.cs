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
                    comando.Parameters.AddWithValue("@duracion", numericDuracionPelicula.Text);
                    comando.Parameters.AddWithValue("@clasificacion", cmbxClasificacionPelicula.Text.ToString());
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

        private void btnEditarPelicula_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open(); // abrimos la conexión

                    string consulta = "UPDATE peliculas SET titulo = @titulo, genero = @genero, duracion = @duracion, clasificacion = @clasificacion WHERE id_pelicula = @id";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    // Parámetros a modificar
                    comando.Parameters.AddWithValue("@titulo", txtTituloPelicula.Text);
                    comando.Parameters.AddWithValue("@genero", txtGeneroPelicula.Text);
                    comando.Parameters.AddWithValue("@duracion", numericDuracionPelicula.Text);
                    comando.Parameters.AddWithValue("@clasificacion", cmbxClasificacionPelicula.Text.ToString());

                    // Parámetro clave (asegúrate de tenerlo)
                    comando.Parameters.AddWithValue("@id", int.Parse(txtIdPelicula.Text)); // Este campo debe contener el ID de la película que quieres editar

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Película actualizada correctamente");

                    txtIdPelicula.Clear();
                    txtTituloPelicula.Clear();
                    txtGeneroPelicula.Clear();
                    numericDuracionPelicula.Value = 0;
                    cmbxClasificacionPelicula.SelectedIndex = -1;

                    GestiondePeliculas f2 = new GestiondePeliculas();
                    f2.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void btnEliminarPelicula_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    if (listViewPeliculas.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Por favor seleccione una película para eliminar.");
                        return;
                    }

                    string idPelicula = listViewPeliculas.SelectedItems[0].Text; // Se asume que la columna 0 contiene el ID

                    conexion.Open();
                    string consulta = "DELETE FROM peliculas WHERE id_pelicula = @id";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@id", idPelicula);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Película eliminada correctamente.");
                        listViewPeliculas.Items.Remove(listViewPeliculas.SelectedItems[0]);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la película para eliminar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }




        private void btnVerListadoPeliculas_Click(object sender, EventArgs e)
        {
            try
            {
                listViewPeliculas.Items.Clear(); // Limpia la lista antes de cargar datos nuevos

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM peliculas";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        MessageBox.Show("Leyendo: " + reader["titulo"].ToString()); // ✅
                        ListViewItem item = new ListViewItem(reader["id_pelicula"].ToString()); // Columna 0: ID
                        item.SubItems.Add(reader["titulo"].ToString());         // Columna 1: Título
                        item.SubItems.Add(reader["genero"].ToString());         // Columna 2: Género
                        item.SubItems.Add(reader["duracion"].ToString());       // Columna 3: Duración
                        item.SubItems.Add(reader["clasificacion"].ToString());  // Columna 4: Clasificación

                        listViewPeliculas.Items.Add(item);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            GestiondeFunciones f2 = new GestiondeFunciones();
            f2.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}

