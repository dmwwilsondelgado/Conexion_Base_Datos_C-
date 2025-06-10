using MySql.Data.MySqlClient; //agregamos estos dos
using System.Data;//agregamos
namespace Solution_000
{
    public partial class Form1 : Form
    {
        //creamos la conexion 
        string cadenaConexion = "Server=localhost;Database=base_datos_solution000;Uid=wilsondelgado;Pwd=1102717619";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open(); // abrimos la conexion
                    string consulta = "INSERT INTO Contactos (Nombre,Telefono) values (@nombre,@telefono)";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    
                    comando.Parameters.AddWithValue("@nombre",txtNombre.Text); // los campos se agregan alas consultas en el insert 
                    comando.Parameters.AddWithValue("@telefono", txtTelefono.Text); // los campos se agregan alas consultas en el insert 

                    comando.ExecuteNonQuery(); // metodo que crea modifica y elemina tablas 

                    MessageBox.Show("Contacto Guardado"); // mostramos un mensaje que nos muestra si este se envio ala base de datos 

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
