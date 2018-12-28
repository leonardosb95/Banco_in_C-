﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;
using Banco.Busca;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;
        private ICollection<string> devedores;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeralList();//Recebe os 3000 devedores

            comboTipoConta.Items.Add("Conta Corrente");
            comboTipoConta.Items.Add("Conta Poupança");

            //Adiciona o proximo numero de conta automaticamente na tela de cadastro
            var proxima = Conta.ProximaConta();
            textoNumero.Text = Convert.ToString(proxima);

           


        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            int indice = comboTipoConta.SelectedIndex;

            string titular = textoTitular.Text;
            bool ehDevedor = false;

          
            for (int i = 0; i < 3000; i++)
            {
                ehDevedor = this.devedores.Contains(titular);//Vai percorrer a lista devedores para ver se ja não contem o devedor
            }

            if (!ehDevedor)
            {

            

            try
            {

                



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
                //Mostra a proxima numeração de conta ao cadastrar cliente
                var proxima = Conta.ProximaConta();
                textoNumero.Text = Convert.ToString(proxima);
                textoTitular.Text = "";


            }
            catch (Exception)
            {
                MessageBox.Show("Cadastro não realizado!!");
                throw;
            }
            }
            else
            {
                MessageBox.Show("devedor");
            }

        }

    }
}
