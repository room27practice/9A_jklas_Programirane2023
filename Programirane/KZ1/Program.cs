namespace KZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "1,2,5,7,8,9,0,-12,43,24";
            string[] stringNumbers = input.Split(',');
            int[] numbers = new int[stringNumbers.Length];
            for (int i = 0; i < stringNumbers.Length; i++)
            {
                numbers[i] = int.Parse(stringNumbers[i]);
            }


            string[] song = { "words", "don't", "come", "easy", "to me" };

            for (int i = 0; i < song.Length; i++)
            {
                ;
                if (i % 2 != 0)
                { Console.WriteLine(song[i]); }
            }
        }
    }
}

//    // Jongliora();
//    // Demo2(words);
//}

//        //private static void Demo2()
//        //{
//        //    string input = "baba, jaba, distancionno, lastichka, telbod";

//        //    string[] words = input.Split(", ");

//        //    int[] wordLengths = words.Select(w => w.Length).ToArray();
//        //    char[] onlyFirstLettersOfWords = words.Select(w => w[0]).ToArray();
//        //    var onlyLastLettersOfWords = words.Select(w => w[w.Length - 1]).ToArray();

//        //    Console.WriteLine(onlyFirstLettersOfWords[0]);


//        //    for (int i = 0; i < words.Length; i++)
//        //    {
//        //        if (i % 2 != 2)
//        //        {

//        //        }
//        //        Console.WriteLine(words[i].Length);
//        //    }


//        //    Console.WriteLine(words[2]);



//        //    Console.ReadLine();
//        //}

//        private static void Jongliora()
//        {
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine($"Hello, World! {a}");
//        }

//}