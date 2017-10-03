using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i <=10; i++)
            //{
            //    //Console.WriteLine(i);
            //}
            //for(int counter = 50; counter <= 100; counter++)
            //{
            //    //Console.WriteLine(counter);
            //}

            //string greetings = "My name is Rashida";
            //string[] words = greetings.Split();

            //for(int i  = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int counter = 50; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //    Console.Write(counter+" ");
            //}

            //string greeting = "My name is Little Bill";
            //string[] words = greeting.Split();

            //for(int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //for(int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //string story = "Once upon a time";
            //string[] storyWords = story.Split();
            //Array.Reverse(storyWords);

            //for(int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            //foreach(string month in months)
            //{
            //    Console.WriteLine(month);
            //}

            string[] bands = { "Jay-Z", "Busi Mhlongo", "Kendrick Lamar", "The Beatles", "Rolling Stones", "Thelonius Monk" };

            foreach(string band in bands)
            {
                Console.WriteLine(band);
            }
        }
    }
}
