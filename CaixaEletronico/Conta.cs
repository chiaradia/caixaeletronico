using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public string Numero { get; set; }
        public double Saldo { get; protected set; }
        public Titular Cliente { get; set; }

        //virtual: Para permitir que o método seja sobrescrito.
        public virtual bool Saca (double valor)
        {
            
            if (this.Saldo >= valor && valor > 0)
            {
                if (Cliente.EhMaiorDeIdade)
                {
                    this.Saldo -= valor;
                    return true;
                } else if (!Cliente.EhMaiorDeIdade && this.Saldo >= valor && valor <= 200.0)
                {
                    this.Saldo -= valor;
                    return true;
                } else {
                    return false;
                }
            } else
            {
                return false;
            }
                
        }

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
