using System.Security.Principal;

namespace PersonTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] input = Console.ReadLine().Split(',');//Kathye,Leadbetter,63,12th Floor  || END

            while (input[0]!="END")
            {
                Person person = new Person();
                person.FirstName = input[0];
                person.LastName = input[1];
                person.Age = int.Parse(input[2]);
                person.Address = input[3];
                people.Add(person);
                
                input = Console.ReadLine().Split(',');
            }

            Console.WriteLine("Wich Person Do you want");
            int n = int.Parse(Console.ReadLine());
            while (n<0||n>=people.Count)
            {
                Console.WriteLine("Give Correct Index!!!");
                n = int.Parse(Console.ReadLine());
            }           
            people[n].SayInfo();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public void SayInfo()
        {
            Console.WriteLine($"I am {FirstName[0]}. {LastName}. I am {Age} old. I live in {Address}");
        }

    }
}