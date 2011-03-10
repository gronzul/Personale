using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IrrKlang;
using System.Threading;
using System.IO;

namespace Karaoke
{
    public partial class frmPrincipal : Form
    {
        private ISound musica;
        private List<Frase> frases;
        private List<Frase> frasesParaExibir;
        private uint lastTempoFim = 0;
        
        public frmPrincipal()
        {
            InitializeComponent();            
        }

        private Frase getFraseAtual(uint tempoAtual)
        {
            foreach (Frase frase in frases)
            {
                if (frase.TempoInicio <= tempoAtual && frase.TempoFim >= tempoAtual)
                    return frase;
            }
            return new Frase("?", tempoAtual, tempoAtual);
        }

        private Frase getProximaFrase(uint tempoAtual)
        {
            Frase possivelFrase = null;
            foreach (Frase frase in frases)
            {
                if (possivelFrase == null)
                {
                    if(frase.TempoInicio > tempoAtual)
                        possivelFrase = frase;
                }
                else if(frase.TempoInicio < possivelFrase.TempoInicio)
                {
                    possivelFrase = frase;
                }               
            }
            if (possivelFrase == null)
            {
                return new Frase("?", tempoAtual, tempoAtual);
            }            
            return possivelFrase;            
        }        

        private void renderizarFrases(List<Frase> frases)
        {
            pnlFrases.Controls.Clear();
            int numeroCaracteres = 0;
            bool quebraLinha = false;
            Label lblFrase;
            Label ultimaLabel = null;
            foreach (Frase frase in frases)
            {
                lblFrase = new Label();
                lblFrase.AutoSize = true;
                lblFrase.Font = new Font(FontFamily.GenericSansSerif, 12);
                lblFrase.Text = frase.Texto;                
                lblFrase.Name = frase.TempoInicio.ToString();
                if (numeroCaracteres > 50)
                {
                    lblFrase.Top = 21;
                    if (!quebraLinha)
                    {
                        ultimaLabel = null;
                        quebraLinha = true;
                    }
                }
                if (ultimaLabel != null)
                {
                    lblFrase.Left = ultimaLabel.Width + ultimaLabel.Left + 1;
                }
                numeroCaracteres += frase.Texto.Length;
                pnlFrases.Controls.Add(lblFrase);
                ultimaLabel = lblFrase;
            }            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (musica.Finished)
            {
                btnStop_Click_1(null, null);
            }

            if (musica.PlayPosition > frasesParaExibir.Last().TempoFim)
            {
                frasesParaExibir = getFrasesParaExibicao(frases, musica.PlayPosition);
                renderizarFrases(frasesParaExibir);
            }
            Frase fraseAtual = getFraseAtual(musica.PlayPosition);
            if (musica.PlayPosition > lastTempoFim && !fraseAtual.Texto.Equals("?"))
            {
                lastTempoFim = fraseAtual.TempoFim;
                bool verificado = false;
                foreach (Control lbl in pnlFrases.Controls)
                {
                    if (lbl.Font.Bold)
                    {
                        lbl.Font = new Font(pnlFrases.Controls[0].Font, FontStyle.Regular);
                        if (verificado)
                            break;
                        verificado = true;
                    }
                    if (lbl.Name.Equals(fraseAtual.TempoInicio.ToString()))
                    {
                        lbl.Font = new Font(pnlFrases.Controls[0].Font, FontStyle.Bold);
                        if (verificado)
                            break;
                        verificado = true;
                    }
                }
            }
        }

        private void cadastrarMusicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastrarMusica().ShowDialog(this);
        }

        private List<Frase> getFrasesParaExibicao(List<Frase> frases, uint tempoAtual)
        {
            int numeroCaracteres = 0;
            List<Frase> frasesParaExibicao = new List<Frase>();
            List<Frase> frasesPossiveis = (from fr in frases
                                           where fr.TempoInicio > tempoAtual || (fr.TempoInicio < tempoAtual && tempoAtual < fr.TempoFim) 
                                           orderby fr.TempoInicio ascending
                                           select fr).ToList();             
            foreach (Frase frase in frasesPossiveis)
            {
                frasesParaExibicao.Add(frase);
                numeroCaracteres += frase.Texto.Length;
                if (numeroCaracteres > 100)
                    break;                
            }
            if (frasesParaExibicao.Count < 1)
            {
                frasesParaExibicao.Add(new Frase("...", tempoAtual, musica.PlayLength));
            }
            return frasesParaExibicao;
        }        

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\musicas\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnPlay.Enabled = false;
                btnStop.Enabled = true;

                ISoundEngine engine = new ISoundEngine();
                StreamReader rd = new StreamReader(openFileDialog1.FileName, true);
                List<String> arquivo = new List<string>();
                while (!rd.EndOfStream)
                {
                    arquivo.Add(rd.ReadLine());
                }
                String nomeMusica = arquivo[0];
                String caminhoMusica = Path.Combine(Application.StartupPath + "\\media", arquivo[1]);
                frases = new List<Frase>();
                arquivo.RemoveRange(0, 2);
                foreach (String frase in arquivo)
                {
                    String[] componentes = frase.Split('#');
                    frases.Add(new Frase(componentes[0], uint.Parse(componentes[1]), uint.Parse(componentes[2])));
                }
                lblNomeMusica.Text = nomeMusica;
                musica = engine.Play2D(caminhoMusica);
                timer1.Start();
                frasesParaExibir = getFrasesParaExibicao(frases, musica.PlayPosition);
                renderizarFrases(frasesParaExibir);
                musica.Volume = 1;
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            pnlFrases.Controls.Clear();
            timer1.Stop();
            musica.Stop();
            lblNomeMusica.Text = "Nenhuma música selecionada";

            btnPlay.Enabled = true;
            btnStop.Enabled = false;
        }      
    }
}