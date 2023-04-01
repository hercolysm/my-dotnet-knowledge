namespace MyLibraryClass.NET6.Models
{
    public class GenericClass<T>
    {
        private T[] array = new T[5];

        public void Adicionar(T variavel)
        {

        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public void Example()
        {
            GenericClass<object> arrayObject = new();
            arrayObject.Adicionar(new object {});

            GenericClass<string> arrayString = new();
            arrayString.Adicionar("string");

            GenericClass<int> arrayInt = new();
            arrayInt.Adicionar(123);
        }
    }
}