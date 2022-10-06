using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock,Paper,Scissors,GO!!!");
            string input = Console.ReadLine();
            string player=input.ToUpper();
            Console.WriteLine(player);
            List<string> bot_options = new List<string> { "ROCK","PAPER","SCISSORS" };
            Random R = new Random();
            int index = R.Next(bot_options.Count);
            string bot_answer = bot_options[index];
            Console.WriteLine(bot_answer);
            Console.WriteLine("Press Escape to exit");
            while (Console.ReadKey().Key!= ConsoleKey.Escape) { }
        }
    }
}
