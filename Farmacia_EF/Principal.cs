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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMedicamentos medicamentos = new FrmMedicamentos();
            medicamentos.Show();
        }

        private void btnMonodroga_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMonodrogas monodrogas = new FrmMonodrogas();
            monodrogas.Show();
        }

        private void btnDrogueria_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDroguerias droguerias = new FrmDroguerias();
            droguerias.Show();
        }
    }
}
