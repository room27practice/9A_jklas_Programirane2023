    internal class Program
    {
    static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Purvoslav";
            p1.Age = 16;
           
            //Тук ползваме безпараметричен конструктор
            Person p2 = new Person();
            p2.Name = "Vtorislav";
            p2.Age = 30;

            //Тук ползваме конструктор с 1 параметър само стринг
            Person p3 = new Person("Tretomira");
      
            p3.Age = 10;

            //Тук ползваме конструктор с два параметъра
            Person p4 = new Person("Chetvurtoslav", 3);

            //p1.AgeUp();
            //p1.AgeUp();
            p1.RecordMyEGN("P235JkLMS&+");
            p1.PrintMyEGN();

            Person[] people = { p1, p2, p3 };

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Age < 18)
                {
                    people[i].AgeUp();
                }
            }
        }
    }
    public class Person
    {
    public Person()
    {
        Console.WriteLine("Берпараметричен констуктор се пусна!!!");
    }
    public Person(string name)
    {
        Name =name;
    }
    public Person(string name,int age)
    {
        Name = name;
        Age = age;
    }


    private string EGN = "";
        public string Name { get; set; }
        public int Age { get; set; } = 10;

        public void AgeUp()
        {
            Age++;
            Console.WriteLine($"{Name} aged up and now is {Age} years old!");
        }

        public void PrintMyEGN()
        {
            Console.WriteLine("****" + EGN.Substring(3, 4) + "****");
        }
        public void RecordMyEGN(string egn)
        {
            EGN = egn;
        }
    }
