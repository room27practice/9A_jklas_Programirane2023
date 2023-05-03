
    internal class Program
    {
        static void Main(string[] args)
        {
         
        
        
        
        Student[] students =
                {
            new Student("Aleksandr","Zeleno"),
            new Student("Anul","Julto"),
            new Student("Viktor","Lilavo"),
            new Student("Vladimir","Cherno"),
            new Student("Daniel","Rozovo"),
            new Student("Djan","Rozovo"),
            new Student("Ivelin","Bql"),
            new Student("Kristian","Cherno"),
            new Student("Martin","Cherno"),
            new Student("Mustafa","Cherno"),
            new Student("Nikola","Lilavo"),
            new Student("Simeon","Cherno"),
                };
            while (true)
            {
                string[] colors = students.Select(x => x.FavoriteColor).Distinct().ToArray();
                Console.WriteLine("Choose Color:");
                Console.WriteLine(string.Join(" ", colors));
                string colorSelected = Console.ReadLine();
                Console.WriteLine("Students with this color:");
                string[] namesOfStudentsWithThisColor = students
                    .Where(x => x.FavoriteColor == colorSelected)
                    .Select(x => x.Names)
                    .ToArray();
                Console.WriteLine(string.Join(" ", namesOfStudentsWithThisColor));

            }


        }
    }






    public class Student
    {
        public Student(string names, string favoriteColor)
        {
            Names = names;
            FavoriteColor = favoriteColor;
        }

        public Student(string names, string favoriteColor, string address)
        {
            Names = names;
            FavoriteColor = favoriteColor;
            Address = address;
        }

        public string Names { get; set; }
        public string FavoriteColor { get; set; }
        public string Address { get; set; }
    }

