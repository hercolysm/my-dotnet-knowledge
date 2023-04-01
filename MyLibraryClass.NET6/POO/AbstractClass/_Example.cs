using MyLibraryClass.NET6.Models;

namespace MyLibraryClass.NET6.POO.AbstractClass
{
    public class _Example
    {
        public void Example()
        {
            ContaCorrente ContaConrrente1 = new ContaCorrente();
            ContaConrrente1.Debitar(900);
            ContaConrrente1.Creditar(500);
            ContaConrrente1.Creditar(500);
        }
    }
}
