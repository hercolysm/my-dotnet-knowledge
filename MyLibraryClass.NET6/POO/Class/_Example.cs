using MyLibraryClass.NET6.Models;

namespace MyLibraryClass.NET6.POO.Class
{
    public class _Example
    {
        public void ExampleInstanceClass()
        {
            // Instance a class
            Pessoa p1 = new Pessoa();
            p1.Nome = "Maria";
            p1.SobreNome = "Aguiar";
            p1.Idade = 29;
            p1.Peso = 52.6M;
            p1.DataNascimento = DateTime.Now;
            p1.Apresentar();
            p1.CalcularIMC(52.6M, 1.72);

            // Instance a class with builder
            var p2 = new Pessoa("Lucas", 24);

            // Instance a class with builder with value name
            var p3 = new Pessoa(nome: "Mateus", idade: 5);

            // Instance a class with object initiator
            var p4 = new Pessoa { Nome = "João", Idade = 30 };

            // Instance class without namespace 
            MyLibraryClass.NET6.Models.Pessoa p5 = new MyLibraryClass.NET6.Models.Pessoa();

            // Other forms instance class
            Pessoa p6 = new();
            var p7 = new Pessoa();
        }

        public void ExampleStaticCall()
        {
            // Call to a static property
            Console.WriteLine(Pessoa.NomeDaClasse);

            // Call to a static method
            Console.WriteLine(Pessoa.ExibirNomeDaClasse());
        }
    }
}