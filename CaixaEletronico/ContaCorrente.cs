using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaCorrente : Conta
    {
        public override void Saca(double valor)
        {
            if (this.Saldo >= valor && valor > 0)
            {
                if (Cliente.EhMaiorDeIdade)
                {
                    this.Saldo -= valor;
                }
                else if (!Cliente.EhMaiorDeIdade && this.Saldo >= valor && valor <= 200.0)
                {
                    this.Saldo -= valor;
                    
                }
                else
                {
                    throw new SaldoException();
                }
            }
            else
            {
                throw new SaldoException();
            }
        }


    }
}
