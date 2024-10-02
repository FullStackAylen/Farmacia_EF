namespace Farmacia_EF
{
    partial class FrmMedicamentos
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
            btnCrear = new Button();
            btnEliminar = new Button();
            dgvMedicamentos = new DataGridView();
            btnEditar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.Info;
            btnCrear.Location = new Point(12, 11);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(197, 40);
            btnCrear.TabIndex = 7;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Info;
            btnEliminar.Location = new Point(887, 510);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(197, 40);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Location = new Point(12, 57);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.RowHeadersWidth = 51;
            dgvMedicamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicamentos.Size = new Size(1072, 447);
            dgvMedicamentos.TabIndex = 5;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.Info;
            btnEditar.Location = new Point(684, 510);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(197, 40);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.Info;
            btnCerrar.Location = new Point(12, 512);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(197, 40);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmMedicamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 564);
            Controls.Add(btnCerrar);
            Controls.Add(btnEditar);
            Controls.Add(btnCrear);
            Controls.Add(btnEliminar);
            Controls.Add(dgvMedicamentos);
            Name = "FrmMedicamentos";
            Text = "Medicamentos";
            Load += FrmMedicamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrear;
        private Button btnEliminar;
        private DataGridView dgvMedicamentos;
        private Button btnEditar;
        private Button btnCerrar;
    }
}