using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco
{
    public class ContaCorrente: Conta, ITributavel
    {
      
        //public override bool Saca(double valor)
        //{
        //    return base.Saca(valor+0.05);
        //}
        public override void Saca(double valor)
        {
            if (valor<0.0)
            {
                throw new ArgumentException();
            }

            if (valor> this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor;
            }
            
        }
        //public override void Deposita(double valor)
        //{
        //    base.Deposita(valor+0.10);
        //}

        public override void Deposita(double valor)
        {

            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Saldo += valor;
            }
            

        }

        public double CalculaTributos()
        {
            var imposto=((this.Saldo * 5) / 100);
            this.Saldo -= imposto;
            return imposto;
        }

    }
}
