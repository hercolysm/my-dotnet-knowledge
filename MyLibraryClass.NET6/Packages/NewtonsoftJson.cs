using Newtonsoft.Json;

namespace MyLibraryClass.NET6.Examples.Packages
{
    public class NewtonsoftJson
    {
        public void InstallPackage()
        {
            Console.WriteLine("Run command: dotnet add package Newtonsoft.Json --version 13.0.3");
        }

        public void ConvertObjectToJson()
        {
            var Object = new { Prop1 = "Value1", Prop2 = 123 };
            string Json = JsonConvert.SerializeObject(Object);
            Console.WriteLine(Json);
        }
        public void ConvertObjectToIndentedJson()
        {
            var Object = new { Prop1 = "Value1", Prop2 = 123 };
            string Json = JsonConvert.SerializeObject(Object, Formatting.Indented);
            Console.WriteLine(Json);
        }

        public void ConvertListObjectToJson()
        {
            var Object1 = new { Prop1 = "Value1", Prop2 = 123 };
            var Object2 = new { Prop1 = "Value1", Prop2 = 123 };

            List<object> ListObject = new List<object>();
            ListObject.Add(Object1);
            ListObject.Add(Object2);

            string Json = JsonConvert.SerializeObject(ListObject, Formatting.Indented);
            Console.WriteLine(Json);
        }

        public void ConvertJsonToObject()
        {
            string Json = "{\"Prop1\":\"Value1\",\"Prop2\":123}";
            object Object = JsonConvert.DeserializeObject<object>(Json);
            Console.WriteLine(Object.ToString());
        }

        public void ConvertJsonToListObject()
        {
            string Json = "[{\"Prop1\":\"Value1\",\"Prop2\":123},{\"Prop1\":\"Value1\",\"Prop2\":123}]";
            List<object> ListObject = JsonConvert.DeserializeObject< List<object> >(Json);
            foreach(object Object in ListObject) 
            {
                Console.WriteLine(Object.ToString());
            }
        }

        /* use for function DeserializeObject 
            when property name in JSON is diferent property name object */
        [JsonProperty("ExternalName")] 
        public string? IntenalName { get; set; }
    }
}