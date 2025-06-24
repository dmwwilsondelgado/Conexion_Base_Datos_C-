using MySql.Data.MySqlClient;
namespace Solution_001
{
    public partial class Form1 : Form
    {
        string cadenaConexion = "Server=localhost;Database=base_datos_solution001;Uid=wilsondelgado;Pwd=1102717619;";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDescripcionAuditoria.Clear();
            txtOperacionDirigidaAuditoria.Clear();
            txtAfectarAuditoria.Clear();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "" || txtDescripcion.Text == "" || txtNombreProducto.Text == "")
            {
                MessageBox.Show("campos invalidaos falta rellenar");
            }
            else
            {
                MessageBox.Show("Todo Corretamente para Guardar");
            }
        }

        private void btnValidarAuditoria_Click(object sender, EventArgs e)
        {
            if (txtAfectarAuditoria.Text == "" || txtOperacionDirigidaAuditoria.Text == "" || txtDescripcionAuditoria.Text == "")
            {
                MessageBox.Show("Campos Invalidos Falta Rellenar");
            }
            else
            {
                MessageBox.Show("Todo Corecto para Guardar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open(); // abrimos la conexion
                    string consulta = "INSERT INTO productos (nombre,descripcion,precio,stock_actual) values (@nombre,@descripcion,@precio,@stock_actual)";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@nombre", txtNombreProducto.Text); // los campos se agregan alas consultas en el insert 
                    comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text); // los campos se agregan alas consultas en el insert 
                    comando.Parameters.AddWithValue("@precio", txtPrecio.Text);
                    comando.Parameters.AddWithValue("@stock_actual", numericStock.Text);

                    comando.ExecuteNonQuery(); // metodo que crea modifica y elemina tablas 

                    MessageBox.Show("Electrodomestico Guardado"); // mostramos un mensaje que nos muestra si este se envio ala base de datos 

                    txtNombreProducto.Clear();
                    txtDescripcion.Clear();
                    txtPrecio.Clear();




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errro" + ex.Message);
                }
            }
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open(); // abrimos la conexion
                    string consulta = "INSERT INTO auditoria (operacion,tabla_afectada,descripcion,fecha) values (@operacion,@tabla_afectada,@descripcion,@fecha)";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@operacion", txtOperacionDirigidaAuditoria.Text); // los campos se agregan alas consultas en el insert 
                    comando.Parameters.AddWithValue("@tabla_afectada", txtDescripcionAuditoria.Text); // los campos se agregan alas consultas en el insert 
                    comando.Parameters.AddWithValue("@descripcion", txtAfectarAuditoria.Text);
                    comando.Parameters.AddWithValue("@fecha", dateTimePicker1.Text);

                    comando.ExecuteNonQuery(); // metodo que crea modifica y elemina tablas 

                    MessageBox.Show("Electrodomestico Guardado"); // mostramos un mensaje que nos muestra si este se envio ala base de datos 

                    txtOperacionDirigidaAuditoria.Clear();
                    txtDescripcionAuditoria.Clear();
                    txtAfectarAuditoria.Clear();



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errro" + ex.Message);
                }
            }
        }
    }
}
