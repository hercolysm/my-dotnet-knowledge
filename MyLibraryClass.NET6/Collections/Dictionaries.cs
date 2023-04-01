namespace MyLibraryClass.NET6.Collections
{
    public class Dictionaries
    {
        public void Examples()
        {
            // Dictionary<Chave,Valor>
            Dictionary<string, string> dictionary = new();

            dictionary.Add("CE", "Ceará");

            dictionary["SP"] = "SÃO PAULO";

            dictionary.Remove("CE");

            if (dictionary.ContainsKey("SP")) {
                Console.WriteLine($"SP exists: {dictionary["SP"]}");
            }
            else 
            {
                Console.WriteLine("SP doesn't exist, add...");
                dictionary.Add("SP", "São Paulo");
            }

            foreach(var item in dictionary)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}