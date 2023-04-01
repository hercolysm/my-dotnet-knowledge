using MyLibraryClass.NET6.Models;

namespace MyLibraryClass.NET6.Interfaces
{
    public class _Example
    {
        public void Examples()
        {
            // Interface não pode ser instanciada
            // ICalculadora iCalc = new ICalculadora(); // ERRO

            // Instânciar classe que implementa a interface 'ICalculadora'
            Calculadora calc = new Calculadora();
            // A instância possui apenas os métodos implementados pela classe 'Calculadora'
            Console.WriteLine(calc.Somar(1, 1));
            // Console.WriteLine(calc.SomarString("1", "1")); // ERRO

            // Instânciar classe em uma variável do tipo interface 'ICalculadora'
            ICalculadora iCalc = new Calculadora();
            // A instância possui todos os métodos da interface 
            // (métodos implementados pela interface + métodos implementados pela classe)
            Console.WriteLine(iCalc.Somar(1, 1));
            Console.WriteLine(iCalc.SomarString("1", "1"));
        }
    }
}
