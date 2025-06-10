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

                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text); // los campos se agregan alas consultas en el insert 
                    comando.Parameters.AddWithValue("@telefono", txtTelefono.Text); // los campos se agregan alas consultas en el insert 

                    comando.ExecuteNonQuery(); // metodo que crea modifica y elemina tablas 

                    MessageBox.Show("Contacto Guardado"); // mostramos un mensaje que nos muestra si este se envio ala base de datos 

                    txtNombre.Clear();
                    txtTelefono.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errro" + ex.Message);
                }
            }
            using (MySqlConnection conexion = new MySqlConnection())
            {
                listView1.Items.Clear();
                try
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM Contactos";
                    MySqlCommand cmd = new MySqlCommand(consulta,conexion); // creamos un obejto para hacer las consultas 
                    MySqlDataReader raeeder = cmd.ExecuteReader(); // crea la conexion y manda este objeto ala base de datos  ara este crear la consulta
                    // selecionar los datos y pasarlo por el el Metodo ExecuteReader();

                    // usamos un while
                    while (raeeder.Read()) // Read es Leer reader lo que capturamos del metodo los datos y mandarlos a esta lista si se cumple 
                    {

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
