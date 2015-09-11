using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    abstract class Conta
    {
        public string Numero { get; set; }
        public double Saldo { get; protected set; }
        public Titular Cliente { get; set; }

        //virtual: Para permitir que o método seja sobrescrito.
        public abstract void Saca(double valor);

        public void Deposita (double valor)
        {
            if (valor > 0)
                this.Saldo += valor;
        }

        public void Transfere (double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);

        }

        public virtual void Atualiza(double taxa)
        {
            this.Saldo += this.Saldo * taxa;
        }
    }
}
