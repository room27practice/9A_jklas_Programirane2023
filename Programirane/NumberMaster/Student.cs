namespace NumberMaster
{
    public class Student
    {
        public static string SchoolName { get; set; } = "PGMETT";
        public string Names { get; set; }
        public string Address { get; set; }

        public void PrintNames(int age)
        {
            Console.WriteLine($"My name is {Names}. My age is {age} I study in {SchoolName}");
        }

        public static void PrintSchool(int times)
        {
            for (int i = 0; i < times; i++)
            {

                Console.WriteLine($"{SchoolName}");
            }
        }

    }
}
