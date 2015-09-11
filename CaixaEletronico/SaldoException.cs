using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class SaldoException : Exception
    {
        public SaldoException() : base("Saldo inválido")
        {
           
        }
    }
}
