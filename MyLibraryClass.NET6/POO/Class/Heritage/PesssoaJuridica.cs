namespace MyLibraryClass.NET6.Models
{
    /* Nenhuma classe poderá herdar dessa classe 
        por que ela é 'sealed'
    */
    public sealed class PesssoaJuridica : Pessoa
    {
        public string? Cnpj { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e meu CNPJ é {Cnpj}");
        }
    }
}