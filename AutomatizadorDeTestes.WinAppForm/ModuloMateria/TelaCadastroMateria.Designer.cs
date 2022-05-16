namespace AutomatizadorDeTestes.WinAppForm.ModuloMateria
{
    partial class TelaCadastroMateria
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
            this.lblNumMat = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDisci = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumMat = new System.Windows.Forms.TextBox();
            this.txtNomeMat = new System.Windows.Forms.TextBox();
            this.cbBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.cbBoxSerie = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumMat
            // 
            this.lblNumMat.AutoSize = true;
            this.lblNumMat.Location = new System.Drawing.Point(36, 30);
            this.lblNumMat.Name = "lblNumMat";
            this.lblNumMat.Size = new System.Drawing.Size(54, 15);
            this.lblNumMat.TabIndex = 0;
            this.lblNumMat.Text = "Número:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(47, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblDisci
            // 
            this.lblDisci.AutoSize = true;
            this.lblDisci.Location = new System.Drawing.Point(29, 88);
            this.lblDisci.Name = "lblDisci";
            this.lblDisci.Size = new System.Drawing.Size(61, 15);
            this.lblDisci.TabIndex = 2;
            this.lblDisci.Text = "Disciplina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Série:";
            // 
            // txtNumMat
            // 
            this.txtNumMat.Enabled = false;
            this.txtNumMat.Location = new System.Drawing.Point(93, 27);
            this.txtNumMat.Name = "txtNumMat";
            this.txtNumMat.ReadOnly = true;
            this.txtNumMat.ShortcutsEnabled = false;
            this.txtNumMat.Size = new System.Drawing.Size(100, 23);
            this.txtNumMat.TabIndex = 4;
            // 
            // txtNomeMat
            // 
            this.txtNomeMat.Location = new System.Drawing.Point(93, 56);
            this.txtNomeMat.Name = "txtNomeMat";
            this.txtNomeMat.Size = new System.Drawing.Size(231, 23);
            this.txtNomeMat.TabIndex = 5;
            // 
            // cbBoxDisciplina
            // 
            this.cbBoxDisciplina.FormattingEnabled = true;
            this.cbBoxDisciplina.Location = new System.Drawing.Point(93, 85);
            this.cbBoxDisciplina.Name = "cbBoxDisciplina";
            this.cbBoxDisciplina.Size = new System.Drawing.Size(231, 23);
            this.cbBoxDisciplina.TabIndex = 6;
            // 
            // cbBoxSerie
            // 
            this.cbBoxSerie.FormattingEnabled = true;
            this.cbBoxSerie.Location = new System.Drawing.Point(93, 114);
            this.cbBoxSerie.Name = "cbBoxSerie";
            this.cbBoxSerie.Size = new System.Drawing.Size(231, 23);
            this.cbBoxSerie.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(249, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(168, 166);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // TelaCadastroMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 201);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbBoxSerie);
            this.Controls.Add(this.cbBoxDisciplina);
            this.Controls.Add(this.txtNomeMat);
            this.Controls.Add(this.txtNumMat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDisci);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNumMat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TelaCadastroMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Matéria";
            this.Load += new System.EventHandler(this.TelaCadastroMateria_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaCadastroMateria_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumMat;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDisci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumMat;
        private System.Windows.Forms.TextBox txtNomeMat;
        private System.Windows.Forms.ComboBox cbBoxDisciplina;
        private System.Windows.Forms.ComboBox cbBoxSerie;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}