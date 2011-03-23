using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using IrrKlang;

namespace Karaoke
{
    public partial class EditarMusica : Form
    {
        private List<Frase> frases;

        internal List<Frase> Frases
        {
            get { return frases; }
            set { frases = value; }
        }

        private Frase frase;

        internal Frase Frase
        {
            get { return frase; }
            set { frase = value; }
        }

        private String nomeMusica;
        private String caminhoMusica;
        private ISound musica;

        public EditarMusica()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\musicas\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlEditarMusica.Enabled = true;
                StreamReader rd = new StreamReader(openFileDialog1.FileName, true);
                List<String> arquivo = new List<string>();
                while (!rd.EndOfStream)
                {
                    arquivo.Add(rd.ReadLine());
                }
                txtNome.Text = arquivo[0];
                nomeMusica = txtNome.Text;
                txtCaminho.Text = Path.Combine(Application.StartupPath + "\\media", arquivo[1]);
                caminhoMusica = txtCaminho.Text;
                frases = new List<Frase>();
                arquivo.RemoveRange(0, 2);
                foreach (String textoFrase in arquivo)
                {
                    String[] componentes = textoFrase.Split('#');
                    Frase frase = new Frase(componentes[0], uint.Parse(componentes[1]), uint.Parse(componentes[2]));
                    frases.Add(frase);
                    lstFrases.Items.Add(frase);
                }
                rd.Close();
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = Application.StartupPath + "\\media\\";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = openFileDialog2.FileName;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCaminho.Text) || String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Informe o nome e o arquivo da música.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String caminhoOrigem = txtCaminho.Text;
            String nomeArquivo = caminhoOrigem.Substring(caminhoOrigem.LastIndexOf("\\") + 1).Replace(' ', '_');
            String caminhoDestino = Path.Combine(Application.StartupPath + "\\media", nomeArquivo);
            try
            {
                if (FileSystem.FileExists(Application.StartupPath + "\\musicas\\" + txtNome.Text + ".kar"))
                {
                    if(txtNome.Text.Equals(nomeMusica))
                    {
                        FileSystem.DeleteFile(Application.StartupPath + "\\musicas\\" + txtNome.Text + ".kar");
                    }
                    else
                    {
                        MessageBox.Show("Nome de música já existe. Escolha outro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (!FileSystem.FileExists(caminhoDestino))
                {
                    FileSystem.CopyFile(caminhoOrigem, caminhoDestino, UIOption.AllDialogs);
                }                
                StreamWriter wr = new StreamWriter(Application.StartupPath + "\\musicas\\" + txtNome.Text + ".kar", false);
                wr.WriteLine(txtNome.Text);
                wr.WriteLine(nomeArquivo);
                foreach (Frase frase in frases)
                {
                    wr.WriteLine(frase.Texto + "#" + frase.TempoInicio.ToString() + "#" + frase.TempoFim.ToString());
                }
                wr.Close();
                MessageBox.Show("Música cadastrada com sucesso.", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Não foi possível cadastrar a música.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.frase = null;
            new EditarCadastrarPalavra(this).ShowDialog(this);
        }

        internal void atualizaListBox()
        {
            lstFrases.Items.Clear();
            frases = (from fr in frases orderby fr.TempoInicio ascending select fr).ToList();
            foreach (Frase frase in frases)
            {
                lstFrases.Items.Add(frase);
                if (this.frase != null && this.frase == frase)
                {
                    lstFrases.SelectedItem = frase;
                }
            }            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstFrases.SelectedItem != null)
            {
                this.frase = (Frase)lstFrases.SelectedItem;
                new EditarCadastrarPalavra(this).ShowDialog(this);
            }            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstFrases.SelectedItem != null)
            {
                lstFrases.Items.Remove(lstFrases.SelectedItem);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            openFileDialog3.InitialDirectory = Application.StartupPath + "\\musicas\\";
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {               
                ISoundEngine engine = new ISoundEngine();
                musica = engine.Play2D(openFileDialog3.FileName);

                timer1.Start();

                btnPlay.Enabled = false;
                btnStop.Enabled = true;
                btnPause.Enabled = true;                
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            musica.Stop();
            btnPlay.Enabled = true;
            btnStop.Enabled = false;
            btnPause.Enabled = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            musica.Paused = !musica.Paused;
            btnStop.Enabled = !musica.Paused;            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!musica.Finished)
            {
                uint tempoAtual = musica.PlayPosition;

                lblTempoM.Text = tempoAtual.ToString();
                lblTempoHMS.Text = ((tempoAtual / (1000 * 60 * 60)) % 24) + ":" + 
                    ((tempoAtual / (1000 * 60)) % 60) + ":" + ((tempoAtual / 1000) % 60);
            }
        }           
    }
}
