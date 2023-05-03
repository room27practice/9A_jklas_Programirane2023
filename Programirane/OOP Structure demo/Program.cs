using OOP_Structure_demo.Neshta;

namespace OOP_Structure_demo
{
    class Engine
    {
        public static void Main()
        {
            Kamion k1 = new Vehicle.Kamion();
            k1.Go();

            var k2 = new MPS.Kamion();
            k2.Go();

            Console.WriteLine();
        }

        public static void Experiment()
        {
            Console.WriteLine("Experiment v klasa Engine");

        }
    }


}


