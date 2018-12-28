using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class EditorDeTexto : Form
    {
        private string caminhoDiretorio = "C:\\Users\\leona\\OneDrive\\Controles Pessoais\\Desenvolvimento\\linguagens de programação\\c#\\";
        public EditorDeTexto()
        {
            InitializeComponent();
        }

        private void EditorDeTexto_Load(object sender, EventArgs e)
        {

            if (File.Exists(caminhoDiretorio + "texto.txt"))
            {
                using (Stream entrada = File.Open(caminhoDiretorio + "texto.txt", FileMode.Open))//Usando Using para abrir e fechar arquivo
                {
                    StreamReader leitor = new StreamReader(entrada);
                    string linha = leitor.ReadLine();

                    while (linha != null)
                    {
                        textoConteudo.Text += linha;
                        linha = leitor.ReadLine();
                    }
                }
                
               
                //leitor.Close();
                //entrada.Close();
            }

        }

        private void botaoGrava_Click(object sender, EventArgs e)
        {
            //string pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string caminhoArquivos = Path.Combine(pastaDocumentos,"texto.txt");
            //MessageBox.Show(caminhoArquivos);

            using (Stream saida = File.Open(caminhoDiretorio + "texto.txt", FileMode.Create))
            {
                StreamWriter escritor = new StreamWriter(saida);
                escritor.Write(textoConteudo.Text);
            }



            //escritor.Close();
            //saida.Close();
        }
    }
}
