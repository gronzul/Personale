﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke
{
    public partial class CadastrarPalavra : Form
    {
        private List<Frase> frases;
        private CadastrarMusica frmPai;

        public CadastrarPalavra(CadastrarMusica frmPai)
        {
            InitializeComponent();
            this.frases = frmPai.Frases;
            this.frmPai = frmPai;
            if (frmPai.Frase != null)
            {
                txtFrase.Text = frmPai.Frase.Texto;
                txtTempoInicio.Text = frmPai.Frase.TempoInicio.ToString();
                txtTempoFim.Text = frmPai.Frase.TempoFim.ToString();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {            
            try
            {
                if(sobrepoeFrase(uint.Parse(txtTempoInicio.Text), uint.Parse(txtTempoFim.Text), frases))
                {
                    MessageBox.Show("O tempo da palavra a ser adicionada entra em conflito com as outras já adicionadas", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (frmPai.Frase == null)
                {
                    frases.Add(new Frase(txtFrase.Text, uint.Parse(txtTempoInicio.Text), uint.Parse(txtTempoFim.Text)));
                }
                else
                {
                    frmPai.Frase.Texto = txtFrase.Text;
                    frmPai.Frase.TempoInicio = uint.Parse(txtTempoInicio.Text);
                    frmPai.Frase.TempoFim = uint.Parse(txtTempoFim.Text);
                    frases.Add(frmPai.Frase);
                }
                frmPai.atualizaListView();
                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Informe o tempo em milissegundos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void CadastrarPalavra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmPai.Frase != null && !frases.Contains(frmPai.Frase))
            {
                frmPai.Frase.Texto = txtFrase.Text;
                frmPai.Frase.TempoInicio = uint.Parse(txtTempoInicio.Text);
                frmPai.Frase.TempoFim = uint.Parse(txtTempoFim.Text);
                frases.Add(frmPai.Frase);
                frmPai.atualizaListView();
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
    }
}
