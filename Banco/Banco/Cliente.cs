using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cliente
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        //Construtor, metodo padrão que iniciliza e precisa ser atribuido valor nele 
        public Cliente(string nome)
        {

            this.Nome = nome;

        }




        public bool EhMaiorDeIdade(int idade)
        {
            if (idade>=18)
            {
                return true;
            }

            return false;
        }

    }
}
