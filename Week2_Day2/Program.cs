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

            //string[] bands = { "Jay-Z", "Busi Mhlongo", "Kendrick Lamar", "The Beatles", "Rolling Stones", "Thelonius Monk" };

            //foreach(string band in bands)
            //{
            //    Console.WriteLine(band);
            //}

            //for(int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Do you want to play the game? (YES/NO)");
            //string playAgain = Console.ReadLine();

            //while (playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}

            //Console.WriteLine("Would you like to check in for your appointment? YES/NO");
            //string appCheck = Console.ReadLine().ToUpper();

            //while(appCheck != "YES")
            //{
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM");
            //    Console.WriteLine("Please enter your full name.");
            //    string fullName = Console.ReadLine().ToUpper();

            //    Console.WriteLine("Please enter your 6-digit patient ID.");
            //    int patientId = int.Parse(Console.ReadLine().ToUpper());

            //    Console.WriteLine("Please enter your appointment time.");
            //    string appTime = Console.ReadLine().ToUpper();

            //    Console.WriteLine("You are now checked in. Have a nice day.");
            //    Console.WriteLine("Would you like to check in a patient for their appointment?");
            //}

            //string playAgain;
            //do
            //{
            //    //Console.WriteLine("Do you want to play the game? YES/NO");
            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine().ToUpper();
            //}
            //while (playAgain == "YES");

            //string userGrades;
            //do
            //{
            //    Console.WriteLine("What class would you like to add to your GPA calculation?");
            //    Console.ReadLine();
            //    Console.WriteLine("Please enter the letter grade for the class.");
            //    Console.ReadLine();
            //    Console.WriteLine("Do you have another class you would like to add to your GPA calculation?");
            //    userGrades = Console.ReadLine().ToUpper();
            //}
            //while (userGrades == "YES");

            //for (int i = 0; i < 20; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 13 == 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("The loop has finished.");

            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= 8; j++)
            //    {
            //        Console.Write(j); /*columns*/
            //    }
            //    Console.WriteLine(); /*next row*/
            //}

            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
