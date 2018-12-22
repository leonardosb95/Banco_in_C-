using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class TotalizadorDeContas
    {
        public double ValorTotal { get; private set; }
        public double Total { get; private set; }

        //public void Soma(Conta conta)
        //{
        //    ValorTotal += conta.Saldo;
        //}

        ////Soma o valor do tributo de conta Poupança e Conta corrente
        //public void Acumula(ContaPoupanca cp)
        //{

        //    ValorTotal += cp.CalculaTributo();
        //}

        //public void Acumula(ContaInvestimento ci)
        //{
        //    ValorTotal += ci.CalculaTributo();
        //}

        public void Acumula(ITributavel t)
        {
            Total += t.CalculaTributos();
        }
    }
}
