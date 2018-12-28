using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Busca
{
    public class GeradorDeDevedores
    {
        

        public ICollection<string> GeralList()
        {
            HashSet<string> nomes = new HashSet<string>();

            for (int i = 0; i < 3000; i++)
            {
               nomes.Add("Devedor "+ i);
            }

            return nomes;
        }



    }
}
