namespace Karaoke
{
    partial class CadastrarMusicaV2
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddFrase = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lstFrases = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(59, 8);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 20);
            this.txtNome.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome:";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(203, 35);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 15;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(59, 37);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(138, 20);
            this.txtCaminho.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Arquivo:";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 6;
            this.lineShape1.X2 = 281;
            this.lineShape1.Y1 = 68;
            this.lineShape1.Y2 = 68;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(288, 497);
            this.shapeContainer1.TabIndex = 18;
            this.shapeContainer1.TabStop = false;
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(60, 82);
            this.txtFrase.Multiline = true;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFrase.Size = new System.Drawing.Size(219, 192);
            this.txtFrase.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Frase:";
            // 
            // btnAddFrase
            // 
            this.btnAddFrase.Location = new System.Drawing.Point(12, 294);
            this.btnAddFrase.Name = "btnAddFrase";
            this.btnAddFrase.Size = new System.Drawing.Size(164, 23);
            this.btnAddFrase.TabIndex = 22;
            this.btnAddFrase.Text = "Adicionar";
            this.btnAddFrase.UseVisualStyleBackColor = true;
            this.btnAddFrase.Click += new System.EventHandler(this.btnAddFrase_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(47, 441);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(195, 23);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Começar Timming";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "MP3|*.mp3|Wave|*.wav|Windows Media Audio|*.wma|OGG|*.ogg";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(184, 294);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(92, 23);
            this.btnRemover.TabIndex = 24;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(98, 470);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 23);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar Música";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lstFrases
            // 
            this.lstFrases.FormattingEnabled = true;
            this.lstFrases.Location = new System.Drawing.Point(13, 324);
            this.lstFrases.Name = "lstFrases";
            this.lstFrases.Size = new System.Drawing.Size(263, 108);
            this.lstFrases.TabIndex = 26;
            // 
            // CadastrarMusicaV2
            // 
            this.AcceptButton = this.btnAddFrase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 497);
            this.Controls.Add(this.lstFrases);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAddFrase);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "CadastrarMusicaV2";
            this.Text = "CadastrarMusicaV2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddFrase;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListBox lstFrases;
    }
}