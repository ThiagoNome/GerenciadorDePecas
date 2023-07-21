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
    public partial class MenuCentral : Form
    {
        public MenuCentral()
        {
            InitializeComponent();
        }

        private void siairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrasPecas telaCadastrar = new TelaCadastrasPecas();
            telaCadastrar.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarCodPecas telaPesquisar = new PesquisarCodPecas();
            telaPesquisar.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarPecas telaAlterar = new TelaAlterarPecas();
            telaAlterar.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeletarPecas telaDeletar = new TelaDeletarPecas();
            telaDeletar.Show();
        }
    }
}
