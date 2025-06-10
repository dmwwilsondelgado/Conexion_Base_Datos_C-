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
                        ListViewItem item = new ListViewItem(raeeder["ID"].ToString()); // treamos el metodo y parseamos el ID 
                        item.SubItems.Add(raeeder["Nombre"].ToString()); // agregamos  los datos reader que traemos de la consulta y lo mandamos al elemenot item mediante objeto hacia las listview
                        item.SubItems.Add(raeeder["Telefono"].ToString()); // agregamos  los datos reader que traemos de la consulta y lo mandamos al elemenot item mediante objeto hacia las listview
                        listView1.Items.Add(item); // agregamos los items   a a list view que por deafault la madamso asi                    
                    }
                    raeeder.Close(); // cerramos la consulta 
                }
                catch (Exception ex)
                {
                    MessageBox.Show ("Error" + ex.Message);
                }
            }
            using (MySqlConnection conexion = new MySqlConnection())
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Por favor selecione un producto para eliminar ");
                    return;
                }
                string id = listView1.SelectedItems[0].Text;
                try
                {
                    conexion.Open(); // abrimos la conexion 
                    string consulta = "DELETE FROM  Contactos WHERE ID = @ID "; // creamos la consulta 
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@ID", id);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas <0)
                    {
                        MessageBox.Show(" Contacto selecionado y eliminado perfectamente ");
                        listView1.Items.Remove(listView1.SelectedItems[0]);
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el contatco para eliminar ");
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("error " + ex);
                }
               
            }
        }
    }
}
