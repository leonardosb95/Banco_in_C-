using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;

namespace Banco
{
    public partial class Form1 : Form
    {
        //private Conta[] contas;//Array
        private List<Conta> contas = new List<Conta>();
        //Guarda o numero de contas que já foram cadastradas
        private Dictionary<string, Conta> dicionario;   

        //Adiciona uma nova conta
        public void AdicionaConta(Conta conta)
        {
            //this.contas[this.numeroDeContas] = conta;
            contas.Add(conta);
            //this.numeroDeContas++;
            //comboIndice.Items.Add("Titular: " + conta.Titular.Nome);
            //comboDestinoTransferencia.Items.Add("Titular: " + conta.Titular.Nome);

            //UTILIZANDO OBJECT DO METODO TOSTRING PARA ADD COM O PADRÃO MOSTRADO ACIMA

            comboIndice.Items.Add(conta);
            comboIndice.DisplayMember = "Numero";//Exibi o numero adicionada no atributo Numero da Conta
            comboDestinoTransferencia.Items.Add(conta);
            comboDestinoTransferencia.DisplayMember = "Numero";

            this.dicionario.Add(conta.Titular.Nome, conta);//Adicionando os cliente no Dictionary
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dicionario = new Dictionary<string, Conta>();

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

            //Conta c1 = new ContaPoupanca();
            //c1.Titular = new Cliente("Roberto");
            //c1.Numero = 1;
            //this.AdicionaConta(c1);
            

            //Conta c2 = new ContaCorrente();
            //c2.Titular = new Cliente("Fernando");
            //c2.Numero = 2;
            //this.AdicionaConta(c2);
         
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
            //int indice = Convert.ToInt32(comboIndice.SelectedIndex);
            //Conta selecionada = this.contas[indice];
            Conta selecionada = (Conta)comboIndice.SelectedItem;
            double valor = Convert.ToDouble(TextoValor.Text);



            try
            {

                selecionada.Deposita(valor);
                TextoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Deposito realizado com sucesso!!");
            }

            catch (ArgumentException)
            {
                MessageBox.Show("Erro ao tentar depositar valor negativo");
                
            }
          

            ////Soma todas as contas e joga no totalizador
            //TotalizadorDeContas saldoTotal = new TotalizadorDeContas();

            ////foreach (var item in contas)
            ////{
            ////    saldoTotal.Soma(item);
            ////}
            ////TextoSaldoTotal.Text = Convert.ToString(saldoTotal.ValorTotal);



        }
        //Botao saca
        private void botaoSaca_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboIndice.SelectedIndex);
            double valor = Convert.ToDouble(TextoValor.Text);
            Conta selecionada = this.contas[indice];

            try
            {
                selecionada.Saca(valor);
                    TextoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Saque realizado com sucesso!!");


            }
            catch (ArgumentException)
            {
                MessageBox.Show("Erro ao tentar depositar valor negativo");

            }

            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            finally{

                TextoValor.Text = "";
            } 



            //TOTAL DE TODAS AS CONTAS
            TotalizadorDeContas saldoTotal = new TotalizadorDeContas();

            //foreach (var item in contas)
            //{
            //    saldoTotal.Soma(item);
            //}
            //TextoSaldoTotal.Text = Convert.ToString(saldoTotal.ValorTotal);


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
            Conta contaDestino = (Conta)comboDestinoTransferencia.SelectedItem;
            Conta contaOrigem = (Conta)comboIndice.SelectedItem;
            string valorDigitado = TextoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            try
            {
                //Conta origem
                //int indiceOrigem = Convert.ToInt32(comboIndice.SelectedIndex);
                //Conta origem = this.contas[indiceOrigem];
                //Conta destino
                //int indiceDestino = Convert.ToInt32(comboDestinoTransferencia.SelectedIndex);
                //Conta destino = this.contas[indiceDestino];
                //Transfere o valor para a conta destino
                contaOrigem.Transfere(valorOperacao, contaDestino);
                //Atualiza o saldo após a transferência
                TextoSaldo.Text = Convert.ToString(contaOrigem.Saldo);
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao tentar realizar transferência!!");
            }
            
        

           




        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);//instanciar o FormCadastroConta
            formularioDeCadastro.ShowDialog();//Mostra o formulario de cadastro

        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            foreach (var conta in contas)
            {
                if (conta is ContaCorrente)
                {
                    totalizador.Adiciona((ContaCorrente)conta);//Utilizei o cast para converter conta para tipo ContaCorrente
                }
            }
            MessageBox.Show(Convert.ToString(totalizador.Total));





        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            string nomeTitular = textoBuscaTitular.Text;

            try
            {
                Conta conta = dicionario[nomeTitular];//Busca no Dicionario o cliente
                TextoTitular.Text = conta.Titular.Nome;
                TextoNumero.Text = Convert.ToString(conta.Numero);
                TextoSaldo.Text = Convert.ToString(conta.Saldo);

                comboIndice.SelectedItem = conta;
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente não cadastrado!!");
            }
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRelatorios formRelatorios = new FormRelatorios(this.contas);
            formRelatorios.ShowDialog();
        }

        private void botaoEditarTexto_Click(object sender, EventArgs e)
        {
            EditorDeTexto editorDeTexto = new EditorDeTexto();
            editorDeTexto.ShowDialog();
        }
    }
}
