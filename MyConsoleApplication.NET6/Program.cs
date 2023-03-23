using MyLibraryClass.NET6.Models;
using System.Text;

// Instânciar uma classe.
Pessoa p1 = new Pessoa();
p1.Nome = "Maria";
p1.SobreNome = "Aguiar";
p1.Idade = 29;
p1.Peso = 52.6M;
p1.DataNascimento = DateTime.Now;
p1.Apresentar();
p1.CalcularIMC(52.6M, 1.72);

// Instânciar uma classe com iniciador de objeto.
var p5 = new Pessoa { Nome = "João", Idade = 30 };
p5.Apresentar();

// Instânciar uma classe com construtor.
var p6 = new Pessoa("Lucas", 24);
p6.Apresentar();

// Instânciar uma classe com construtor passando o nome da variável.
var p7 = new Pessoa(nome: "Mateus", idade: 5);
p7.Apresentar();

// Outras formas de instânciar uma classe.
MyLibraryClass.NET6.Models.Pessoa p2 = new MyLibraryClass.NET6.Models.Pessoa();
var p3 = new Pessoa();
Pessoa p4 = new();

// Chamar a uma propriade estática 
Console.WriteLine(Pessoa.NomeDaClasse);

// Chamar a um método estático 
Console.WriteLine(Pessoa.ExibirNomeDaClasse());

/* Tipos de dados */
string String = "Texto";
decimal Decimal = 1.99M;
double Double = 1.99;
float Float = 1.99F;
bool Bool = true || false;
short Short = 9999;
int Int = 999999999;
long Long = 999999999999999999; 
DateTime Datetime = new DateTime();

/* Tipos não definidos */
var Var = 1.5;
dynamic Dynamics = "Algum valor";

string nome, sobrenome = "";
int idade, contador = 0;

/* DateTime */
Console.WriteLine(DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"));

/* String */
string texto1 = "Texto 1";
string texto2 = "Texto 2";
Console.WriteLine(texto1 + " - " + texto2);

// Interpolação de cadeia de caracteres. (Recomendado)
Console.WriteLine($"{texto1} - {texto2}");

//using System.Text;
var phrase = "01";
var manyPhrases = new StringBuilder();
for (var i = 0; i < 100; i++) 
{
    manyPhrases.Append(phrase);
}
Console.WriteLine(manyPhrases);

/* Operadores de atribuição */
int number = 1;
Console.WriteLine(number); // 1
Console.WriteLine(number++); // 1
Console.WriteLine(++number); // 3
Console.WriteLine(number--); // 3
Console.WriteLine(--number); // 1
Console.WriteLine(number += 1); // 1+1=2
Console.WriteLine(number =+ 1); // =1

number = int.Parse("2"); // 2

number = Convert.ToInt32("3"); // 3

number = Convert.ToInt32(null); // 0

try 
{
    number = int.Parse(null); // erro
    number = Convert.ToInt32("texto"); // erro
}
catch (Exception e) {
    Console.WriteLine("erro");
}

int.TryParse(null, out int newInt); // 0

int.TryParse("6", out newInt); // 6

// Cast To String 
string string1 = 1.ToString();
string string2 = 2.5M.ToString();

// Cast Implícito (int => double)
int a = 1;
double b = a;

// Cast Implícito (int => long)
int int1 = int.MaxValue;
long long1 = int1;

// Ordem dos operadores 
/*
    1° ()
    2° expoente
    3° / e *  
    4º + e - 
*/
double c = 4 / 2 + 2; // 4

double d = 4 / (2 + 2); // 1

/* Operadores Condicionais */
if (false) 
{

}
else if (true) 
{

}
else 
{

}

Console.WriteLine("Digite um valor. Ex: 'a', 'b' ou 'c'");
string opcao = Console.ReadLine();

switch (opcao)
{
    case "a":
        Console.WriteLine("Valor digitado 'a'");
        break;
    
    case "b":
    case "c":
        Console.WriteLine("Valor digitado 'b' ou 'c'");
        break;

    default:
        Console.WriteLine("Não digitado 'a', 'b' e 'c'");
        break;
}

/* Operadores Lógicos */

// AND
if (true & true) {}
if (true && true) {} // recomendado

// OR
if (true | true) {}
if (true || true) {} // recomendado

// NOT 
if (!true) {}

// EQUAL
if (true == true) {} 

// DIFERENTE
if (true != true) {}

// Operadores Aritméticos 
int soma = 2 + 1; // 3
int subtracao = 2 - 1; // 1
int multiplicacao = 2 * 1; // 2
int divisao = 2 / 1; // 2
int modulo = 2 % 1; // 0

// Math
double potencia = Math.Pow(2, 2); // 4
double raizQuadrada = Math.Sqrt(4); // 2

// Estruturas de Repetição 
for (var i = 0; i < 10; i++) 
{
    Console.WriteLine(i);
}

int cont = 0;
while (cont < 10)
{
    Console.WriteLine(cont++);
}

int cont2 = 0;
do
{
    Console.WriteLine(cont2++);
} while (cont2 < 10);

int[] numbers = {0,1,2,3,4,5,6,7,8,9};
foreach (int numberX in numbers) 
{
    Console.WriteLine(numberX);
}

// Array (tamanho fixo)
int[] array1 = new int[4];
array1[0] = 1;
array1[1] = 2;
array1[2] = 3;
array1[3] = 4;

int[] array2 = new int[] { 1, 2, 3, 4 };
int[] arrayX = { 1, 2, 3, 4 };
var arrayY = new int[] { 1, 2, 3, 4 };

string[] diasDaSemana = {"Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo"};
string segunda = diasDaSemana[0];

for (var i = 0; i < diasDaSemana.Length; i++) 
{
    Console.WriteLine(diasDaSemana[i]);
}

foreach (string dia in diasDaSemana) 
{
    Console.WriteLine(dia);
}

double[] array3 = new double[1];
array3[0] = 1.0;
Array.Resize(ref array3, 2);
array3[1] = 2.0;

decimal[] array4 = new decimal[1];
array4[0] = 1.0M;
decimal[] array5 = new decimal[2];
Array.Copy(array4, array5, array4.Length);
Console.WriteLine(array5[0]);
Console.WriteLine(array5[1]);

// Listas 
List<string> idiomas = new List<string>();
idiomas.Add("pt-BR");
idiomas.Add("en-US");

for (var i = 0; i < idiomas.Count; i++) 
{
    Console.WriteLine(idiomas[i]);
}

foreach (string idioma in idiomas) 
{
    Console.WriteLine(idioma);
}

try 
{

}
catch (Exception e) 
{

}
finally 
{

}

/*using (Pessoa p3 = new Pessoa()) 
{
    p3.Apresentar();
}*/
/*using Pessoa p3 = new Pessoa();
p3.Apresentar();*/
