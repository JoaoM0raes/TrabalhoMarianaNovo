namespace GestãoTeste.Questões
{
    partial class CadastroQuestão
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboDisciplina = new System.Windows.Forms.ComboBox();
            this.comboMateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEnunciado = new System.Windows.Forms.TextBox();
            this.listAlternativas = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAlternativa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(238, 433);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(81, 34);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(325, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 34);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // comboDisciplina
            // 
            this.comboDisciplina.FormattingEnabled = true;
            this.comboDisciplina.Location = new System.Drawing.Point(39, 27);
            this.comboDisciplina.Name = "comboDisciplina";
            this.comboDisciplina.Size = new System.Drawing.Size(367, 23);
            this.comboDisciplina.TabIndex = 2;
            this.comboDisciplina.SelectedValueChanged += new System.EventHandler(this.comboDisciplina_SelectedValueChanged);
            // 
            // comboMateria
            // 
            this.comboMateria.FormattingEnabled = true;
            this.comboMateria.Location = new System.Drawing.Point(39, 71);
            this.comboMateria.Name = "comboMateria";
            this.comboMateria.Size = new System.Drawing.Size(367, 23);
            this.comboMateria.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Disiciplina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matéria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enunciado";
            // 
            // textEnunciado
            // 
            this.textEnunciado.Location = new System.Drawing.Point(39, 115);
            this.textEnunciado.Name = "textEnunciado";
            this.textEnunciado.Size = new System.Drawing.Size(367, 23);
            this.textEnunciado.TabIndex = 7;
            // 
            // listAlternativas
            // 
            this.listAlternativas.FormattingEnabled = true;
            this.listAlternativas.ItemHeight = 15;
            this.listAlternativas.Location = new System.Drawing.Point(37, 257);
            this.listAlternativas.Name = "listAlternativas";
            this.listAlternativas.Size = new System.Drawing.Size(369, 154);
            this.listAlternativas.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alternativas";
            // 
            // textAlternativa
            // 
            this.textAlternativa.Location = new System.Drawing.Point(37, 228);
            this.textAlternativa.Name = "textAlternativa";
            this.textAlternativa.Size = new System.Drawing.Size(229, 23);
            this.textAlternativa.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Resposta";
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.Location = new System.Drawing.Point(306, 226);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(75, 24);
            this.btnAdcionar.TabIndex = 13;
            this.btnAdcionar.Text = "Adicionar ";
            this.btnAdcionar.UseVisualStyleBackColor = true;
            this.btnAdcionar.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // CadastroQuestão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 493);
            this.Controls.Add(this.btnAdcionar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textAlternativa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listAlternativas);
            this.Controls.Add(this.textEnunciado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMateria);
            this.Controls.Add(this.comboDisciplina);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroQuestão";
            this.Text = "Cadastro De Questões";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboDisciplina;
        private System.Windows.Forms.ComboBox comboMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEnunciado;
        private System.Windows.Forms.ListBox listAlternativas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAlternativa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdcionar;
    }
}