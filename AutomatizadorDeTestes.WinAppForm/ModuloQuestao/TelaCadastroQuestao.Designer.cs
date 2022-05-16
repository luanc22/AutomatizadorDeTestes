namespace AutomatizadorDeTestes.WinAppForm
{
    partial class TelaCadastroQuestao
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.txtNumQuest = new System.Windows.Forms.TextBox();
            this.cbBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.cbBoxMateria = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblAlternativa = new System.Windows.Forms.Label();
            this.txtAlternativa = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.chkCorreta = new System.Windows.Forms.CheckBox();
            this.lstBoxAlternativasAdicionadas = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(27, 19);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(54, 15);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(20, 47);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(61, 15);
            this.lblDisciplina.TabIndex = 1;
            this.lblDisciplina.Text = "Disciplina:";
            // 
            // txtNumQuest
            // 
            this.txtNumQuest.Enabled = false;
            this.txtNumQuest.HideSelection = false;
            this.txtNumQuest.Location = new System.Drawing.Point(84, 16);
            this.txtNumQuest.Name = "txtNumQuest";
            this.txtNumQuest.ReadOnly = true;
            this.txtNumQuest.Size = new System.Drawing.Size(100, 23);
            this.txtNumQuest.TabIndex = 2;
            // 
            // cbBoxDisciplina
            // 
            this.cbBoxDisciplina.FormattingEnabled = true;
            this.cbBoxDisciplina.Location = new System.Drawing.Point(84, 44);
            this.cbBoxDisciplina.Name = "cbBoxDisciplina";
            this.cbBoxDisciplina.Size = new System.Drawing.Size(226, 23);
            this.cbBoxDisciplina.TabIndex = 3;
            // 
            // cbBoxMateria
            // 
            this.cbBoxMateria.FormattingEnabled = true;
            this.cbBoxMateria.Location = new System.Drawing.Point(84, 73);
            this.cbBoxMateria.Name = "cbBoxMateria";
            this.cbBoxMateria.Size = new System.Drawing.Size(226, 23);
            this.cbBoxMateria.TabIndex = 4;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(27, 76);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(50, 15);
            this.lblMateria.TabIndex = 5;
            this.lblMateria.Text = "Matéria:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(16, 102);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(61, 15);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(84, 102);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(456, 52);
            this.txtDescricao.TabIndex = 7;
            // 
            // lblAlternativa
            // 
            this.lblAlternativa.AutoSize = true;
            this.lblAlternativa.Location = new System.Drawing.Point(5, 164);
            this.lblAlternativa.Name = "lblAlternativa";
            this.lblAlternativa.Size = new System.Drawing.Size(67, 15);
            this.lblAlternativa.TabIndex = 8;
            this.lblAlternativa.Text = "Alternativa:";
            // 
            // txtAlternativa
            // 
            this.txtAlternativa.Location = new System.Drawing.Point(84, 164);
            this.txtAlternativa.Multiline = true;
            this.txtAlternativa.Name = "txtAlternativa";
            this.txtAlternativa.Size = new System.Drawing.Size(456, 52);
            this.txtAlternativa.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(440, 222);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // chkCorreta
            // 
            this.chkCorreta.AutoSize = true;
            this.chkCorreta.Location = new System.Drawing.Point(369, 226);
            this.chkCorreta.Name = "chkCorreta";
            this.chkCorreta.Size = new System.Drawing.Size(65, 19);
            this.chkCorreta.TabIndex = 11;
            this.chkCorreta.Text = "Correta";
            this.chkCorreta.UseVisualStyleBackColor = true;
            // 
            // lstBoxAlternativasAdicionadas
            // 
            this.lstBoxAlternativasAdicionadas.FormattingEnabled = true;
            this.lstBoxAlternativasAdicionadas.ItemHeight = 15;
            this.lstBoxAlternativasAdicionadas.Location = new System.Drawing.Point(5, 256);
            this.lstBoxAlternativasAdicionadas.Name = "lstBoxAlternativasAdicionadas";
            this.lstBoxAlternativasAdicionadas.Size = new System.Drawing.Size(535, 124);
            this.lstBoxAlternativasAdicionadas.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(440, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(334, 393);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 23);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // TelaCadastroQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 428);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lstBoxAlternativasAdicionadas);
            this.Controls.Add(this.chkCorreta);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtAlternativa);
            this.Controls.Add(this.lblAlternativa);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cbBoxMateria);
            this.Controls.Add(this.cbBoxDisciplina);
            this.Controls.Add(this.txtNumQuest);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.lblNumero);
            this.Name = "TelaCadastroQuestao";
            this.Text = "Cadastro de Questões";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaCadastroQuestao_FormClosing);
            this.Load += new System.EventHandler(this.TelaCadastroQuestao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.TextBox txtNumQuest;
        private System.Windows.Forms.ComboBox cbBoxDisciplina;
        private System.Windows.Forms.ComboBox cbBoxMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblAlternativa;
        private System.Windows.Forms.TextBox txtAlternativa;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.CheckBox chkCorreta;
        private System.Windows.Forms.ListBox lstBoxAlternativasAdicionadas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}