﻿namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new[] { " ", "-", "_" }, StringSplitOptions.RemoveEmptyEntries);

            int maxRepeating = 0;
            string element = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                string current = array[i];
                int repeatingCurrent = 0;

                for (int j = i+1; j < array.Length; j++)
                {
                    if (current == array[j])
                    {
                        repeatingCurrent++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (repeatingCurrent>maxRepeating)
                {
                    maxRepeating = repeatingCurrent;
                    element = current;
                }
            }
            for (int i = 0; i <= maxRepeating; i++)
            {
                Console.Write(element+" ");
            }
            Console.WriteLine();

            //"1-P-d_lsad ss-d- -"["1" "P" "d" "lsad" "ss " "d" " "]



            //TrainTask1();


            // EqualLeftRightSum();




            // JoinOfArrayDemo();
        }

        private static void EqualLeftRightSum()
        {
            int[] numbers =
                 Console.ReadLine()
                 .Split(" ").Select(x => int.Parse(x)).ToArray();// 1 2 3 3
            for (int i = 0; i < numbers.Length; i++)//2
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int L = 0; L < i; L++)
                {
                    leftSum += numbers[L];
                }
                for (int R = i + 1; R < numbers.Length; R++)
                {
                    rightSum += numbers[R];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }

        private static void TrainTask1()
        {
            int wagonCount = int.Parse(Console.ReadLine());
            int[] peopleInWagons = new int[wagonCount];
            int totalPeople = 0;
            for (int i = 0; i < peopleInWagons.Length; i++)
            {
                peopleInWagons[i] = int.Parse(Console.ReadLine());
                totalPeople += peopleInWagons[i];
            }

            string result = string.Join(" ", peopleInWagons);
            Console.WriteLine(result);
            Console.WriteLine(totalPeople);
        }

        private static void JoinOfArrayDemo()
        {
            string[] daysOfWeek =
                  { "Ponedelnik", "Vtornik", "Srqda", "Chetvurtuk", "Petuk","Subota" };

            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.Write(daysOfWeek[i] + "|");
            }
            Console.WriteLine();

            Console.WriteLine(string.Join("\n", daysOfWeek));
        }

        private static void DayOfWeekDemo2()
        {
            string[] daysOfWeek =
                { "Ponedelnik", "Vtornik", "Srqda", "Chetvurtuk", "Petuk","Subota" };
            Console.WriteLine($"Vuvedi den ot sedmicata 1-{daysOfWeek.Length}");
            int day = int.Parse(Console.ReadLine());//
            if (day < 1 || day > daysOfWeek.Length)
            {
                Console.WriteLine("Sorry wrong day of week!");
            }
            else
            {
                Console.WriteLine($"Ti izbra: {daysOfWeek[day - 1]}");
            }
        }

        private static void Demo1()
        {
            int[] numbers = { 1, 4, 5, 6, 7, 8, 9, -109 };

            int[] nums = new int[5];
            bool[] yesOrNo = new bool[3];
            nums[2] = 36;
            nums[4] = 11;
            yesOrNo[1] = true;


            Console.WriteLine($"Tretoto chislo v masiva e {nums[2]}");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Vuvedi {i + 1} chislo");
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{i + 1} chislo v masiva e {nums[i]}");
            }
        }
    }
}