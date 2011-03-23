using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke
{
    public partial class EditarCadastrarPalavra : Form
    {
        private EditarMusica frmPai;

        public EditarCadastrarPalavra(EditarMusica frmPai)
        {
            InitializeComponent();
            this.frmPai = frmPai;
            if (frmPai.Frase != null)
            {
                txtFrase.Text = frmPai.Frase.Texto;
                txtTempoInicio.Text = frmPai.Frase.TempoInicio.ToString();
                txtTempoFim.Text = frmPai.Frase.TempoFim.ToString();
                frmPai.Frases.Remove(frmPai.Frase);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sobrepoeFrase(uint.Parse(txtTempoInicio.Text), uint.Parse(txtTempoFim.Text), frmPai.Frases))
                {
                    MessageBox.Show("O tempo da palavra a ser adicionada entra em conflito com as outras já adicionadas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (frmPai.Frase == null)
                {
                    frmPai.Frases.Add(new Frase(txtFrase.Text, uint.Parse(txtTempoInicio.Text), uint.Parse(txtTempoFim.Text)));
                }
                else
                {
                    frmPai.Frase.Texto = txtFrase.Text;
                    frmPai.Frase.TempoInicio = uint.Parse(txtTempoInicio.Text);
                    frmPai.Frase.TempoFim = uint.Parse(txtTempoFim.Text);
                    frmPai.Frases.Add(frmPai.Frase);
                }
                frmPai.atualizaListBox();
                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Informe o tempo em milissegundos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool sobrepoeFrase(uint tempoInicio, uint tempoFim, List<Frase> frases)
        {
            foreach (Frase fraseDaLista in frases)
            {
                if ((tempoInicio > fraseDaLista.TempoInicio && tempoInicio < fraseDaLista.TempoFim)
                    || (tempoFim > fraseDaLista.TempoInicio && tempoFim < fraseDaLista.TempoFim)
                    || (tempoInicio < fraseDaLista.TempoInicio && tempoFim > fraseDaLista.TempoFim))
                {
                    return true;
                }
            }
            return false;
        }

        private void EditarCadastrarPalavra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmPai.Frase != null && !frmPai.Frases.Contains(frmPai.Frase))
            {
                frmPai.Frase.Texto = txtFrase.Text;
                frmPai.Frase.TempoInicio = uint.Parse(txtTempoInicio.Text);
                frmPai.Frase.TempoFim = uint.Parse(txtTempoFim.Text);
                frmPai.Frases.Add(frmPai.Frase);
                frmPai.atualizaListBox();
            }
        }
    }
}
