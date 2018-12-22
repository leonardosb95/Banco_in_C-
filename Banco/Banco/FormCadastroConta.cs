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
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            comboTipoConta.Items.Add("Conta Corrente");
            comboTipoConta.Items.Add("Conta Poupança");

            //Adiciona o proximo numero de conta automaticamente na tela de cadastro
            var proxima = Conta.ProximaConta();
            textoNumero.Text = Convert.ToString(proxima);

           


        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            try
            {

                int indice = comboTipoConta.SelectedIndex;

                switch (indice)
                {
                    //case 0:
                    //    Conta novaConta = new Conta();
                    //    novaConta.Titular = new Cliente(textoTitular.Text);
                    //    novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                    //    this.formPrincipal.AdicionaConta(novaConta);//instancia o metodo AdicionaConta e joga a variavel nova conta como parametro
                    //    break;

                    case 0:
                        Conta novaContaCorrente = new ContaCorrente();
                        novaContaCorrente.Titular = new Cliente(textoTitular.Text);
                        novaContaCorrente.Numero = Convert.ToInt32(textoNumero.Text);
                        this.formPrincipal.AdicionaConta(novaContaCorrente);//instancia o metodo AdicionaConta e joga a variavel nova conta como parametro
                        break;

                    case 1:
                        Conta novaContaPoupanca = new ContaPoupanca();
                        novaContaPoupanca.Titular = new Cliente(textoTitular.Text);
                        novaContaPoupanca.Numero = Convert.ToInt32(textoNumero.Text);
                        this.formPrincipal.AdicionaConta(novaContaPoupanca);//instancia o metodo AdicionaConta e joga a variavel nova conta como parametro
                        break;

                    default:
                        MessageBox.Show("Opção invalida!!");
                        break;
                }
                MessageBox.Show("Cadastro realizado com sucesso!!");


            }
            catch (Exception)
            {
                MessageBox.Show("Cadastro não realizado!!");
                throw;
            }
            
        }

    }
}
