using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente: Conta
    {
      
        //public override bool Saca(double valor)
        //{
        //    return base.Saca(valor+0.05);
        //}
        public override bool Saca(double valor)
        {
            if (this.Saldo >= valor)
            {

                this.Saldo -= valor + 0.11;
            }
            return false;//Quando executa um return, ele imediatamente devolve o valor e sai do metodo
        }
        //public override void Deposita(double valor)
        //{
        //    base.Deposita(valor+0.10);
        //}

        public override void Deposita(double valor)
        {
            this.Saldo += (valor + 0.11);

        }

    }
}
