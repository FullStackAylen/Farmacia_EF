using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_EF
{
    public partial class FrmDroguerias : Form
    {
        public FrmDroguerias()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDroguerias.Rows.Count > 0)
            {
                string resp = ControladoraDroguerias.Instancia.EliminarDrogueria((Drogueria)dgvDroguerias.CurrentRow.DataBoundItem);
                MessageBox.Show(resp, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Recargar();
            }
        }

        private void FrmDroguerias_Load(object sender, EventArgs e)
        {
            Recargar();
        }
        private void Recargar()
        {
            dgvDroguerias.DataSource = null;
            dgvDroguerias.DataSource = ControladoraDroguerias.Instancia.RecuperarDroguerias();
        }

        private void btnEditar_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal principal = new Principal();
            principal.Show();
        }
    }
}
