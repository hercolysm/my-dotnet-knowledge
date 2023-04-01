namespace MyLibraryClass.NET6.Classes
{
    public class StringClass
    {
        public void ConcatString()
        {
            string texto1 = "Texto 1";
            string texto2 = "Texto 2";
            Console.WriteLine(texto1 + " - " + texto2);
        }

        public void InterpolateString() 
        {
            string texto1 = "Texto 1";
            string texto2 = "Texto 2";
            Console.WriteLine($"{texto1} - {texto2}");
        }

        public void ConvertToStringWithMask()
        {
            int numero = 123456;
            Console.WriteLine(numero.ToString("##-##-##")); // 12-34-56
        }
    }
}