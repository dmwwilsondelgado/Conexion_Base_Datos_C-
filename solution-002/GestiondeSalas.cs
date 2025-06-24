using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solution_002
{
    public partial class GestiondeSalas : Form
    {
        public GestiondeSalas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            GestiondePeliculas f1 = new GestiondePeliculas();
            f1.Show();
            this.Close();
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            GestionVentasEntrada f2 = new GestionVentasEntrada();
            f2.Show();
            this.Hide();
        }
    }
}
