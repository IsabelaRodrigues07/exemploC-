namespace EstudoApp.Components
{
    public class ExemploFor
    { 
        public static void ExFor() 
        { 
            //for divide em 3 partes: a primeira variável é o inicio do loop, a segunda é a condição, até quando ele vai fazer o loop
            //e a terceira é a ação ao final de cada iteração, no caso somar mais 1 
            for (int contagem3 = 2; contagem3 < 10; contagem3++)
            { 
                //é exibido no console o resultado 
                Console.WriteLine(contagem3);
            }
        }
    }
}
