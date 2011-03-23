namespace Karaoke
{
    partial class EditarCadastrarPalavra
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtTempoFim = new System.Windows.Forms.TextBox();
            this.txtTempoInicio = new System.Windows.Forms.TextBox();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(11, 84);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(182, 23);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtTempoFim
            // 
            this.txtTempoFim.Location = new System.Drawing.Point(99, 58);
            this.txtTempoFim.Name = "txtTempoFim";
            this.txtTempoFim.Size = new System.Drawing.Size(91, 20);
            this.txtTempoFim.TabIndex = 14;
            // 
            // txtTempoInicio
            // 
            this.txtTempoInicio.Location = new System.Drawing.Point(110, 33);
            this.txtTempoInicio.Name = "txtTempoInicio";
            this.txtTempoInicio.Size = new System.Drawing.Size(80, 20);
            this.txtTempoInicio.TabIndex = 13;
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(65, 9);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(125, 20);
            this.txtFrase.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "* em milissegundos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tempo de Fim*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tempo de Início*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Palavra:";
            // 
            // EditarCadastrarPalavra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 144);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtTempoFim);
            this.Controls.Add(this.txtTempoInicio);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "EditarCadastrarPalavra";
            this.Text = "Editar Palavra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarCadastrarPalavra_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtTempoFim;
        private System.Windows.Forms.TextBox txtTempoInicio;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}