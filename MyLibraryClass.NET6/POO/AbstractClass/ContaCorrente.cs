namespace MyLibraryClass.NET6.Models
{
    public class ContaCorrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            if (valor <= Saldo) {
                Saldo -= valor;
                Console.WriteLine($"Creditando o valor de {valor} do seu saldo");
                ExibirSaldo();
            }
            else 
            {
                Console.WriteLine($"O valor de {valor} ultrapassa o valor do seu saldo atual");
                ExibirSaldo();
            }
        }

        public override void Debitar(decimal valor)
        {
            if (valor > 0) 
            {
                Saldo += valor;
                Console.WriteLine($"Debitando o valor de {valor} no seu saldo");
                ExibirSaldo();
            }
            else 
            {
                Console.WriteLine($"O valor de {valor} não pode ser negativo");
                ExibirSaldo();
            }
        }
    }
}