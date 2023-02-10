public class Program
{
    public static void Main()
    {
        Console.WriteLine("Input 3 words!");
        Console.Write("Input 1 word: ");
        string word1 = Console.ReadLine();
        Console.Write("Input 2 word: ");
        string word2 = Console.ReadLine();
        Console.Write("Input 3 word: ");
        string word3 = Console.ReadLine();

        Console.WriteLine("Which word do you like [1,2,3]");

        int choise = int.Parse(Console.ReadLine());

        Console.Write("Your word is ");
        if (choise==1)
        {
            Console.WriteLine(word1);
        }
        if (choise == 2)
        {
            Console.WriteLine(word2);
        }
        if (choise == 3)
        {
            Console.WriteLine(word3);
        }



    }



}




