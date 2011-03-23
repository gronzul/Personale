namespace Karaoke
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlFrases = new System.Windows.Forms.Panel();
            this.lblNomeMusica = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ferramentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMúsicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMúsicaV2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarMúsicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMusicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMúsicaV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarMúsicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrases
            // 
            this.pnlFrases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFrases.Location = new System.Drawing.Point(12, 49);
            this.pnlFrases.Name = "pnlFrases";
            this.pnlFrases.Size = new System.Drawing.Size(703, 56);
            this.pnlFrases.TabIndex = 1;
            // 
            // lblNomeMusica
            // 
            this.lblNomeMusica.AutoSize = true;
            this.lblNomeMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMusica.Location = new System.Drawing.Point(11, 33);
            this.lblNomeMusica.Name = "lblNomeMusica";
            this.lblNomeMusica.Size = new System.Drawing.Size(175, 13);
            this.lblNomeMusica.TabIndex = 5;
            this.lblNomeMusica.Text = "Nenhuma música selecionada";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ferramentasToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ferramentasToolStripMenuItem1
            // 
            this.ferramentasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarMúsicaToolStripMenuItem,
            this.cadastrarMúsicaV2ToolStripMenuItem1,
            this.editarMúsicaToolStripMenuItem1});
            this.ferramentasToolStripMenuItem1.Image = global::Karaoke.Properties.Resources.tools;
            this.ferramentasToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ferramentasToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.White;
            this.ferramentasToolStripMenuItem1.Name = "ferramentasToolStripMenuItem1";
            this.ferramentasToolStripMenuItem1.Size = new System.Drawing.Size(100, 20);
            this.ferramentasToolStripMenuItem1.Text = "Ferramentas";
            // 
            // cadastrarMúsicaToolStripMenuItem
            // 
            this.cadastrarMúsicaToolStripMenuItem.Name = "cadastrarMúsicaToolStripMenuItem";
            this.cadastrarMúsicaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cadastrarMúsicaToolStripMenuItem.Text = "Cadastrar Música";
            this.cadastrarMúsicaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMusicaToolStripMenuItem_Click);
            // 
            // cadastrarMúsicaV2ToolStripMenuItem1
            // 
            this.cadastrarMúsicaV2ToolStripMenuItem1.Name = "cadastrarMúsicaV2ToolStripMenuItem1";
            this.cadastrarMúsicaV2ToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.cadastrarMúsicaV2ToolStripMenuItem1.Text = "Cadastrar Música V2";
            this.cadastrarMúsicaV2ToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarMúsicaV2ToolStripMenuItem_Click);
            // 
            // editarMúsicaToolStripMenuItem1
            // 
            this.editarMúsicaToolStripMenuItem1.Name = "editarMúsicaToolStripMenuItem1";
            this.editarMúsicaToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.editarMúsicaToolStripMenuItem1.Text = "Editar Música";
            this.editarMúsicaToolStripMenuItem1.Click += new System.EventHandler(this.editarMúsicaToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarMusicaToolStripMenuItem,
            this.cadastrarMúsicaV2ToolStripMenuItem,
            this.editarMúsicaToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ferramentasToolStripMenuItem.Image")));
            this.ferramentasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ferramentasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // cadastrarMusicaToolStripMenuItem
            // 
            this.cadastrarMusicaToolStripMenuItem.Name = "cadastrarMusicaToolStripMenuItem";
            this.cadastrarMusicaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cadastrarMusicaToolStripMenuItem.Text = "Cadastrar Música";
            this.cadastrarMusicaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMusicaToolStripMenuItem_Click);
            // 
            // cadastrarMúsicaV2ToolStripMenuItem
            // 
            this.cadastrarMúsicaV2ToolStripMenuItem.Name = "cadastrarMúsicaV2ToolStripMenuItem";
            this.cadastrarMúsicaV2ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cadastrarMúsicaV2ToolStripMenuItem.Text = "Cadastrar Música V2";
            this.cadastrarMúsicaV2ToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMúsicaV2ToolStripMenuItem_Click);
            // 
            // editarMúsicaToolStripMenuItem
            // 
            this.editarMúsicaToolStripMenuItem.Name = "editarMúsicaToolStripMenuItem";
            this.editarMúsicaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.editarMúsicaToolStripMenuItem.Text = "Editar Música";
            this.editarMúsicaToolStripMenuItem.Click += new System.EventHandler(this.editarMúsicaToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Karaoke Files|*.kar";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::Karaoke.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(310, 111);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 80);
            this.btnStop.TabIndex = 12;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlay.Image = global::Karaoke.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(224, 111);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 80);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Image = global::Karaoke.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(396, 111);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(80, 80);
            this.btnPause.TabIndex = 16;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 203);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblNomeMusica);
            this.Controls.Add(this.pnlFrases);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karaoke";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFrases;
        private System.Windows.Forms.Label lblNomeMusica;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMusicaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMúsicaV2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarMúsicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMúsicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMúsicaV2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarMúsicaToolStripMenuItem1;
        private System.Windows.Forms.Button btnPause;
    }
}

