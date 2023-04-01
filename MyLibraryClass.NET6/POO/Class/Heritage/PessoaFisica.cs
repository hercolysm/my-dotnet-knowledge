namespace MyLibraryClass.NET6.Models
{
    public class PessoaFisica : Pessoa
    {
        public string? Cpf { get; set; }

        public PessoaFisica()
        {

        }

        public PessoaFisica(string nome, int idade) : base(nome, idade)
        {

        }

        /* Nenhuma filha dessa classe poderá sobreescrever esse metodo 
            por que ele é 'sealed'
        */
        public sealed override void Apresentar()
        {
            base.Apresentar();
        }
    }
}