namespace Farmacia_EF
{
    partial class Principal
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
            btnMedicamento = new Button();
            btnMonodroga = new Button();
            btnDrogueria = new Button();
            SuspendLayout();
            // 
            // btnMedicamento
            // 
            btnMedicamento.BackColor = SystemColors.Info;
            btnMedicamento.Location = new Point(120, 90);
            btnMedicamento.Name = "btnMedicamento";
            btnMedicamento.Size = new Size(397, 51);
            btnMedicamento.TabIndex = 0;
            btnMedicamento.Text = "Medicamento";
            btnMedicamento.UseVisualStyleBackColor = false;
            btnMedicamento.Click += btnMedicamento_Click;
            // 
            // btnMonodroga
            // 
            btnMonodroga.BackColor = SystemColors.Info;
            btnMonodroga.Location = new Point(120, 162);
            btnMonodroga.Name = "btnMonodroga";
            btnMonodroga.Size = new Size(397, 51);
            btnMonodroga.TabIndex = 1;
            btnMonodroga.Text = "Monodroga";
            btnMonodroga.UseVisualStyleBackColor = false;
            btnMonodroga.Click += btnMonodroga_Click;
            // 
            // btnDrogueria
            // 
            btnDrogueria.BackColor = SystemColors.Info;
            btnDrogueria.Location = new Point(120, 237);
            btnDrogueria.Name = "btnDrogueria";
            btnDrogueria.Size = new Size(397, 51);
            btnDrogueria.TabIndex = 2;
            btnDrogueria.Text = "Drogueria";
            btnDrogueria.UseVisualStyleBackColor = false;
            btnDrogueria.Click += btnDrogueria_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(638, 377);
            Controls.Add(btnDrogueria);
            Controls.Add(btnMonodroga);
            Controls.Add(btnMedicamento);
            Name = "Principal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMedicamento;
        private Button btnMonodroga;
        private Button btnDrogueria;
    }
}