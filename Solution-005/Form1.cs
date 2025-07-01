using MySql.Data.MySqlClient; //agregamos estos dos
using System.Data;//agregamos
namespace Solution_005
{
    public partial class Form1 : Form
    {
        string cadenaConexion = "Server=localhost;Database=base_datos_solution005;Uid=wilsondelgado;Pwd=1102717619";
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClientesFrecuentes f2 = new ClientesFrecuentes();
            f2.Show();
            //this.Hide();
        }

        private void btnRegistarVehiculo_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO vehiculos (placa, tipo, color, id_cliente) VALUES (@placa, @tipo, @color, @id_cliente)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@placa", txtPlaca.Text);
                    cmd.Parameters.AddWithValue("@tipo", txtVehiculo.Text);
                    cmd.Parameters.AddWithValue("@color", txtColor.Text);
                    cmd.Parameters.AddWithValue("@id_cliente", cmbxCliente.SelectedValue);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Vehiculo agregado exitosamente.");
                    txtPlaca.Clear();
                    txtVehiculo.Clear();
                    txtColor.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar Cliente " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT id_cliente, nombre FROM clientes";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<int, string> clientes = new Dictionary<int, string>();
                    while (reader.Read())
                    {
                        clientes.Add(reader.GetInt32("id_cliente"), reader.GetString("nombre"));
                    }

                    cmbxCliente.DataSource = new BindingSource(clientes, null);
                    cmbxCliente.DisplayMember = "Value"; // Nombre visible
                    cmbxCliente.ValueMember = "Key";     // id_cliente oculto
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                listViewVehiculos.Items.Clear(); // Limpia la lista antes de cargar datos nuevos

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = @"SELECT v.placa, v.tipo, v.color, c.nombre 
                    FROM vehiculos v 
                    INNER JOIN clientes c ON v.id_cliente = c.id_cliente";

                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        MessageBox.Show("Leyendo: " + reader["placa"].ToString()); // ✅
                        ListViewItem item = new ListViewItem(reader["placa"].ToString()); // Columna 0: ID
                        item.SubItems.Add(reader["tipo"].ToString());
                        item.SubItems.Add(reader["color"].ToString());
                        item.SubItems.Add(reader["id_cliente"].ToString());
                        listViewVehiculos.Items.Add(item);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVerEmpleados_Click(object sender, EventArgs e)
        {
            Empleados f2 = new Empleados();
            f2.Show();
       
        }
    }
}
