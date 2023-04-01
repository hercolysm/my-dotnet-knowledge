namespace MyLibraryClass.NET6.Classes
{
    public class ExceptionClass
    {
        public void ImplementMultipleExceptions()
        {
            string filePath = "filePath";

            try
            {
                string[] linhas = File.ReadAllLines(filePath);

                foreach(string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho não encontrado. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Fim do try/catch");
            }
        }
    
        public void ImplementSimpleException()
        {
            try
            {
                ExceptionClass Obj = new();
                Obj.Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.WriteLine($"{ex.StackTrace}");
            }
            Console.WriteLine("123...");
        }

        public void Method1()
        {
            Console.WriteLine("Method1");
            Method2();
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
            Method3();
        }

        public void Method3()
        {
            Console.WriteLine("Method3");
            throw new Exception("Exceção do Method3");
        }
    }
}