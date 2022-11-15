using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaMercado
{
    public class Cliente
    {
        public int Id;
        public string Nome, CPF;
        public Endereco End;
        public double[] valorProduto;
        public string[] nomeProduto;
        public Cliente prox, ant;
    }
}
