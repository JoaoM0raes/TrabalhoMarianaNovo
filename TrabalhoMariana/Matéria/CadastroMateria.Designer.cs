﻿namespace GestãoTeste.Matéria
{
    partial class cadastroMateria
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDisciplina = new System.Windows.Forms.ComboBox();
            this.checkPrimeiraSerie = new System.Windows.Forms.CheckBox();
            this.checkSegundaSerie = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(77, 214);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(89, 30);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(186, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(263, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Disciplina";
            // 
            // comboDisciplina
            // 
            this.comboDisciplina.FormattingEnabled = true;
            this.comboDisciplina.Location = new System.Drawing.Point(12, 97);
            this.comboDisciplina.Name = "comboDisciplina";
            this.comboDisciplina.Size = new System.Drawing.Size(263, 23);
            this.comboDisciplina.TabIndex = 5;
            // 
            // checkPrimeiraSerie
            // 
            this.checkPrimeiraSerie.AutoSize = true;
            this.checkPrimeiraSerie.Location = new System.Drawing.Point(17, 155);
            this.checkPrimeiraSerie.Name = "checkPrimeiraSerie";
            this.checkPrimeiraSerie.Size = new System.Drawing.Size(64, 19);
            this.checkPrimeiraSerie.TabIndex = 6;
            this.checkPrimeiraSerie.Text = "1º série";
            this.checkPrimeiraSerie.UseVisualStyleBackColor = true;
            // 
            // checkSegundaSerie
            // 
            this.checkSegundaSerie.AutoSize = true;
            this.checkSegundaSerie.Location = new System.Drawing.Point(87, 155);
            this.checkSegundaSerie.Name = "checkSegundaSerie";
            this.checkSegundaSerie.Size = new System.Drawing.Size(64, 19);
            this.checkSegundaSerie.TabIndex = 7;
            this.checkSegundaSerie.Text = "2º série";
            this.checkSegundaSerie.UseVisualStyleBackColor = true;
            // 
            // cadastroMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 256);
            this.Controls.Add(this.checkSegundaSerie);
            this.Controls.Add(this.checkPrimeiraSerie);
            this.Controls.Add(this.comboDisciplina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadastroMateria";
            this.Text = "Cadastro Matéria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDisciplina;
        private System.Windows.Forms.CheckBox checkPrimeiraSerie;
        private System.Windows.Forms.CheckBox checkSegundaSerie;
    }
}