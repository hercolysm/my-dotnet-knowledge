namespace MyLibraryClass.NET6.Classes
{
    public class ConsoleClass
    {
        public void ReadLine()
        {
            Console.WriteLine("Digite um valor:");
            var ValorDigitado = Console.ReadLine();
            Console.WriteLine($"Valor digitado: '{ValorDigitado}'");
        }
    }
}