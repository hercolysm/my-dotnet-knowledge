namespace MyLibraryClass.NET6.Interfaces
{
    public interface ICalculadora
    {
        /* implementação obrigatoria 
            pois metodos não tem corpo
         */
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2);

        /* implementação opcional 
            pois metodos tem corpo
         */
        int SomarString(string num1, string num2)
        {
            return Somar(int.Parse(num1), int.Parse(num2));
        }
    }
}