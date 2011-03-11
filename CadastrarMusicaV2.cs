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

namespace Karaoke
{
    public partial class CadastrarMusicaV2 : Form
    {
        public String caminhoMusica;
        public List<String> textoFrases;
        private List<Frase> frases;

        internal List<Frase> Frases
        {
            get { return frases; }
            set { frases = value; }
        }

        public CadastrarMusicaV2()
        {
            InitializeComponent();
            textoFrases = new List<string>();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                caminhoMusica = openFileDialog1.FileName;
                txtCaminho.Text = caminhoMusica;
            }
        }

        private void btnAddFrase_Click(object sender, EventArgs e)
        {            
            txtFrase.Text = txtFrase.Text.Replace('\n', ' ');
            txtFrase.Text = txtFrase.Text.Replace('\r', ' ');
            String[] letra = txtFrase.Text.Split(' ');
            foreach (String frase in letra)
            {
                frase.Trim();
                if (!String.IsNullOrEmpty(frase))
                {
                    textoFrases.Add(frase);
                    lstFrases.Items.Add(frase);
                }
            }            
            txtFrase.Text = "";
            txtFrase.Focus();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            new CadastrarTimming(this).ShowDialog(this);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstFrases.SelectedItems)
            {
                lstFrases.Items.Remove(item);
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
                    MessageBox.Show("Nome de música já existe. Escolha outro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (FileSystem.FileExists(caminhoDestino))
                {
                    MessageBox.Show("Arquivo de música já existente. Altere o nome do arquivo a ser importado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FileSystem.CopyFile(caminhoOrigem, caminhoDestino, UIOption.AllDialogs);
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
    }
}
