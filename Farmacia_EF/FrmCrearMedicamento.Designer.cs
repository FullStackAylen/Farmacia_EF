namespace Farmacia_EF
{
    partial class FrmCrearMedicamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCrear = new Button();
            btnCancelar = new Button();
            cmbDrogueria = new ComboBox();
            txtStockMinimo = new TextBox();
            txtStock = new TextBox();
            txtPrecioVenta = new TextBox();
            txtNombreComercial = new TextBox();
            cbMonodroga = new ComboBox();
            label1 = new Label();
            btnAgregarDrogueria = new Button();
            btnEliminarDrogueria = new Button();
            dgvDrogueria = new DataGridView();
            cbVentaLibre = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvDrogueria).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(65, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(138, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre Comercial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 146);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Precio de venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 206);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 3;
            label3.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 259);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 4;
            label4.Text = "Stock Minimo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 36);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 5;
            label5.Text = "Drogueria:";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(462, 422);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(176, 29);
            btnCrear.TabIndex = 7;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(280, 422);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(176, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbDrogueria
            // 
            cmbDrogueria.FormattingEnabled = true;
            cmbDrogueria.Location = new Point(460, 59);
            cmbDrogueria.Name = "cmbDrogueria";
            cmbDrogueria.Size = new Size(469, 28);
            cmbDrogueria.TabIndex = 9;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(44, 282);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(358, 27);
            txtStockMinimo.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(44, 229);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(358, 27);
            txtStock.TabIndex = 11;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(44, 169);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(358, 27);
            txtPrecioVenta.TabIndex = 12;
            // 
            // txtNombreComercial
            // 
            txtNombreComercial.Location = new Point(44, 60);
            txtNombreComercial.Name = "txtNombreComercial";
            txtNombreComercial.Size = new Size(358, 27);
            txtNombreComercial.TabIndex = 14;
            // 
            // cbMonodroga
            // 
            cbMonodroga.FormattingEnabled = true;
            cbMonodroga.Location = new Point(44, 339);
            cbMonodroga.Name = "cbMonodroga";
            cbMonodroga.Size = new Size(358, 28);
            cbMonodroga.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 316);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 15;
            label1.Text = "Monodroga:";
            // 
            // btnAgregarDrogueria
            // 
            btnAgregarDrogueria.Location = new Point(623, 94);
            btnAgregarDrogueria.Margin = new Padding(3, 4, 3, 4);
            btnAgregarDrogueria.Name = "btnAgregarDrogueria";
            btnAgregarDrogueria.Size = new Size(152, 31);
            btnAgregarDrogueria.TabIndex = 17;
            btnAgregarDrogueria.Text = "Agregar drogueria";
            btnAgregarDrogueria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDrogueria
            // 
            btnEliminarDrogueria.Location = new Point(623, 339);
            btnEliminarDrogueria.Margin = new Padding(3, 4, 3, 4);
            btnEliminarDrogueria.Name = "btnEliminarDrogueria";
            btnEliminarDrogueria.Size = new Size(152, 31);
            btnEliminarDrogueria.TabIndex = 19;
            btnEliminarDrogueria.Text = "Eliminar drogueria";
            btnEliminarDrogueria.UseVisualStyleBackColor = true;
            // 
            // dgvDrogueria
            // 
            dgvDrogueria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrogueria.Location = new Point(460, 133);
            dgvDrogueria.Margin = new Padding(3, 4, 3, 4);
            dgvDrogueria.Name = "dgvDrogueria";
            dgvDrogueria.RowHeadersWidth = 51;
            dgvDrogueria.RowTemplate.Height = 25;
            dgvDrogueria.Size = new Size(469, 176);
            dgvDrogueria.TabIndex = 18;
            // 
            // cbVentaLibre
            // 
            cbVentaLibre.AutoSize = true;
            cbVentaLibre.Location = new Point(44, 101);
            cbVentaLibre.Name = "cbVentaLibre";
            cbVentaLibre.Size = new Size(102, 24);
            cbVentaLibre.TabIndex = 20;
            cbVentaLibre.Text = "Venta libre";
            cbVentaLibre.UseVisualStyleBackColor = true;
            // 
            // FrmCrearMedicamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 486);
            Controls.Add(cbVentaLibre);
            Controls.Add(btnEliminarDrogueria);
            Controls.Add(dgvDrogueria);
            Controls.Add(btnAgregarDrogueria);
            Controls.Add(cbMonodroga);
            Controls.Add(label1);
            Controls.Add(txtNombreComercial);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtStock);
            Controls.Add(txtStockMinimo);
            Controls.Add(cmbDrogueria);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Name = "FrmCrearMedicamento";
            Text = "FrmCrearMedicamento";
            Load += FrmCrearMedicamento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrogueria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCrear;
        private Button btnCancelar;
        private ComboBox cmbDrogueria;
        private TextBox txtStockMinimo;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private TextBox txtNombreComercial;
        private ComboBox cbMonodroga;
        private Label label1;
        private Button btnAgregarDrogueria;
        private Button btnEliminarDrogueria;
        private DataGridView dgvDrogueria;
        private CheckBox cbVentaLibre;
    }
}