using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1:");
            Console.WriteLine("");
            var fruits = new[] { "apple", "mango", "orange", "apricot", "cherry", "grape", "blueberry" };

            foreach (var fruit in fruits)
            { Console.WriteLine(fruit); }
            Console.WriteLine("");
            Console.WriteLine("Question 2:");
            IEnumerable<string> query = from fruit in fruits
                                        where fruit[0].Equals('a')

                                        select fruit.ToUpper();
            foreach (var fruit in query)
Console.WriteLine(fruit);
            Console.WriteLine("");
            {

                
                Console.WriteLine("Questions 3-4:");

                List<DateTime> months = new List<DateTime> {new DateTime (2017, 7, 4), new DateTime(2017, 8, 4), new DateTime(2017, 9, 4),
                new DateTime(2017, 10, 4), new DateTime(2017, 11, 4),
                new DateTime(2017, 12, 4) };
                Console.WriteLine(months.Count);
                Console.WriteLine(months.Capacity);
                Console.WriteLine("");

                foreach (DateTime month in months)
                { Console.WriteLine(month.ToString("MMMM")); }
                Console.WriteLine("");
                months.AddRange(new List<DateTime> {new DateTime (2017, 1, 4), new DateTime(2017, 2, 4), new DateTime(2017, 3, 4),
                new DateTime(2017, 4, 4), new DateTime(2017, 5, 4),
                new DateTime(2017, 6, 4) });
                months.Sort();
                foreach (DateTime month in months)
                { Console.WriteLine(month.ToString("MMMM")); }
                Console.WriteLine("");


                months.Remove(new DateTime(2017, 1, 4));
                months.Remove(new DateTime(2017, 2, 4));
                months.Remove(new DateTime(2017, 3, 4));
                months.Remove(new DateTime(2017, 4, 4));
                months.Remove(new DateTime(2017, 5, 4));
                months.Remove(new DateTime(2017, 6, 4));
                Console.WriteLine(""); Console.WriteLine(months.Count);
                Console.WriteLine(months.Capacity);
                Console.WriteLine();


                IEnumerable<DateTime> ber = from month in months
                                            where month.ToString("MMMM").Contains("ber")
                                            select month;
                foreach (DateTime month in ber)
                { Console.WriteLine(month.ToString("MMMM")); }



                

            }
        }
    }
}
