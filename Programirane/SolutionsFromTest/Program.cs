namespace SolutionsFromTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Demo1();
            while (true)
            {
                Console.WriteLine("Vuvedi Chisla");
                string[] array1 = Console.ReadLine().Split(" ");// "43 23 11 43 -8 Genadi"
                Console.WriteLine("Vuvedi Broika rotacii");
                int rotations = int.Parse(Console.ReadLine());//3

                for (int r = 0; r < rotations % array1.Length; r++)
                {
                    string temp = array1[0];
                    for (int i = 0; i < array1.Length - 1; i++)
                    {
                        array1[i] = array1[i + 1];
                    }
                    array1[array1.Length - 1] = temp;
                }

                Console.Write("Resultat: ");
                Console.WriteLine(string.Join(" ", array1));
            }


        }

        private static void Demo1()
        {
            int[] numbers = Console.ReadLine().Split(",").Select(n => int.Parse(n)).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    numbers[i]++;
                }
                numbers[i]++;
                Console.Write(numbers[i] + ",");
                //if (nudmbers[i]%2==0)
                //{
                //    numbers[i]++;
                //}
                //else
                //{
                //    numbers[i] += 2;
                //}
            }
            Console.WriteLine();
            // Console.WriteLine(string.Join(",",numbers));




            //string[] song = { "portokal", "banan", "limon", "kiwi", "zelenchuk", "cherven chuk", "surpichuk" };

            //foreach (var phrase in song)
            //{
            //    Console.WriteLine(phrase);
            //}

            //for (int i =song.Length-1 ; i >=0 ; i--)
            //{
            //    if (i%2==1)
            //    {
            //    Console.WriteLine(song[i]);

            //    }
            //    else
            //    {
            //        Console.WriteLine(new string('*', song[i].Length));
            //    }
            //}


            //  Console.WriteLine(string.Join(", ",song));


            //var numbers = "1, 2, 4".Split(", ").Select(n => int.Parse(n)).ToArray();
        }
    }
}