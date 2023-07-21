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
    public partial class TelaCadastrasPecas : Form
    {
        public TelaCadastrasPecas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pecas.Peca = textBoxPecas.Text;
            Pecas.Marca = textBoxMarcas.Text;
            Pecas.Capacidade = textBoxCapacidades.Text;

            ManipulasPecas mPecas = new ManipulasPecas();
            mPecas.CadPeccas();
        }
        public void AbrirCadastro()
        {
            this.ShowDialog();
        }
    }
}
