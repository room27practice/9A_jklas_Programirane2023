using System;


namespace Variables
{
    internal class Program
    {
        static void Main()
        {
            //3^5
            var result = Math.Pow(3, 5);
            // Demo1();
            //  Task1_Numbers();

            string number = Console.ReadLine();
            int total = 0;
            for (int i = 0; i < number.Length; i++)
            {
                total = total + (number[i] - '0');
            }
            Console.WriteLine(total);

        }

        private static void Task1_Numbers()
        {
            int number = int.Parse(Console.ReadLine());//135
            int total = 0;
            while (number != 0)
            {
                total = total + number % 10;
                number = number / 10;
            }
            Console.WriteLine(total);
        }

        private static void Demo1()
        {
            string some = "Banan";
            string thing = "Portokal";//Banan Portokal
            string result = some + " - " + thing;
            string result2 = $"{some} - {thing}";

            int minutes = 20;
            int hours = 11;
            //Time is 11-20 before 3 mintues!
            string myFormat = "Local Time is {0}-{1} before 3 mintues {0}!";


            string result3 = string.Format(myFormat, hours, minutes);


            // VariablesDemo1();
            //WordCharReplacementDemo();
            //ZigZagNumbers();

            string nameOfSeries = Console.ReadLine(); //BreakingBad
            int seasonsNumber = int.Parse(Console.ReadLine()); //5
            int episodesInSason = int.Parse(Console.ReadLine()); //10
            double episodeTime = double.Parse(Console.ReadLine());//42.50

            double additionalFinalEpisodeTime = 10d * seasonsNumber;
            double episodeTimeWithCommersials = 1.2 * episodeTime;

            int totalCountOfEpisodes = episodesInSason * seasonsNumber;

            double totalTime = additionalFinalEpisodeTime + episodeTimeWithCommersials * totalCountOfEpisodes;

            Console.WriteLine($"Total time needed to watch the {nameOfSeries} series is {Math.Floor(totalTime)} minutes.");
        }

        //private static void ZigZagNumbers()
        //{


        //    int num = int.Parse(Console.ReadLine());
        //    int[] row1 = new int[num];
        //    int[] row2 = new int[num];

        //    for (int i = 0; i < num; i++)
        //    {
        //        int[] input = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        //        if (i % 2 == 0)
        //        {
        //            row1[i] = input[0];
        //            row2[i] = input[1];
        //        }
        //        else
        //        {
        //            row2[i] = input[0];
        //            row1[i] = input[1];
        //        }
        //    }
        //    Console.WriteLine(string.Join(" ", row1));
        //    Console.WriteLine(string.Join(" ", row2));
        //}

        //private static void WordCharReplacementDemo()
        //{
        //    //1 Прочетете дума от конзолата
        //    //2 Въведете индекс на символ от думата
        //    //3 Въведете нов Символ
        //    //4 Изпишете думата (променете я) със новия символ на мястото където ви е посочен индекса

        //    Console.WriteLine("Vuvedi duma:");
        //    string word = Console.ReadLine(); //Terakot -> 7

        //    Console.WriteLine($"Dai mi index mejdu 0 - {word.Length - 1}");
        //    int index = int.Parse(Console.ReadLine());//2
        //    Console.WriteLine("Vuvedi nov simvol:");
        //    char symbol = Console.ReadLine()[0]; //Pak -> P

        //    var result = word.ToCharArray();
        //    result[index] = symbol;
        //    Console.WriteLine(result);
        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(word[i]);
        //    }
        //}

        //private static void VariablesDemo1()
        //{

        //    // 1, 2, 17  -- Цели числа (byte, short, int, long, BigInteger)

        //    int a = 15000;
        //    byte b = (byte)a;
        //    // 1.34, 0.232, 17.56  -- Дробни числа числа (float,double,decimal)

        //    string message = "124spiashtata^%#@ krastavica";

        //    char symbol = '&';

        //    int result = (int)message[4];

        //    Console.WriteLine($"Letter 2*( is {(char)('(' + '(')} letter from english Alphabet");

        //    for (int i = 0; i < message.Length; i++)
        //    {
        //        Console.Write(message[i] + " ; ");
        //    }

        //    foreach (char letter in message)
        //    {
        //        Console.WriteLine(letter + " - " + (int)letter);
        //    }
        //    var c = "" + 'a' + 'k' + (int)'/'; //"ak/"   "ak45"
        //    var k = (int)54.87;
        //    var p = (double)15;

        //    bool test;   // ""   null


        //    bool isSomethingReal = true;
        //    bool is5OddNumber = 5 % 2 == 0;

        //    if (isSomethingReal && is5OddNumber)
        //    {

        //    }

        //}
    }
}