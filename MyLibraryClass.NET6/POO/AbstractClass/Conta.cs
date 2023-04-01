namespace MyLibraryClass.NET6.Models
{
    public abstract class Conta
    {
        protected decimal Saldo { get; set; }

        public abstract void Creditar(decimal valor);

        public abstract void Debitar(decimal valor);

        protected void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {Saldo}");
        }
    }
}