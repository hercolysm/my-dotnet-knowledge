namespace MyLibraryClass.NET6.Collections
{
    public class Arrays
    {
        public void Examples()
        {
            int[] array = new int[4];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;

            int[] array2 = new int[] { 1, 2, 3, 4 };
            int[] array3 = { 1, 2, 3, 4 };
            var array4 = new int[] { 1, 2, 3, 4 };

            string[] WeekDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            string monday = WeekDays[0];

            for (var i = 0; i < WeekDays.Length; i++) 
            {
                Console.WriteLine(WeekDays[i]);
            }

            foreach (string day in WeekDays) 
            {
                Console.WriteLine(day);
            }
        }

        public void Resize()
        {
            double[] array = new double[1];
            array[0] = 1.0;
            Array.Resize(ref array, 2);
            array[1] = 2.0;
        }

        public void Clone()
        {
            decimal[] array = new decimal[1];
            array[0] = 1.0M;
            decimal[] newArray = new decimal[2];
            Array.Copy(array, newArray, array.Length);
            Console.WriteLine(newArray[0]);
            Console.WriteLine(newArray[1]);
        }
    }
}