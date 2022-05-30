namespace TrabalhoMariana
{
    partial class TelaFormPrincipal
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
            this.toolBox1 = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolTipPdf = new System.Windows.Forms.ToolStripButton();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.toolBox = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matériaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questõesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.toolBox1.SuspendLayout();
            this.toolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBox1
            // 
            this.toolBox1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir,
            this.toolTipPdf,
            this.labelTipoCadastro});
            this.toolBox1.Location = new System.Drawing.Point(0, 24);
            this.toolBox1.Name = "toolBox1";
            this.toolBox1.Padding = new System.Windows.Forms.Padding(5);
            this.toolBox1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolBox1.Size = new System.Drawing.Size(674, 33);
            this.toolBox1.TabIndex = 0;
            this.toolBox1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.Image = global::GestaoTeste.Properties.Resources.add_FILL0_wght400_GRAD0_opsz48;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(78, 20);
            this.btnInserir.Text = "Adicionar";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::GestaoTeste.Properties.Resources.edit_FILL0_wght400_GRAD0_opsz48;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 20);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::GestaoTeste.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz48;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(62, 20);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolTipPdf
            // 
            this.toolTipPdf.Image = global::GestaoTeste.Properties.Resources.picture_as_pdf_FILL0_wght400_GRAD0_opsz48;
            this.toolTipPdf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTipPdf.Name = "toolTipPdf";
            this.toolTipPdf.Size = new System.Drawing.Size(117, 20);
            this.toolTipPdf.Text = "Vizualizar Em pdf";
            this.toolTipPdf.Click += new System.EventHandler(this.toolTipPdf_Click);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(80, 20);
            this.labelTipoCadastro.Text = "Tipo Cadastro";
            // 
            // toolBox
            // 
            this.toolBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.toolBox.Location = new System.Drawing.Point(0, 0);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(674, 24);
            this.toolBox.TabIndex = 1;
            this.toolBox.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasMenuItem,
            this.matériaMenuItem,
            this.questõesMenuItem,
            this.testesMenuItem,
            this.cadastrosToolStripMenuItem1});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinasMenuItem
            // 
            this.disciplinasMenuItem.Name = "disciplinasMenuItem";
            this.disciplinasMenuItem.Size = new System.Drawing.Size(130, 22);
            this.disciplinasMenuItem.Text = "Disciplinas";
            this.disciplinasMenuItem.Click += new System.EventHandler(this.disciplinasMenuItem_Click);
            // 
            // matériaMenuItem
            // 
            this.matériaMenuItem.Name = "matériaMenuItem";
            this.matériaMenuItem.Size = new System.Drawing.Size(130, 22);
            this.matériaMenuItem.Text = "Matéria";
            this.matériaMenuItem.Click += new System.EventHandler(this.matériaMenuItem_Click);
            // 
            // questõesMenuItem
            // 
            this.questõesMenuItem.Name = "questõesMenuItem";
            this.questõesMenuItem.Size = new System.Drawing.Size(130, 22);
            this.questõesMenuItem.Text = "Questões";
            this.questõesMenuItem.Click += new System.EventHandler(this.questõesMenuItem_Click);
            // 
            // testesMenuItem
            // 
            this.testesMenuItem.Name = "testesMenuItem";
            this.testesMenuItem.Size = new System.Drawing.Size(130, 22);
            this.testesMenuItem.Text = "Testes ";
            this.testesMenuItem.Click += new System.EventHandler(this.testesMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem1
            // 
            this.cadastrosToolStripMenuItem1.Name = "cadastrosToolStripMenuItem1";
            this.cadastrosToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.cadastrosToolStripMenuItem1.Text = "Cadastros";
            // 
            // panelRegistros
            // 
            this.panelRegistros.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelRegistros.Location = new System.Drawing.Point(0, 57);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(674, 393);
            this.panelRegistros.TabIndex = 2;
            // 
            // TelaFormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.toolBox1);
            this.Controls.Add(this.toolBox);
            this.MainMenuStrip = this.toolBox;
            this.Name = "TelaFormPrincipal";
            this.Text = "Tela Principal";
            this.toolBox1.ResumeLayout(false);
            this.toolBox1.PerformLayout();
            this.toolBox.ResumeLayout(false);
            this.toolBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBox1;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton toolTipPdf;
        private System.Windows.Forms.MenuStrip toolBox;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matériaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questõesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testesMenuItem;
        private System.Windows.Forms.Panel panelRegistros;
        private System.Windows.Forms.ToolStripLabel labelTipoCadastro;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem1;
    }
}
