using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDePecas.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thiago.pnascimento9\source\repos\GerenciadorDePecas\GerenciadorDePecas\Model\pecaspcbd.mdf;Integrated Security=True";
        }
    }
}
