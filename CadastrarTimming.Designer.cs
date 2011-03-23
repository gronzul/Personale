namespace Karaoke
{
    partial class CadastrarTimming
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFrase = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.lstFrases = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(260, 28);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "MP3|*.mp3|Wave|*.wav|Windows Media Audio|*.wma|OGG|*.ogg";
            // 
            // btnFrase
            // 
            this.btnFrase.Location = new System.Drawing.Point(65, 59);
            this.btnFrase.Name = "btnFrase";
            this.btnFrase.Size = new System.Drawing.Size(75, 23);
            this.btnFrase.TabIndex = 2;
            this.btnFrase.Text = "Frase";
            this.btnFrase.UseVisualStyleBackColor = true;
            this.btnFrase.Click += new System.EventHandler(this.btnFrase_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.Location = new System.Drawing.Point(146, 59);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(75, 23);
            this.btnSpace.TabIndex = 3;
            this.btnSpace.Text = "Espaço";
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // lstFrases
            // 
            this.lstFrases.FormattingEnabled = true;
            this.lstFrases.Location = new System.Drawing.Point(12, 88);
            this.lstFrases.Name = "lstFrases";
            this.lstFrases.Size = new System.Drawing.Size(260, 160);
            this.lstFrases.TabIndex = 4;
            // 
            // CadastrarTimming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 267);
            this.Controls.Add(this.lstFrases);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.btnFrase);
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CadastrarTimming";
            this.Text = "Cadastrar Timing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFrase;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.ListBox lstFrases;
    }
}