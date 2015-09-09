using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaPoupanca : Conta
    {
        //override : Para indicar que o método está sobrescrevendo um método da classe-pai.
        public override bool Saca (double valor)
        {
            this.Saldo -= (valor + 0.10);
            return true;
        }

        //a variavel base faz uma referencia ao método escrito na classe mãe
        public override void Atualiza(double taxa)
        {
            base.Atualiza(2 * taxa);
        }

    }
}
