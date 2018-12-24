using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;
namespace Banco
{
    public class ContaPoupanca: Conta
    {

        //public override bool Saca(double valor)//Override sobrescreve uma função existente, alterando pequenas coisas
        //{
        //    if (this.Saldo >= valor && this.Tipo == 1)
        //    {
        //        this.Saldo -= (valor + 0.10);
        //        return true;
        //    }
        //  return false;


        //}


        //public  bool Saca(double valor)
        //{
        //    return base.Saca(valor+0.10);
        //}
        public override void Saca(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();//Argumento que trata valor negativo
            }

            if (valor>this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor + 0.10;
            }

        }

        public override void Deposita(double valor)
        {

            if (valor<0.0)
            {
                throw new ArgumentException();
            }

            this.Saldo += (valor + 0.10);

        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;

        }

        

    }
    }
