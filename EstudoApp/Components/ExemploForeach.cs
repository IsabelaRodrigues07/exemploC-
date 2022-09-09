namespace EstudoApp.Components
{
    public class ExemploForeach
    {
        public static void ExForeach()
        {
            //primeiro faz o array
            string[] cores = { "Azul", "Amarelo", "Vermelho" };
            //foreach(onde vai armazenar cada elemento "in" array a ser analisado
            foreach (string cadaCor in cores)
            //agora vem o que vai ser feito com cada elemento
            {
                Console.WriteLine(cadaCor);

            }

        }
    }
}
