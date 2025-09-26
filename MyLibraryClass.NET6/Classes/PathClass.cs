namespace MyLibraryClass.NET6.Classes
{
    public class PathClass
    {
        public string GetPathJsonFile()
        {
            var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); 
            var solutionDirectory = Path.GetFullPath(assemblyPath + "./../../../");
            var fileName = "appsettings.local.json";
            var pathJsonFile = Path.GetFullPath($"{solutionDirectory}/Fleury.CRM.Teste/{fileName}");
            return pathJsonFile;
        }
    }
}