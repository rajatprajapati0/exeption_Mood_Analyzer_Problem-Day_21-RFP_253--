using System;

namespace Mood_Analyzer
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Mood Analyzer Program ");
            Console.WriteLine("How Are You");

            Mood mood1 = new Mood();
            Console.WriteLine("constructor 1 " + mood1.checkMood());

            Mood mood2 = new Mood(null);
            Console.WriteLine("constructor 2 "+mood2.checkMood());
            
        }
    }
}
