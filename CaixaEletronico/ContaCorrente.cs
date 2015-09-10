using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaCorrente : Conta
    {
        public override bool Saca(double valor)
        {
            if (this.Saldo >= valor && valor > 0)
            {
                if (Cliente.EhMaiorDeIdade)
                {
                    this.Saldo -= valor;
                    return true;
                }
                else if (!Cliente.EhMaiorDeIdade && this.Saldo >= valor && valor <= 200.0)
                {
                    this.Saldo -= valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


    }
}
