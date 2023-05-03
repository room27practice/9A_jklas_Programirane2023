namespace StudentsGrades
{
  public class Table
    {
        public string Adress { private get; set; }
        public string Color {  get; set; }
        public string Manufacturer {  get; set; }
        public string Shop {  get; set; }
        public int AmmountAvailable {  get; set; }


    }  
    
    
    
    internal class Program
    {

        static void Main(string[] args)
        {
            //Table a1 = new Table();
            //a1.Adress = "Nqkakuv adress";


            Dice d1 = new Dice(5);

            
            var student = new Student();
            student.FirstName = "Aleksandr";
            student.LastName = "Aleksandr";
            student.Age = 16;
            student.KlassRank = 9;



            var gr1 = new Grade()
            {
                Name = "Mathematika",
                Value = 5.73,
                TeacherName = "Chervenkova",
                ImportanceFactor = 100
            };

            Grade gr2 = new Grade();
            gr2.Name = "Bulgarski Ezik";
            gr2.Value = 4.49;
            gr2.TeacherName = "Yaneva";
            gr2.ImportanceFactor = 78;

            Grade gr3 = new Grade("Biology", "Matev", 6.00, 60);

            student.AddGrade(gr1);
            student.AddGrade(gr2);

            string[] result = student.GetGradesInfo();

            Console.WriteLine(string.Join("\n",result));
        }
    }
}

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool Gender { get; set; } = true;
    public int KlassRank { get; set; }
    private List<Grade> GradeBook { get;  set; } = new List<Grade>();

    public void AddGrade(Grade grade)
    {
        if (grade.Value > 6 || grade.Value < 2)
        {
            Console.WriteLine("Sorry your grade is not valid it has to be between 2-6");
            return;
        }
        GradeBook.Add(grade);
    }
    public string[] GetGradesInfo()
    {
        string[] result = GradeBook.Select(x => $"{x.Name} ({x.Value:F2}) - {x.TeacherName}").ToArray();
        return result;
    }
    public double GetAverageGrade()
    {
        double result = GradeBook.Select(x => x.Value).Average();

        return result;
    }
    public void PrintAverageGrade()
    {
        double result = GradeBook.Select(x => x.Value).Average();
        Console.WriteLine(result);        
    }
}

class Dice
{
    public Dice(string word) { }
    public Dice(int sides)
    {
        this.Sides = sides;
    }
    public int Sides { get; set; }
}




public class Grade
{
    public Grade()
    {

    }

    public Grade(string name, string teacherName, double value, int importanceFactor)
    {
        Name = name;
        TeacherName = teacherName;
        Value = value;
        ImportanceFactor = importanceFactor;
    }

    public string Name { get; set; }
    public string TeacherName { get; set; }
    public double Value { get; set; }

    public int ImportanceFactor { get; set; }
    public DateTime CreateDate { get; set; }
    public string GradeReason { get; set; }
}