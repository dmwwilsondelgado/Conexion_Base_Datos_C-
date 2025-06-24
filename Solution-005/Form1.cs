using MySql.Data.MySqlClient; //agregamos estos dos
using System.Data;//agregamos
namespace Solution_005
{
    public partial class Form1 : Form
    {
        string cadenaConexion ="Server=localhost;Database=base_datos_solution005;Uid=wilsondelgado;Pwd=1102717619";
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
            this.Hide();
        }

        private void btnRegistarVehiculo_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection())
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO "

                }
                catch (Exception ex) 
                {

                }
                
            }
        }
    }
}
