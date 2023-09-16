using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletros
{
    internal class Venda
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public double Valor { get; set; }

        public int Lucro { get; set; }
        public int Quantidade { get; set; }

        public Venda()
        {

        }
        public Venda(string id, string nome, double valor, int lucro, int quantidade)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Valor = Valor;
            this.Lucro = Lucro;
            Quantidade = quantidade;
        }
        public double ValorVenda(double valor, int lucro) 
        {
            return valor * lucro / 100 + valor;
        }
    }
}
