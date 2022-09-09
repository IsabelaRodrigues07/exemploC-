namespace EstudoApp.Models.ExemploCarroModel

{
    public class Carro
    {
        //adiciona os atributos dela
        public string Modelo { get; set; }
        public int Ano { get; set; }
        //esse passo foi criado automaticamente, serve para instanciar os obj
        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
        }
    }
}
