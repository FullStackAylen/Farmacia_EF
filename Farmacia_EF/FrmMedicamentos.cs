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
    public partial class FrmMedicamentos : Form
    {
        public FrmMedicamentos()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmCrearMedicamento crear = new FrmCrearMedicamento();
            crear.ShowDialog();
            Recargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.Rows.Count > 0)
            {
                string resp = ControladoraMedicamentos.Instancia.EliminarMedicamento((Medicamento)dgvMedicamentos.CurrentRow.DataBoundItem);
                MessageBox.Show(resp, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Recargar();
            }
        }

        private void FrmMedicamentos_Load(object sender, EventArgs e)
        {
            Recargar();
        }
        private void Recargar()
        {
            dgvMedicamentos.DataSource = null;
            dgvMedicamentos.DataSource = RepositorioMedicamentos.Instancia.Obtener();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.Rows.Count > 0)
            {
                var medicamentoSeleccionado = (MedicamentoDTO)dgvMedicamentos.CurrentRow.DataBoundItem;
                var formMedicamento = new FrmCrearMedicamento(medicamentoSeleccionado);
                formMedicamento.ShowDialog();

            }
            else
            {
                MessageBox.Show("Seleccione una categoria para modificarla");
            }
            Recargar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal principal = new Principal();
            principal.Show();
        }
    }
}
