namespace NumberMaster
{
    public class Program
    {
        public static void Main()
        {
            //Student.PrintSchool(4);
            Console.WriteLine(GETSUM(true, 1, 5, 2));
            Console.WriteLine(GETSUM(false, 1, 5, 2, 44));
            Console.WriteLine(GETSUM(true, 1, 5));
            Console.WriteLine(GETSUM(true, 1));
            Console.WriteLine(GETSUM(false));
            Console.WriteLine(GETSUM(true, 5, -23, 6, 7, 1, 5, 3, 6, 6, 6, 222));


            //Student ivan = new Student();
            //ivan.Names = "Ivan Ivanov Ivanov";
            //Student georgi = new Student();
            //georgi.Names = "Georgi Georgiev";

            //ivan.PrintNames(16);
            //georgi.PrintNames(6);




            Console.WriteLine("Welcome to Number Master");
            Console.WriteLine("Chose operation");
            Console.WriteLine("1) Sum Numbers");
            Console.WriteLine("2) Sum Numbers Between");
            Console.WriteLine("3) Make Array of Numbers Between");
            Console.WriteLine("4) Print Odd Numbers Between");
            Console.WriteLine("5) Print Even Numbers Between");
            string choise = Console.ReadLine();

            Console.Write("Input Number 1=");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input Number 2=");
            int num2 = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case "1":
                    {
                        NumberMaster nm = new NumberMaster();
                        nm.Multiplier = 2;
                        int result = nm.GetSumOfNumbers(num1, num2);
                        Console.WriteLine($"Result: {result}");

                        NumberMaster nm2 = new NumberMaster();
                        nm2.Multiplier = 10;
                        int result2 = nm2.GetSumOfNumbers(num1, num2);
                        Console.WriteLine($"Result: {result2}");
                        break;
                    }
                case "2":
                    {
                        int result = NumberMaster.GetSumOfAllNumbersBetween(num1, num2);
                        Console.WriteLine($"Result: {result}");
                        break;
                    }

                case "3":
                    {
                        int[] result = NumberMaster.MakeArrayOfNumbersBetween(num1, num2);
                        Console.WriteLine($"Result: {string.Join(";", result)}");
                        break;
                    }
                case "4":
                    {
                        NumberMaster.PrintOddNumbersBetween(num1, num2);
                        break;
                    }
                case "5":
                    {
                        NumberMaster.PrintEvenNumbersBetween(num1, num2);
                        break;
                    }
            }
        }
        public static int GETSUM(bool shouldDouble, params int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i];
            }
            if (shouldDouble)
            {
                result *= 2;
            }
            return result;
        }
    }
}