namespace MyLibraryClass.NET6.Classes
{
    public class DateTimeClass
    {
        public void ConvertStringToDateTime()
        {
            try
            {
                DateTime dateTime = DateTime.Parse("30/03/2023 21:44:59"); 
                Console.WriteLine(dateTime); // 30/03/2023 21:44:59
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao converter para datetime");
            }
        }

        public void TryConvertStringToDateTime()
        {
            bool success = DateTime.TryParse("30/03/2023 21:44:59", out DateTime dataRetornada); 

            if (success)
            {
                Console.WriteLine(dataRetornada); // 30/03/2023 21:44:59
            }
            else
            {
                Console.WriteLine(dataRetornada); // 01/01/0001 00:00:00
            }
        }

        public void ConvertToDateTimeToString()
        {
            DateTime data = DateTime.Now;
            Console.WriteLine(data.ToString("dd/MM/yyyy")); // 23/03/2023
            Console.WriteLine(data.ToString("HH:mm:ss")); // 21:41:11
        }

        public void AddDate()
        {
            DateTime.Now.AddDays(1);
        }

        public object GetCurrentDateTime()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return obj;
        }
    }
}