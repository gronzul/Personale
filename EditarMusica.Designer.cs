namespace Karaoke
{
    partial class EditarMusica
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarMusica));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlEditarMusica = new System.Windows.Forms.Panel();
            this.lblTempoM = new System.Windows.Forms.Label();
            this.lblTempoHMS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lstFrases = new System.Windows.Forms.ListBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.pnlEditarMusica.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Karaoke Files|*.kar";
            // 
            // pnlEditarMusica
            // 
            this.pnlEditarMusica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditarMusica.Controls.Add(this.lblTempoM);
            this.pnlEditarMusica.Controls.Add(this.lblTempoHMS);
            this.pnlEditarMusica.Controls.Add(this.label3);
            this.pnlEditarMusica.Controls.Add(this.label2);
            this.pnlEditarMusica.Controls.Add(this.btnPause);
            this.pnlEditarMusica.Controls.Add(this.btnStop);
            this.pnlEditarMusica.Controls.Add(this.btnPlay);
            this.pnlEditarMusica.Controls.Add(this.btnSalvar);
            this.pnlEditarMusica.Controls.Add(this.lblArquivo);
            this.pnlEditarMusica.Controls.Add(this.label1);
            this.pnlEditarMusica.Controls.Add(this.btnProcurar);
            this.pnlEditarMusica.Controls.Add(this.txtCaminho);
            this.pnlEditarMusica.Controls.Add(this.txtNome);
            this.pnlEditarMusica.Controls.Add(this.btnRemover);
            this.pnlEditarMusica.Controls.Add(this.btnEditar);
            this.pnlEditarMusica.Controls.Add(this.btnAdicionar);
            this.pnlEditarMusica.Controls.Add(this.lstFrases);
            this.pnlEditarMusica.Enabled = false;
            this.pnlEditarMusica.Location = new System.Drawing.Point(12, 42);
            this.pnlEditarMusica.Name = "pnlEditarMusica";
            this.pnlEditarMusica.Size = new System.Drawing.Size(304, 416);
            this.pnlEditarMusica.TabIndex = 0;
            // 
            // lblTempoM
            // 
            this.lblTempoM.AutoSize = true;
            this.lblTempoM.Location = new System.Drawing.Point(151, 107);
            this.lblTempoM.Name = "lblTempoM";
            this.lblTempoM.Size = new System.Drawing.Size(0, 13);
            this.lblTempoM.TabIndex = 19;
            // 
            // lblTempoHMS
            // 
            this.lblTempoHMS.AutoSize = true;
            this.lblTempoHMS.Location = new System.Drawing.Point(138, 90);
            this.lblTempoHMS.Name = "lblTempoHMS";
            this.lblTempoHMS.Size = new System.Drawing.Size(0, 13);
            this.lblTempoHMS.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tempo (Milissegundos) -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tempo (HH:MM:SS) -";
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Image = global::Karaoke.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(199, 4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(80, 80);
            this.btnPause.TabIndex = 15;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::Karaoke.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(112, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 80);
            this.btnStop.TabIndex = 14;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlay.Image = global::Karaoke.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(26, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 80);
            this.btnPlay.TabIndex = 13;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(49, 367);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(200, 29);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(7, 168);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(46, 13);
            this.lblArquivo.TabIndex = 8;
            this.lblArquivo.Text = "Arquivo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(199, 165);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(89, 21);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(53, 165);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(135, 20);
            this.txtCaminho.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 138);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 20);
            this.txtNome.TabIndex = 4;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(199, 251);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(89, 21);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(199, 222);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 21);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(199, 193);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(89, 21);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lstFrases
            // 
            this.lstFrases.FormattingEnabled = true;
            this.lstFrases.Location = new System.Drawing.Point(10, 190);
            this.lstFrases.Name = "lstFrases";
            this.lstFrases.Size = new System.Drawing.Size(178, 160);
            this.lstFrases.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(94, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(144, 24);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir Música";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "MP3|*.mp3|Wave|*.wav|Windows Media Audio|*.wma|OGG|*.ogg";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.Filter = "MP3|*.mp3|Wave|*.wav|Windows Media Audio|*.wma|OGG|*.ogg";
            // 
            // EditarMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 470);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.pnlEditarMusica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditarMusica";
            this.Text = "Editar Música";
            this.pnlEditarMusica.ResumeLayout(false);
            this.pnlEditarMusica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlEditarMusica;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lstFrases;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTempoM;
        private System.Windows.Forms.Label lblTempoHMS;
    }
}