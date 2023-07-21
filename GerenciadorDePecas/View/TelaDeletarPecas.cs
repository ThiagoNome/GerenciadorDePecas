using GerenciadorDePecas.Controller;
using GerenciadorDePecas.Model;
using Microsoft.Identity.Client;
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
    public partial class TelaDeletarPecas : Form
    {
        public TelaDeletarPecas()
        {
            InitializeComponent();
        }

        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(textBoxCodigo.Text);

            ManipulasPecas mpecas = new();
            mpecas.BuscarPecasCod();

            textBoxCodigoVer.Text = Pecas.Codigo.ToString();
            textBoxPecas.Text = Pecas.Peca;
            textBoxMarcas.Text = Pecas.Marca;
            textBoxCapacidade.Text = Pecas.Capacidade;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(textBoxCodigoVer.Text);

            ManipulasPecas mpecas = new();
            mpecas.DeletarPecas();


        }
        
    }
}
