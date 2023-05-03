namespace MethodsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //AutoMechanic meh = new AutoMechanic();
            //meh.ChangeOil();

            //PrintLettersAndNumbers();

            //PrintNumbers();
            //Console.WriteLine("Hello, World!");



        }

        public static void PrintLettersAndNumbers()
        {
            PrintLetters();
            PrintNumbers(5, 5);
        }

        public static void PrintNumbers(int min)
        {
            for (int i = min; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static string RunTrack()
        {
            string result = "";
            for (int i = 0; i < 5; i++)
            {
                result += $"AM running {i}\n";
                Console.WriteLine(i+1);

            }

           return result;
        }



        public static void PrintNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintNumbers(int min, int max)
        {
            for (int i = min; i < max; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintNumbers(int min, uint max)
        {
            for (int i = min; i < 10; i++)
            {
                Console.WriteLine(i);
            }

        }



        public static void PrintLetters()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((char)('A' + i));
            }

        }


    }
}