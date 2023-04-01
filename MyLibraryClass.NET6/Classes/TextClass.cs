using System.Text;

namespace MyLibraryClass.NET6.Classes
{
    public class TextClass
    {
        public void Concat()
        {
            var phrase = "";
            var manyPhrases = new StringBuilder();
            for (var i = 0; i < 100; i++) 
            {
                manyPhrases.Append(phrase);
            }
            Console.WriteLine(manyPhrases);
        }
    }
}