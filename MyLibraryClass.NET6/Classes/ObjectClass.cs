using MyLibraryClass.NET6.Models;

namespace MyLibraryClass.NET6.Classes
{
    public class ObjectClass
    {
        // classe object 
        // toda classe herda da classe object 
        
        // Métodos 
        // Equals(Obj) = compara se o obj especificado é igual ao obj atual 
        // Equals(Obj, Obj) = compara se a instancia dos objs são iguais 
        // Finalize() = tenta liberar recursos e executar operações de limpeza antes do gabage coletor 
        // GetHashCode() = retorna um hash do obj 
        // GetType() = retorno o tipo  da instancia atual 
        // MemberwiseClone = Cria uma copia do obj atual 
        // ReferenceEquals(obj, obj) = Verifica se as instancias são as mesmas 
        // ToString() = Retorna o obj em formato de string 
        
        public void LogPessoa(Pessoa pessoa)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
        }

        public void LogObject(object obj)
        {
            var type = obj.GetType();

            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
            }
        }
    }
}