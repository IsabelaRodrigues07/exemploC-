using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoApp.Components
{
    public static class ExemploDoWhile
    {
        public static void ExDoWhile()
        {
            //declara a variável do primeiro numero da contagem
            int contagem2 = 1;
            //do vai executar o bloco de codigo inserido após
            do
            {
                //mostra no console a contagem
                Console.WriteLine(contagem2);
                //soma 1 a cada numero
                contagem2++;
                //somente agora vem a condição do while, se for verdadeira então executa tudo novamente, até que nao seja(do garante que o codigo seja executado pelo menos uma vez)
            } while (contagem2 <= 50);
        }
    }
}
