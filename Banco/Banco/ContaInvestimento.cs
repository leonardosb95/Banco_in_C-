using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaInvestimento: Conta
    {



        public double CalculaTributo()
        {
            return this.Saldo * 0.03;

        }

        public override bool Saca(double valor)
        {

            if (this.Saldo >= valor)
            {

                this.Saldo -= valor;
            }
            return false;//Quando executa um return, ele imediatamente devolve o valor e sai do metodo
        }

        public override void Deposita(double valor)
        {
            this.Saldo += valor;

        }



    }
}
