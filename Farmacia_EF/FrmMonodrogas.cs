using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_EF
{
    public partial class FrmMonodrogas : Form
    {
        public FrmMonodrogas()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMonodrogas.Rows.Count > 0)
            {
                string resp = ControladoraMonodrogas.Instancia.EliminarMonodroga((Monodroga)dgvMonodrogas.CurrentRow.DataBoundItem);
                MessageBox.Show(resp, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Recargar();
            }
        }

        private void FrmMonodrogas_Load(object sender, EventArgs e)
        {
            Recargar();
        }
        private void Recargar()
        {
            dgvMonodrogas.DataSource = null;
            dgvMonodrogas.DataSource = RepositorioMonodrogas.Instancia.Obtener();
        }

        private void btnEditar_Click(object sender, EventArgs e)
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
