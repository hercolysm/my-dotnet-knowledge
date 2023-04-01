namespace MyLibraryClass.NET6.Models
{
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>
    public class Pessoa
    {
        private string? _nome;
        public string? SobreNome { get; set; }
        public string? NomeCompleto => $"{Nome} {SobreNome}".ToUpper();
        public int Idade { get; set; }
        public decimal Peso { get; set; }
        public double Altura { get; set; } 
        public DateTime DataNascimento { get; set; }
        public List<Pessoa>? Filhos { get; set; }
        static public string NomeDaClasse = "Pessoa";
        public decimal? PodeSerNulo { get; set; }

        public string Nome { 
            get => _nome.ToUpper(); 
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        } 

        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public void Deconstruct(out string nome, out int idade)
        {
            nome = this.Nome;
            idade = this.Idade;
        }

        /// <summary>
        /// Faz a pessoa se apresentar, dizendo o seu nome e a idade
        /// </summary>
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e eu tenho {Idade} anos");
        }

        /// <summary>
        /// Realiza o cálculo do IMC
        /// </summary>
        /// <param name="peso">Peso da pessoa para a realização do cálculo</param>
        /// <param name="altura">Altura da pessoa para a realização do cálculo</param>
        /// <returns>Retorna o valor de IMC da pessoa</returns>
        public double CalcularIMC(decimal peso, double altura)
        {
            var IMC = Convert.ToDouble(peso) * altura;
            return IMC;
        }

        static public string ExibirNomeDaClasse()
        {
            return NomeDaClasse;
        }
    }
}
