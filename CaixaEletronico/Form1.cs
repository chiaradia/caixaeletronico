using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {

        private Conta conta;
        private Titular titular;
        private TotalizadorDeContas totalizadorDeContas;

        public Form1()
        {

            InitializeComponent();
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.conta = new Conta();
            this.titular = new Titular();
            this.totalizadorDeContas = new TotalizadorDeContas();
            this.conta.Deposita(250.0);
            MessageBox.Show("Saldo: " + this.conta.Saldo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.conta.Cliente = this.titular;
            this.conta.Cliente.Nome = textoTitular.Text;
            this.conta.Cliente.Cpf = textoCPF.Text;
            this.conta.Cliente.Idade = Convert.ToInt32(textoIdade.Text);
            this.conta.Cliente.Endereco = textoEndereco.Text;
            MessageBox.Show(this.conta.Cliente.Nome);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O saldo da conta é: "+this.conta.Saldo);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValor.Text);
            this.conta.Deposita(valor);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValor.Text);
            this.conta.Saca(valor);
        }
    }
}
