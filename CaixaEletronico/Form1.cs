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
        private Banco banco;

        public Form1()
        {

            InitializeComponent();
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.conta = new ContaCorrente();
            this.titular = new Titular();
            this.banco = new Banco();
            this.totalizadorDeContas = new TotalizadorDeContas();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.conta.Cliente = this.titular;
            this.conta.Cliente.Nome = textoTitular.Text;
            this.conta.Cliente.Cpf = textoCPF.Text;
            this.conta.Cliente.Idade = Convert.ToInt32(textoIdade.Text);
            this.conta.Cliente.Endereco = textoEndereco.Text;
            this.conta.Numero = Convert.ToString(new Random().Next(1000, 9999));
            this.banco.Adiciona((ContaCorrente)this.conta);
            comboBanco.Items.Add(this.banco.contas[this.banco.indice-1].Cliente.Nome);
            MessageBox.Show("O cliente " + textoTitular.Text + " foi adicionado.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O saldo da conta é: "+ this.banco.contas[comboBanco.SelectedIndex].Saldo);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValor.Text);
            Conta contaSelecionada = this.BuscaContaSelecionada();
            contaSelecionada.Deposita(valor);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValor.Text);
            Conta contaSelecionada = this.BuscaContaSelecionada();
            contaSelecionada.Saca(valor);
        }

        private void comboBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            textoSaldoConta.Text = Convert.ToString(this.BuscaContaSelecionada().Saldo);
            textoNumeroConta.Text = Convert.ToString(this.BuscaContaSelecionada().Numero);
           
        }

        private Conta BuscaContaSelecionada()
        {
            int indiceSelecionado = comboBanco.SelectedIndex;
            return this.banco.contas[indiceSelecionado];
        }
    }
}
