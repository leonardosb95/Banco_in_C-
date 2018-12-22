using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class Conta
    {
        public int Numero { get; /*protected*/ set; }
        public double Saldo { get;protected set; }//Protected-Somente os atributos e metodos das classses podem alterar/herdeiras tambem
        public int Tipo { get; protected set; }
        private  static int numeroDeContas = 0;//Esse atributo pertece a classe conta e não objeto conta corrente

        public Conta()
        {
            Conta.numeroDeContas++;//Utilizando o Static para contar o numero total de contas 
            this.Numero = numeroDeContas;
        }
            
        public  static int ProximaConta()
        {
            return Conta.numeroDeContas + 1;//Conta a proximo numero para cadastramento da conta
        }


        //public int Numero {
        //    set {
        //    this.numero = value;
        //        }
        //                  }

        public Cliente Titular { get; set; }//Encapsulamento


        //public abstract bool Saca(double valor)//Virtual permite que o metodo seja sobrescrito
        //{

        //    if (this.Saldo>=valor)
        //    {

        //        this.Saldo -= valor+0.10;
        //    }
        //        return false;//Quando executa um return, ele imediatamente devolve o valor e sai do metodo
        //}


        //public abstract void Deposita(double valor)
        //{
        //        this.Saldo += valor;

        //}

         

            //CLASSES ABSTRATAS

        public abstract bool Saca(double valor);

        public abstract void Deposita(double valor);
      


        public void Transfere(double valor,Conta destino)
        {
            if (this.Saldo>0 && this.Titular.Nome!=destino.Titular.Nome)
            {
                this.Saldo -= valor;
                destino.Deposita(valor);
                System.Windows.Forms.MessageBox.Show("Transferência concluída com sucesso!!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Transferência não concluída!!");
            }

        }

        
    }
}
