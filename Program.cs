using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab008
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            Console.WriteLine(names[1] + " " + names[4]);


            {
                string[] months = new string[12];
                months[0] = "January";
                months[1] = "February";
                months[2] = "March";
                months[3] = "April";
                months[4] = "May";
                months[5] = "June";
                months[6] = "July";
                months[7] = "August";
                months[8] = "September";
                months[9] = "October";
                months[10] = "November";
                months[11] = "December";

                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine(i + " " + months[i]);
                }
                {
                    string[] seasons = new string[4];
                    seasons[0] = "Spring";
                    seasons[1] = "Summer";
                    seasons[2] = "Autumn";
                    seasons[3] = "Winter";
                    foreach (string season in seasons)
                    { Console.WriteLine(season); }

                    {
                        int[] numbers = new int[1000];
                        Random random = new Random();
                        for (int i = 0; i < 1000; i++)
                        {
                            int randomnumber = random.Next(0, 100);
                            numbers[i] = randomnumber;
                        }
                        foreach (int number in numbers)
                        { Console.WriteLine(number); }



                        {
                            string[] named = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

                            int i = 0;
                            while (i < named.Length)
                            {
                                Console.WriteLine(named[i]);
                                i++;

                            }
                        }
                    }

                        }
                }
        }
    }
}
