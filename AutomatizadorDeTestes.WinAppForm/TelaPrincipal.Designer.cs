namespace AutomatizadorDeTestes.WinAppForm
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlSpBotoes = new System.Windows.Forms.ToolStrip();
            this.tlspBtnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.tlspBtnEditar = new System.Windows.Forms.ToolStripButton();
            this.tlspBtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDuplicar = new System.Windows.Forms.ToolStripButton();
            this.tlspBtnPDF = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlSpLblCadastro = new System.Windows.Forms.ToolStripLabel();
            this.plRegistros = new System.Windows.Forms.Panel();
            this.ssSpStatus = new System.Windows.Forms.StatusStrip();
            this.tlStsLblMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.muSpCadastros = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matériasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlSpBotoes.SuspendLayout();
            this.ssSpStatus.SuspendLayout();
            this.muSpCadastros.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlSpBotoes
            // 
            this.tlSpBotoes.AutoSize = false;
            this.tlSpBotoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlSpBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlspBtnAdicionar,
            this.tlspBtnEditar,
            this.tlspBtnExcluir,
            this.toolStripSeparator2,
            this.btnDuplicar,
            this.tlspBtnPDF,
            this.toolStripSeparator1,
            this.tlSpLblCadastro});
            this.tlSpBotoes.Location = new System.Drawing.Point(0, 24);
            this.tlSpBotoes.Name = "tlSpBotoes";
            this.tlSpBotoes.Size = new System.Drawing.Size(800, 50);
            this.tlSpBotoes.TabIndex = 2;
            this.tlSpBotoes.Text = "toolStrip2";
            // 
            // tlspBtnAdicionar
            // 
            this.tlspBtnAdicionar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlspBtnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlspBtnAdicionar.Image = global::AutomatizadorDeTestes.WinAppForm.Properties.Resources.add_FILL0_wght400_GRAD0_opsz48;
            this.tlspBtnAdicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlspBtnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlspBtnAdicionar.Name = "tlspBtnAdicionar";
            this.tlspBtnAdicionar.Size = new System.Drawing.Size(52, 47);
            this.tlspBtnAdicionar.Text = "tlspBtnAdicionar";
            this.tlspBtnAdicionar.Click += new System.EventHandler(this.tlspBtnAdicionar_Click);
            // 
            // tlspBtnEditar
            // 
            this.tlspBtnEditar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlspBtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlspBtnEditar.Image = global::AutomatizadorDeTestes.WinAppForm.Properties.Resources.edit_FILL0_wght400_GRAD0_opsz48;
            this.tlspBtnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlspBtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlspBtnEditar.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.tlspBtnEditar.Name = "tlspBtnEditar";
            this.tlspBtnEditar.Size = new System.Drawing.Size(52, 47);
            this.tlspBtnEditar.Text = "toolStripButton2";
            this.tlspBtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlspBtnEditar.ToolTipText = "tlspBtnEditar";
            this.tlspBtnEditar.Click += new System.EventHandler(this.tlspBtnEditar_Click);
            // 
            // tlspBtnExcluir
            // 
            this.tlspBtnExcluir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlspBtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlspBtnExcluir.Image = global::AutomatizadorDeTestes.WinAppForm.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz48;
            this.tlspBtnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlspBtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlspBtnExcluir.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.tlspBtnExcluir.Name = "tlspBtnExcluir";
            this.tlspBtnExcluir.Size = new System.Drawing.Size(52, 47);
            this.tlspBtnExcluir.Text = "toolStripButton3";
            this.tlspBtnExcluir.ToolTipText = "tlspBtnExcluir";
            this.tlspBtnExcluir.Click += new System.EventHandler(this.tlspBtnExcluir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // btnDuplicar
            // 
            this.btnDuplicar.AutoSize = false;
            this.btnDuplicar.CheckOnClick = true;
            this.btnDuplicar.Image = global::AutomatizadorDeTestes.WinAppForm.Properties.Resources.fasf_removebg_preview;
            this.btnDuplicar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDuplicar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuplicar.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnDuplicar.Name = "btnDuplicar";
            this.btnDuplicar.Size = new System.Drawing.Size(50, 50);
            this.btnDuplicar.Text = "Duplicar";
            this.btnDuplicar.Click += new System.EventHandler(this.btnDuplicar_Click);
            // 
            // tlspBtnPDF
            // 
            this.tlspBtnPDF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlspBtnPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlspBtnPDF.Image = global::AutomatizadorDeTestes.WinAppForm.Properties.Resources.picture_as_pdf_FILL0_wght400_GRAD0_opsz48;
            this.tlspBtnPDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlspBtnPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlspBtnPDF.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.tlspBtnPDF.Name = "tlspBtnPDF";
            this.tlspBtnPDF.Size = new System.Drawing.Size(52, 47);
            this.tlspBtnPDF.Text = "toolStripButton4";
            this.tlspBtnPDF.ToolTipText = "tlspBtnPDF";
            this.tlspBtnPDF.Click += new System.EventHandler(this.tlspBtnPDF_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // tlSpLblCadastro
            // 
            this.tlSpLblCadastro.Name = "tlSpLblCadastro";
            this.tlSpLblCadastro.Size = new System.Drawing.Size(124, 47);
            this.tlSpLblCadastro.Text = "[cadastroSelecionado]";
            // 
            // plRegistros
            // 
            this.plRegistros.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plRegistros.Location = new System.Drawing.Point(0, 78);
            this.plRegistros.Name = "plRegistros";
            this.plRegistros.Size = new System.Drawing.Size(800, 345);
            this.plRegistros.TabIndex = 3;
            // 
            // ssSpStatus
            // 
            this.ssSpStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ssSpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStsLblMensagem});
            this.ssSpStatus.Location = new System.Drawing.Point(0, 428);
            this.ssSpStatus.Name = "ssSpStatus";
            this.ssSpStatus.Size = new System.Drawing.Size(800, 22);
            this.ssSpStatus.TabIndex = 4;
            this.ssSpStatus.Text = "statusStrip1";
            // 
            // tlStsLblMensagem
            // 
            this.tlStsLblMensagem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlStsLblMensagem.Name = "tlStsLblMensagem";
            this.tlStsLblMensagem.Size = new System.Drawing.Size(84, 17);
            this.tlStsLblMensagem.Text = "[rodapeStatus]";
            // 
            // muSpCadastros
            // 
            this.muSpCadastros.BackColor = System.Drawing.SystemColors.ControlLight;
            this.muSpCadastros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.muSpCadastros.Location = new System.Drawing.Point(0, 0);
            this.muSpCadastros.Name = "muSpCadastros";
            this.muSpCadastros.Size = new System.Drawing.Size(800, 24);
            this.muSpCadastros.TabIndex = 5;
            this.muSpCadastros.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasToolStripMenuItem,
            this.matériasToolStripMenuItem,
            this.questõesToolStripMenuItem,
            this.testesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinasToolStripMenuItem
            // 
            this.disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            this.disciplinasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.disciplinasToolStripMenuItem.Text = "Disciplinas";
            this.disciplinasToolStripMenuItem.Click += new System.EventHandler(this.disciplinasToolStripMenuItem_Click);
            // 
            // matériasToolStripMenuItem
            // 
            this.matériasToolStripMenuItem.Name = "matériasToolStripMenuItem";
            this.matériasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.matériasToolStripMenuItem.Text = "Matérias";
            this.matériasToolStripMenuItem.Click += new System.EventHandler(this.matériasToolStripMenuItem_Click);
            // 
            // questõesToolStripMenuItem
            // 
            this.questõesToolStripMenuItem.Name = "questõesToolStripMenuItem";
            this.questõesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.questõesToolStripMenuItem.Text = "Questões";
            this.questõesToolStripMenuItem.Click += new System.EventHandler(this.questõesToolStripMenuItem_Click);
            // 
            // testesToolStripMenuItem
            // 
            this.testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            this.testesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.testesToolStripMenuItem.Text = "Testes";
            this.testesToolStripMenuItem.Click += new System.EventHandler(this.testesToolStripMenuItem_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssSpStatus);
            this.Controls.Add(this.plRegistros);
            this.Controls.Add(this.tlSpBotoes);
            this.Controls.Add(this.muSpCadastros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.muSpCadastros;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatizador de Testes da Dona Mariana";
            this.tlSpBotoes.ResumeLayout(false);
            this.tlSpBotoes.PerformLayout();
            this.ssSpStatus.ResumeLayout(false);
            this.ssSpStatus.PerformLayout();
            this.muSpCadastros.ResumeLayout(false);
            this.muSpCadastros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tlSpBotoes;
        private System.Windows.Forms.ToolStripButton tlspBtnAdicionar;
        private System.Windows.Forms.ToolStripButton tlspBtnEditar;
        private System.Windows.Forms.ToolStripButton tlspBtnExcluir;
        private System.Windows.Forms.ToolStripButton tlspBtnPDF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel plRegistros;
        private System.Windows.Forms.StatusStrip ssSpStatus;
        private System.Windows.Forms.ToolStripStatusLabel tlStsLblMensagem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tlSpLblCadastro;
        private System.Windows.Forms.MenuStrip muSpCadastros;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matériasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnDuplicar;
    }
}
