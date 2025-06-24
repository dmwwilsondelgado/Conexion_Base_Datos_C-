using MySql.Data.MySqlClient; //agregamos estos dos
using System.Data;//agregamos
namespace solution_002
{
    public partial class Form1 : Form
    {
        string cadenaConexion = "Server=localhost;Database=base_datos_solution002;Uid=wilsondelgado;Pwd=1102717619;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open(); // abrimos la conexion
                    string consulta = "INSERT INTO clientes (nombre,correo) values (@nombre,@correo)";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@nombre", txtName.Text); // los campos se agregan alas consultas en el insert 
                    comando.Parameters.AddWithValue("@correo", txtCorreo.Text); // los campos se agregan alas consultas en el insert 

                    comando.ExecuteNonQuery(); // metodo que crea modifica y elemina tablas 

                    MessageBox.Show("Contacto Guardado"); // mostramos un mensaje que nos muestra si este se envio ala base de datos 

                    txtName.Clear();
                    txtCorreo.Clear();
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
