using System.Globalization;

namespace MyLibraryClass.NET6.Classes
{
    public class CultureInfoClass
    {
        public void ChangeCultureInfoGlobal()
        {
            decimal valorMonetario = 1234.56M;

            // Change culture info at run time (global context -- all program)

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.WriteLine($"{valorMonetario:C}"); // $1,234.56 

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
            Console.WriteLine($"{valorMonetario:C}"); // R$ 1.234,56
        }

        public void ChangeCultureInfoLocal()
        {
            decimal valorMonetario = 1234.56M;

            // Change culture info at run time (just in method call)

            Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // $1,234.56 
            Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); // R$ 1.241,50
        }

        public void TryParseDateTime()
        {
            bool success = DateTime.TryParseExact(
                "01/03/2023 21:44:59", 
                "dd/MM/yyyy HH:mm:ss",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, 
                out DateTime dataRetornada
            ); 

            if (success) 
            {
                Console.WriteLine(dataRetornada); // 01/03/2023 21:44:59
            }
            else 
            {
                Console.WriteLine(dataRetornada); // 01/01/0001 00:00:00
            }
        }

        public void ConvertDateTimeToString()
        {
            DateTime data = DateTime.Now; 
            
            Console.WriteLine(data.ToShortDateString()); // 3/23/2023 en-US | 28/03/2023 pt-BR
            Console.WriteLine(data.ToShortTimeString()); // 9:41 PM   en-US | 17:31      pt-BR   
        }

        public void ConvertToMoneyFormat()
        {
            decimal valorMonetario = 1241.50M;

            Console.WriteLine(valorMonetario); // 1241.50 us-EN | 1241,50 pt-BR 

            Console.WriteLine($"{valorMonetario:C}");         // $1,241.50  us-EN | R$ 1.241,50  pt-BR
            Console.WriteLine(valorMonetario.ToString("C"));  // $1,241.50  us-EN | R$ 1.241,50  pt-BR
            Console.WriteLine(valorMonetario.ToString("C1")); // $1,241.5   us-EN | R$ 1.241,5   pt-BR
            Console.WriteLine(valorMonetario.ToString("C2")); // $1,241.50  us-EN | R$ 1.241,50  pt-BR
            Console.WriteLine(valorMonetario.ToString("C3")); // $1,241.500 us-EN | R$ 1.241,500 pt-BR

            Console.WriteLine($"{valorMonetario:N}");         // 1,241.500 us-EN | 1.241,50  pt-BR
            Console.WriteLine(valorMonetario.ToString("N"));  // 1,241.500 us-EN | 1.241,50  pt-BR
            Console.WriteLine(valorMonetario.ToString("N1")); // 1,241.5   us-EN | 1.241,5   pt-BR
            Console.WriteLine(valorMonetario.ToString("N2")); // 1,241.50  us-EN | 1.241,50  pt-BR
            Console.WriteLine(valorMonetario.ToString("N3")); // 1,241.500 us-EN | 1.241,500 pt-BR
        }

        public void ConvertToPercentage()
        {
            double porcentagem = .3421;
            Console.WriteLine($"{porcentagem:P}");         // 34.210% us-EN | 34,21%  pt-BR
            Console.WriteLine(porcentagem.ToString("P"));  // 34.210% us-EN | 34,21%  pt-BR
            Console.WriteLine(porcentagem.ToString("P1")); // 34.2%   us-EN | 34,2%   pt-BR
            Console.WriteLine(porcentagem.ToString("P2")); // 34.21%  us-EN | 34,21%  pt-BR
            Console.WriteLine(porcentagem.ToString("P3")); // 34.210% us-EN | 34,210% pt-BR
        }
    }
}