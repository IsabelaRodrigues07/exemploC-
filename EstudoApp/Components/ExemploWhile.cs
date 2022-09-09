namespace EstudoApp.Components
{
    public class ExemploWhile
    {
        public static void ExWhile()
        {
            //primeiro instancia a variável e o  tipo dela
            int contagem1 = 1;
            //coloca o while e entre parênteses a condição dele, no caso tem que ser um numero menor ou igual a 15
            while (contagem1 <= 15)
            {
                //chama a variável contagem através do console
                Console.WriteLine(contagem1);
                //tem que adicionar mais 1 elemento com o (++) pq se não ele iria ficar repetindo o mesmo valor
                contagem1++;
            }
        }
    }
}
