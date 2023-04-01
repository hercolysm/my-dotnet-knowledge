namespace MyLibraryClass.NET6.Collections
{
    public class Lists
    {
        public void Examples()
        {
            List<string> languages = new List<string>();
            
            languages.Add("pt-BR");
            languages.Add("en-US");
            
            languages.Remove("pt-BR");
            languages.Remove("en-US");

            if (languages.Contains("en-US")) {

            }

            for (var i = 0; i < languages.Count; i++) 
            {
                Console.WriteLine(languages[i]);
            }

            foreach (string language in languages) 
            {
                Console.WriteLine(language);
            }
        }

        public string Prop1 { get; set; }
        public int Prop2 { get; set; } 
        public bool Prop3 { get; set; }

        public void SelectPropList()
        {
            List<Lists> List = new List<Lists>();
            var AnonymousList = List.Select(x => new {x.Prop1, x.Prop2});
            foreach(var Item in AnonymousList) 
            {
                Console.WriteLine($"{Item.Prop1} - {Item.Prop2}"); 
            }
        }
    }
}