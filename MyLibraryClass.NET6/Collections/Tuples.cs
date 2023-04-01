namespace MyLibraryClass.NET6.Collections
{
    public class Tuples
    {
        public void Examples()
        {
            // (Recommended)
            (bool Success, string Message, int Count) tupla1 = (true, "Sucesso!", 1); 
            Console.WriteLine(tupla1.Success); 
            Console.WriteLine(tupla1.Message); 
            Console.WriteLine(tupla1.Count); 

            (bool, string, int) tupla2 = (true, "Sucesso!", 1); 
            Console.WriteLine(tupla2.Item1); 
            Console.WriteLine(tupla2.Item2); 
            Console.WriteLine(tupla2.Item3); 

            ValueTuple<bool, string, int> tupla3 = (false, "Erro", 0); 
            Console.WriteLine(tupla3.Item1); 
            Console.WriteLine(tupla3.Item2); 
            Console.WriteLine(tupla3.Item3); 

            var tupla4 = Tuple.Create(false, "Texto", 123); 
            Console.WriteLine(tupla4.Item1); 
            Console.WriteLine(tupla4.Item2); 
            Console.WriteLine(tupla4.Item3); 
        }

        private (bool Success, List<object> ListObj, string Message) GetTuple()
        {
            return (true, new List<object> {}, "OK");
        }


        public void ReturnTupleInMethod()
        {
            // Return tuple in a method
            var (Success, ListObj, Message) = this.GetTuple();
            Console.WriteLine(Success); 
            Console.WriteLine(ListObj); 
            Console.WriteLine(Message); 

            // Descart not used values
            var (Success2, _, _) = this.GetTuple();
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public void Deconstruct(out string name, out int age)
        {
            name = this.Name;
            age = this.Age;
        }

        public void ReturnTupleInDeconstructMethod()
        {
            Tuples Obj = new Tuples() { Name = "John", Age = 10 };
            (string name, int age) = Obj;
            Console.WriteLine(name); 
            Console.WriteLine(age); 
        }
    }
}