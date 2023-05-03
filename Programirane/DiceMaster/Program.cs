namespace DiceMaster
{
    internal class Program
    {
        static void Main()
        {
           // var d1 = new Dice();
            ////  d1.Sides = 61;
            var d2 = new Dice("Chugun", "Cheren", 6);
            Console.WriteLine(d2);
            //d1.Roll();
            //d2.Roll();

            List<Dice> dices= new List<Dice>();
            Console.WriteLine("Vuvedi zarcheta!!!");
            while (true)
            {
                string input = Console.ReadLine(); //"8 Zelen Plastmasa" | STOP
                
                if (input=="STOP")
                {
                    break;
                }
                string[] data = input.Split(" ");//["8", "Zelen", "Plastmasa"]                
                int sides = int.Parse(data[0]);
                string color = data[1];
                string material = data[2];

                var dice = new Dice(material,color,sides);
                dices.Add(dice);
            }
            Console.WriteLine(new string('=',20));
            Console.WriteLine("Eto ti vuzmojnite zarcheta deto moje da si izbirash ot tqh");
            for (int i = 0; i < dices.Count(); i++)
            {
                Dice currentDice = dices[i];
                Console.WriteLine($"{i}.) {currentDice.Color} {currentDice.Material} s {currentDice.Sides} strani.");
            }
              
            Console.Write("Koe zarche iskash?...  ");
            int selectedIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("========Rezultat========");
            dices[selectedIndex].Roll();



           
        }
    }

    public class Dice
    {
       public Dice()
        {
            Material = "Plastmasa";
            Color = "Bialo";
            Sides = 8;
        }

        public Dice(string material, string color, int sides)
        {
            Material = material;
            Color = color;
            Sides = sides;
        }   

        public string Material { get; set; }
        public string Color { get; set; }
        public int Sides { get; set; }//6

        public void Roll()
        {
            Random random = new Random();
            int currentDraw = random.Next(1,Sides+1);            
            Console.WriteLine($"Zarche ot {Material}, sus cviat {Color}, iztegli {currentDraw}");
        }

        public override string ToString()
        {
            return $"Ti si samo osmi Klas. {Color}";
        }

    }





}