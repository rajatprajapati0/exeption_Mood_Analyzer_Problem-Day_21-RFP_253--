using System;

namespace Mood_Analyzer
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome in Mood Analyzer Program ");
            Console.WriteLine("How Are You");

            Mood mood = new Mood(Console.ReadLine());

            Console.WriteLine(mood.checkMood());
        }
    }
}
