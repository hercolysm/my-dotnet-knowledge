namespace MyLibraryClass.NET6.Classes
{
    public class FileClass
    {
        public void CreateAndWriteFile()
        {
            var FileName = "teste.txt";
            var FileContent = "Line 1\nLine 2\nLine 3";
            File.WriteAllText(FileName, FileContent);
        }

        public void ReadFile()
        {
            string filePath = "FilePath";

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
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. {ex.Message}");
            }
        }
    }
}