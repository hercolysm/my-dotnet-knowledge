namespace MyLibraryClass.NET6.Models
{
    public static class ExtensionMethods
    {
        public static void Example()
        {
            int Inteiro = 1;
            Console.WriteLine(Inteiro.EhPar());

            string String = "";
            Console.WriteLine(String.EhVazia());
        }

        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }

        public static bool EhVazia(this string numero)
        {
            return numero == "";
        }
    }
}