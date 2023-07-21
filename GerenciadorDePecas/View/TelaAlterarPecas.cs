using GerenciadorDePecas.Controller;
using GerenciadorDePecas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDePecas.View
{
    public partial class TelaAlterarPecas : Form
    {
        public TelaAlterarPecas()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(textBoxCod.Text);
            ManipulasPecas mpecas = new();
            mpecas.BuscarPecasCod();

            textBoxCodigo.Text = Pecas.Codigo.ToString();
            textBoxPeca.Text = Pecas.Peca;
            textBoxMarca.Text = Pecas.Marca;
            textBoxCapacidade.Text = Pecas.Capacidade;
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(textBoxCod.Text);
            Pecas.Peca = textBoxPeca.Text;
            Pecas.Marca = textBoxMarca.Text;
            Pecas.Capacidade = textBoxCapacidade.Text;

            ManipulasPecas mp = new();
            mp.AlterarPecas();
        }
    }
}
