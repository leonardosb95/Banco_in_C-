using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        //private Conta[] contas;//Array
        private List<Conta> contas= new List<Conta>();
        //Guarda o numero de contas que já foram cadastradas
        private int numeroDeContas;//Conta o numero de contas existentes

        //Adiciona uma nova conta
        public void AdicionaConta(Conta conta)
        {
            //this.contas[this.numeroDeContas] = conta;
            contas.Add(conta);
            this.numeroDeContas++;
            comboIndice.Items.Add("Titular: " + conta.Titular.Nome);
            comboDestinoTransferencia.Items.Add("Titular: " + conta.Titular.Nome);


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //contas = new Conta[10];

            //this.contas[0] = new Conta();
            //this.contas[0].Titular = new Cliente("Leonardo", 23);
            //this.contas[0].Numero = 1;
            //numeroDeContas++;

            //this.contas[1] = new ContaPoupanca();
            //this.contas[1].Titular = new Cliente("Roberto", 20);
            //this.contas[1].Numero = 2;
            //numeroDeContas++;


            //this.contas[2] = new ContaCorrente();
            //this.contas[2].Titular = new Cliente("Fernando", 40);
            //this.contas[2].Numero = 3;
            //numeroDeContas++;

            //Conta c1 = new Conta();
            //c1.Titular = new Cliente("Leonardo");
            //c1.Numero = 1;
            //this.AdicionaConta(c1);

            Conta c1 = new ContaPoupanca();
            c1.Titular = new Cliente("Roberto");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new ContaCorrente();
            c2.Titular = new Cliente("Fernando");
            c2.Numero = 2;
            this.AdicionaConta(c2);


            ////Exibi no combox as contas adicionadas do array contas
            //foreach (var conta in contas)
            //{
            //    comboIndice.Items.Add("Titular: "+ conta.Titular.Nome);
            //}

            //Exibi no combox de transferência as contas adicionadas do array contas

            //foreach (var conta in contas)
            //{
            //        comboDestinoTransferencia.Items.Add("Titular "+ conta.Titular.Nome);
            //}


        }
        //Deposita 
        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = Convert.ToInt32(comboIndice.SelectedIndex);
                string valorDigitado = TextoValor.Text;
                double valorOperacao = Convert.ToDouble(valorDigitado);
                this.contas[indice].Deposita(valorOperacao);
                TextoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);

                //Soma todas as contas e joga no totalizador
                TotalizadorDeContas saldoTotal = new TotalizadorDeContas();

                foreach (var item in contas)
                {
                    saldoTotal.Soma(item);
                }
                TextoSaldoTotal.Text = Convert.ToString(saldoTotal.ValorTotal);

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar depositar");
                throw;
            }

           

        }
        //Botao saca
        private void botaoSaca_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboIndice.SelectedIndex);
            string valorDigitado = TextoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.contas[indice].Saca(valorOperacao);
            TextoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);

            //TOTAL DE TODAS AS CONTAS
            TotalizadorDeContas saldoTotal = new TotalizadorDeContas();

            foreach (var item in contas)
            {
                saldoTotal.Soma(item);
            }
            TextoSaldoTotal.Text = Convert.ToString(saldoTotal.ValorTotal);

        }

        //Exibi os detalhes da conta no formulario ao ser selecionada
        private void comboIndice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboIndice.SelectedIndex);
            Conta selecionada = this.contas[indice];
            TextoNumero.Text = Convert.ToString(selecionada.Numero);
            TextoTitular.Text = Convert.ToString(selecionada.Titular.Nome);
            TextoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        //Botao de transferência
        private void botaoTransferenciaDestino_Click(object sender, EventArgs e)
        {
            //Conta origem
            int indiceOrigem = Convert.ToInt32(comboIndice.SelectedIndex);
            Conta origem = this.contas[indiceOrigem];
            //Conta destino
            int indiceDestino = Convert.ToInt32(comboDestinoTransferencia.SelectedIndex);
            Conta destino = this.contas[indiceDestino];

            //Pega o valor que vai ser transferido
            string valorDigitado = TextoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            //Transfere o valor para a conta destino
            origem.Transfere(valorOperacao,destino);

            //Atualiza o saldo após a transferência
            TextoSaldo.Text = Convert.ToString(origem.Saldo);

        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);//instanciar o FormCadastroConta
            formularioDeCadastro.ShowDialog();//Mostra o formulario de cadastro

        }
    }
}
