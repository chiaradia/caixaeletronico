using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Banco
    {

        public ContaCorrente[] contas = new ContaCorrente[20];
        public int indice { get; set; }

        public void Adiciona (ContaCorrente c)
        {
            this.contas[this.indice] = c;
            this.indice++;
        }
    }
}
