using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace Solution_003
{
    public partial class Gestion : Form
    {
        string cadenaConexion = "Server=localhost;Database=base_datos_solution003;Uid=wilsondelgado;Pwd=1102717619;";
        public Gestion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
 
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    string consulta = "SELECT * FROM administradores WHERE usuario = @usuario AND pasword = @pasword";
                    conexion.Open();

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    comando.Parameters.AddWithValue("@pasword", txtPassword.Text); // corregido: era @pasword mal escrito

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read()) // Si encontró coincidencia
                        {
                            MessageBox.Show("Admin ingresó correctamente");

                            // Limpiar campos
                            txtUsuario.Clear();
                            txtPassword.Clear();

                            // Abrir otro formulario
                            GestionClientes f2 = new GestionClientes();
                            f2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
    
}
