using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Titular
    {
        public string Nome
        {
            get; set;
        }

        public string Endereco
        {
            get; set;
        }

        public string Cpf
        {
            get; set;
        }

        public int Idade
        {
            get; set;
        }


        public bool EhMaiorDeIdade
        {
            get { return this.Idade >= 18; }
        }

    }
}
