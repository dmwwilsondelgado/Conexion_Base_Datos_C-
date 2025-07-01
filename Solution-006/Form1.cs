using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace Solution_006
{
    public partial class Form1 : Form
    {
        string cadenaConexion = "Server=localhost;Database=base_datos_solution006;Uid=wilsondelgado;Pwd=1102717619";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = "INSERT INTO asistencia (id_empleado, fecha, hora_entrada, hora_salida, tipo_registro, justificado) " +
                                   "VALUES (@id_empleado, @fecha, @hora_entrada, @hora_salida, @tipo_registro, false)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id_empleado", txtIdEmpleado.Text);
                        cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                        cmd.Parameters.AddWithValue("@hora_entrada", dtpHoraEntrada.Value.TimeOfDay);
                        cmd.Parameters.AddWithValue("@hora_salida", dtpHoraSalida.Value.TimeOfDay);
                        cmd.Parameters.AddWithValue("@tipo_registro", cmbTipoRegistro.SelectedItem?.ToString() ?? "");

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Asistencia registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAsistencias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void btnJustificantes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí podrías abrir un nuevo formulario para visualizar o registrar justificantes.", "Info");
        }

        private void btnCalcularDescuentos_Click(object sender, EventArgs e)
        {
            try
            {
                // Simulación: descuento si entrada después de 8:10 AM
                TimeSpan horaLimite = new TimeSpan(8, 10, 0);
                if (dtpHoraEntrada.Value.TimeOfDay > horaLimite)
                {
                    decimal descuento = 20000; // Valor fijo solo para probar

                    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                    {
                        conexion.Open();
                        string insert = "INSERT INTO descuentos (id_empleado, fecha, monto, motivo) VALUES (@id, @fecha, @monto, @motivo)";

                        using (MySqlCommand cmd = new MySqlCommand(insert, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", txtIdEmpleado.Text);
                            cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                            cmd.Parameters.AddWithValue("@monto", descuento);
                            cmd.Parameters.AddWithValue("@motivo", "Retardo");
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Descuento registrado por retardo.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay descuento, llegó a tiempo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular descuento: " + ex.Message);
            }
        }
        private void CargarAsistencias()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT a.id_asistencia, a.id_empleado, e.nombre, a.fecha, a.hora_entrada, a.hora_salida, a.tipo_registro, a.justificado " +
                                   "FROM asistencia a INNER JOIN empleados e ON a.id_empleado = e.id_empleado";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAsistencias.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asistencias: " + ex.Message);
            }
        }
    }
}
