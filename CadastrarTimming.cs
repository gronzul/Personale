using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IrrKlang;

namespace Karaoke
{
    public partial class CadastrarTimming : Form
    {
        private List<String> textoFrases;
        private List<Frase> frases;
        private ISound musica;
        private int contador = 0;
        private uint lastTempoInicio = 0;
        private Frase lastFrase = null;
        CadastrarMusicaV2 frmPai;

        public CadastrarTimming(CadastrarMusicaV2 frmPai)
        {
            InitializeComponent();
            
            this.frmPai = frmPai;
            this.textoFrases = frmPai.textoFrases;
            if (textoFrases == null || textoFrases.Count < 1)
            {
                this.Dispose();
                return;
            }
            this.frases = new List<Frase>();
            btnFrase.Enabled = false;
            btnSpace.Enabled = false;
            MessageBox.Show("Nesta tela você poderá entrar com a música com vocal para ajudar na gravação do tempo das falas, porém esta deve ter os mesmos tempos que a música de playback para que a letra esteja em sincronia. Caso não queira, forneça a música de playback novamente.", "Cadastrar Tempo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }   

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Text.Equals("Stop"))
            {
                musica.Stop();
                btnPlay.Text = "Play";
                btnFrase.Enabled = false;
                btnSpace.Enabled = false;
            }
            else
            {
                openFileDialog1.InitialDirectory = Application.StartupPath + "\\musicas\\";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnFrase.Enabled = true;
                    btnSpace.Enabled = true;
                    btnPlay.Text = "Stop";
                    ISoundEngine engine = new ISoundEngine();
                    musica = engine.Play2D(openFileDialog1.FileName);
                    this.Focus();
                }
            }
        }

        private void btnFrase_Click(object sender, EventArgs e)
        {
            if (musica.Finished || contador > textoFrases.Count - 1)
            {
                finalizar();
            }

            if (lastFrase == null)
            {
                Frase frase = new Frase(textoFrases[contador], musica.PlayPosition - 50, musica.PlayLength);
                frases.Add(frase);
                lstFrases.Items.Add(frase);
                lstFrases.SelectedItem = frase;
                lastFrase = frase;
                contador++;
            }
            else
            {
                frases.Remove(lastFrase);
                lstFrases.Items.Remove(lastFrase);
                lastFrase.TempoFim = musica.PlayPosition - 50;
                frases.Add(lastFrase);
                lstFrases.Items.Add(lastFrase);

                Frase frase = new Frase(textoFrases[contador], musica.PlayPosition - 50, musica.PlayLength);
                frases.Add(frase);
                lstFrases.Items.Add(frase);
                lstFrases.SelectedItem = frase;
                lastFrase = frase;
                contador++;
            }          
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            if (musica.Finished || contador > textoFrases.Count - 1)
            {
                finalizar();
            }

            if (lastFrase != null)
            {
                frases.Remove(lastFrase);
                lstFrases.Items.Remove(lastFrase);
                lastFrase.TempoFim = musica.PlayPosition;
                frases.Add(lastFrase);
                lstFrases.Items.Add(lastFrase);
                lstFrases.SelectedItem = lastFrase;
                lastFrase = null;                
            }            
        }

        private void finalizar()
        {
            musica.Stop();
            frmPai.Frases = this.frases;
            this.Dispose();
        }
    }
}