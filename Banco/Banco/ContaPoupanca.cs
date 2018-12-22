using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public override bool Saca(double valor)
        {

            if (this.Saldo >= valor)
            {

                this.Saldo -= valor + 0.10;
            }
            return false;//Quando executa um return, ele imediatamente devolve o valor e sai do metodo
        }

        public override void Deposita(double valor)
        {
            this.Saldo += (valor + 0.10);

        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;

        }

        

    }
    }
