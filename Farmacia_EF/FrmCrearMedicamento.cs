using Controller;
using Model;
using Model.DTO;
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
    public partial class FrmCrearMedicamento : Form
    {
        private MedicamentoDTO medicamento;
        private bool modifica = false;
        public FrmCrearMedicamento()
        {
            InitializeComponent();
            var droguerias = ControladoraDroguerias.Instancia.RecuperarDroguerias();

            foreach (var drogueria in droguerias)
            {
                cmbDrogueria.Items.Add(drogueria.RazonSocial);
            }

            medicamento = new MedicamentoDTO();
        }
        public FrmCrearMedicamento(MedicamentoDTO medicamento)
        {
            InitializeComponent();
            this.medicamento = medicamento;
            modifica = true;
        }
        private void ActualizarDrogueria()
        {
            dgvDrogueria.DataSource = null;
            dgvDrogueria.DataSource = medicamento.NombreMonodroga;
        }
        private void ActualizarCMB()
        {
            cmbDrogueria.Items.Clear();
            var droguerias = ControladoraDroguerias.Instancia.RecuperarDroguerias();
            foreach (DrogueriaDTO drogueria in droguerias)
            {
                var findDrog = medicamento.Droguerias.FirstOrDefault(x => x.RazonSocial.ToLower() == drogueria.RazonSocial.ToLower());
                if (findDrog == null)
                {
                    cmbDrogueria.Items.Add(drogueria.RazonSocial);
                }
            }
            cmbDrogueria.Text = "";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (modifica)
                {
                    medicamento.NombreComercial = txtNombreComercial.Text;
                    medicamento.EsVentaLibre = cbVentaLibre.Checked;
                    medicamento.Stock = Convert.ToInt32(txtStock.Text);
                    medicamento.StockMinimo = Convert.ToInt32(txtStockMinimo.Text);
                    medicamento.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                    medicamento.NombreMonodroga = cbMonodroga.SelectedItem.ToString();
                    var mensaje = ControladoraMedicamentos.Instancia.ModificarMedicamento(medicamento);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var monodroga = ControladoraMonodrogas.Instancia.RecuperarMonodrogas().FirstOrDefault(x => x.Nombre.ToLower() == medicamento.NombreMonodroga.ToLower());
                    medicamento.NombreMonodroga = monodroga.Nombre;
                    medicamento.NombreComercial = txtNombreComercial.Text;
                    medicamento.EsVentaLibre = cbVentaLibre.Checked;
                    medicamento.Stock = Convert.ToInt32(txtStock.Text);
                    medicamento.StockMinimo = Convert.ToInt32(txtStockMinimo.Text);
                    medicamento.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);

                    var mensaje = ControladoraMedicamentos.Instancia.AgregarMedicamento(medicamento);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(this.txtNombreComercial.Text))
            {
                MessageBox.Show("Debe ingresar el nombre comercial", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtPrecioVenta.Text))
            {
                MessageBox.Show("Debe ingresar el precio de venta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtStock.Text))
            {
                MessageBox.Show("Debe ingresar el stock", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtStockMinimo.Text))
            {
                MessageBox.Show("Debe ingresar el stock minimo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Debe ingresar el stock en formato correcto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!int.TryParse(txtStockMinimo.Text, out int stockMinimo))
            {
                MessageBox.Show("Debe ingresar el stock minimo en formato correcto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void FrmCrearMedicamento_Load(object sender, EventArgs e)
        {
            if (modifica)
            {
                this.Text = "Modificar Medicamento";
                txtNombreComercial.Text = medicamento.NombreComercial;
                txtPrecioVenta.Text = medicamento.PrecioVenta.ToString();
                txtStock.Text = medicamento.Stock.ToString();
                txtStockMinimo.Text = medicamento.StockMinimo.ToString();
                cbVentaLibre.Checked = medicamento.EsVentaLibre;
                cbMonodroga.Text = medicamento.NombreMonodroga;
                ActualizarDrogueria();
                ActualizarCMB();
            }
            else
            {
                this.Text = "Agregar Producto";

            }
            var monodrogas = ControladoraMonodrogas.Instancia.RecuperarMonodrogas();
            foreach (MonodrogaDTO monodrorga in monodrogas)
            {
                cbMonodroga.Items.Add(monodrorga.Nombre);
            }
        }
    }
}
