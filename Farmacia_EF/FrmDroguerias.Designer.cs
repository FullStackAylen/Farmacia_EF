namespace Farmacia_EF
{
    partial class FrmDroguerias
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
            dgvDroguerias = new DataGridView();
            btnEliminar = new Button();
            btnCrear = new Button();
            btnEditar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDroguerias).BeginInit();
            SuspendLayout();
            // 
            // dgvDroguerias
            // 
            dgvDroguerias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDroguerias.Location = new Point(12, 58);
            dgvDroguerias.Name = "dgvDroguerias";
            dgvDroguerias.RowHeadersWidth = 51;
            dgvDroguerias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDroguerias.Size = new Size(1072, 447);
            dgvDroguerias.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Info;
            btnEliminar.Location = new Point(887, 511);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(197, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.Info;
            btnCrear.Location = new Point(12, 12);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(197, 40);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.Info;
            btnEditar.Location = new Point(684, 511);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(197, 40);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.ClientSizeChanged += btnEditar_ClientSizeChanged;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.Info;
            btnCerrar.Location = new Point(12, 511);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(197, 40);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmDroguerias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 563);
            Controls.Add(btnCerrar);
            Controls.Add(btnEditar);
            Controls.Add(btnCrear);
            Controls.Add(btnEliminar);
            Controls.Add(dgvDroguerias);
            Name = "FrmDroguerias";
            Text = "FrmDroguerias";
            Load += FrmDroguerias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDroguerias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDroguerias;
        private Button btnEliminar;
        private Button btnCrear;
        private Button btnEditar;
        private Button btnCerrar;
    }
}