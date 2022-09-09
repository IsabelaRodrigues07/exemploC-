using EstudoApp.Components;
using EstudoApp.Models.ExemploCarroModel;
using EstudoApp.Models.ExemploListaModel;

namespace HelloWorld
{
    class Program
    {

        public static void Main(string[] args)
        {

            //instanciando o objeto da classe exemplo F
            Carro carro1 = new Carro("Onix", 2018);

            //inicia o switch com a variavel das opcoes
            char opcao;

            //serve para orientar a pessoa sobre qual funcao escolher
            Console.WriteLine("Informe o letra da sua opção:");
            Console.WriteLine("a = exemplo While || b = DoWhile || c = For || d = Foreach || e = Variavel e logicos || f = Classes || g = Lista");
            //ler a opcao escolhida no console
            opcao=char.Parse(Console.ReadLine());
            //estrutura switch
            switch (opcao)
            {
                case 'a':
                    ExemploWhile.ExWhile();
                    break;
                case 'b':
                    ExemploDoWhile.ExDoWhile();
                    break;
                case 'c':
                    ExemploFor.ExFor();
                    break;
                case 'd':
                    ExemploForeach.ExForeach();
                    break;
                case 'e':
                    ExemploVariavelELogicos.ExVariaveleLogicos();
                    break;
                case 'f':
                    Console.WriteLine(carro1.Modelo);
                    Console.WriteLine(carro1.Ano);
                    break;
                case 'g':
                    //escrever qual o tipo da lista e add um construtor pra por os elementos
                    List<ModelCurso> listaDeCursos = new List<ModelCurso>();
                    //instanciando novos objetos(cursos)
                    ModelCurso curso1 = new ModelCurso();
                    ModelCurso curso2 = new ModelCurso();
                    curso1.Nome = "Administração";
                    curso1.Semestres = 8;
                    curso2.Nome = "Sistemas";
                    curso2.Semestres = 10;
                    //adicionando os objetos na lista
                    listaDeCursos.Add(curso1);
                    listaDeCursos.Add(curso2);
                    //Count para saber quantos elementos tem a lista
                    Console.WriteLine(listaDeCursos.Count);
                    //foreach para percorrer os elementos e mostrar no console
                    //variavel curso foi "tipada" através de ClassCurso
                    foreach (ModelCurso curso in listaDeCursos)
                    {
                        Console.WriteLine(curso.Nome);
                        Console.WriteLine(curso.Semestres);
                        
                    }
                    break;
                default: Console.WriteLine("nenhuma opcao valida foi selecionada");
                    break;
               
            }

        }
        
    }
}














