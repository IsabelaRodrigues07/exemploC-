namespace EstudoApp.Components
{
    public class ExemploVariavelELogicos
    {
        //VARIÁVEIS e operadores logicos
        public static void ExVariaveleLogicos()
        {
            //declara as variais de tipos diferentes
            string nome = "Isabela";
            string sobrenome = "Rodrigues";
            bool logado = true;
            //variavel concatenando com as anteriores
            string pessoa = nome + sobrenome + logado;
            {
                //mostrar no console o resultado
                Console.WriteLine("olá " + nome + " " + sobrenome);
                //booleano de login, está true entao vai ser realizado com sucesso
                Console.WriteLine(logado ? "Login realizado com sucesso" : "Não foi possivel logar");
            }
        }
    }
}
