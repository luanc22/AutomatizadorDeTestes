namespace AutomatizadorDeTestes.WinAppForm.ModuloDisciplina
{
    partial class TelaCadastroDisciplina
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
            this.lblNumDisci = new System.Windows.Forms.Label();
            this.lblNomeDisci = new System.Windows.Forms.Label();
            this.txtNumDisci = new System.Windows.Forms.TextBox();
            this.txtNomeDisci = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumDisci
            // 
            this.lblNumDisci.AutoSize = true;
            this.lblNumDisci.Location = new System.Drawing.Point(12, 9);
            this.lblNumDisci.Name = "lblNumDisci";
            this.lblNumDisci.Size = new System.Drawing.Size(54, 15);
            this.lblNumDisci.TabIndex = 0;
            this.lblNumDisci.Text = "Número:";
            // 
            // lblNomeDisci
            // 
            this.lblNomeDisci.AutoSize = true;
            this.lblNomeDisci.Location = new System.Drawing.Point(23, 38);
            this.lblNomeDisci.Name = "lblNomeDisci";
            this.lblNomeDisci.Size = new System.Drawing.Size(43, 15);
            this.lblNomeDisci.TabIndex = 1;
            this.lblNomeDisci.Text = "Nome:";
            // 
            // txtNumDisci
            // 
            this.txtNumDisci.Enabled = false;
            this.txtNumDisci.Location = new System.Drawing.Point(72, 6);
            this.txtNumDisci.Name = "txtNumDisci";
            this.txtNumDisci.ReadOnly = true;
            this.txtNumDisci.Size = new System.Drawing.Size(100, 23);
            this.txtNumDisci.TabIndex = 2;
            // 
            // txtNomeDisci
            // 
            this.txtNomeDisci.Location = new System.Drawing.Point(72, 35);
            this.txtNomeDisci.Name = "txtNomeDisci";
            this.txtNomeDisci.Size = new System.Drawing.Size(233, 23);
            this.txtNomeDisci.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(149, 106);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(230, 106);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // TelaCadastroDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 135);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtNomeDisci);
            this.Controls.Add(this.txtNumDisci);
            this.Controls.Add(this.lblNomeDisci);
            this.Controls.Add(this.lblNumDisci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TelaCadastroDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Disciplina";
            this.Load += new System.EventHandler(this.TelaCadastroDisciplina_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaCadastroDisciplina_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumDisci;
        private System.Windows.Forms.Label lblNomeDisci;
        private System.Windows.Forms.TextBox txtNumDisci;
        private System.Windows.Forms.TextBox txtNomeDisci;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}