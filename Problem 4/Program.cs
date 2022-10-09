using System;
using System.Collections.Generic;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Artist, Song;
            int Minuts, Seconds;
            int num;

            List<Radio> radios = new List<Radio>();
            Console.WriteLine("Select the number of songs");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i =0;i< num; i++)
            {
                Console.WriteLine("Select Artist");
                Artist = Console.ReadLine();
                Console.WriteLine("Select his song");
                Song = Console.ReadLine();
                Console.WriteLine("How many minutes");
                Minuts = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many seconds");
                Seconds = Convert.ToInt32(Console.ReadLine());

                radios.Add(new Radio(Artist, Song, Minuts, Seconds));
            }
            Console.ReadLine();
        }
    }
}
