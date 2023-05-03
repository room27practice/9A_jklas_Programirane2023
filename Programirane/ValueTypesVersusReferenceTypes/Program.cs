namespace ValueTypesVersusReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valuesString = "9-|-23-|-44-|-7-|-5-|-8";

       



            int[] myNumbers = valuesString.Split("-|-").Select(n => int.Parse(n)).ToArray();
            //["9","23"....]

            string word = "dsagdlgdkjghdkfg";

            char[] charovete = word.ToCharArray();

                //["d","s","a"....]

            int j = 42;

            char ch = 'A';

            bool result = true;

            int m = j;

            m = 60;
            Console.WriteLine(j);
            Console.WriteLine(m);


            int[] nums1 = { 1, 2, 3 };
            
            int[] secondNums = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                secondNums[i] = nums1[i];
            }

            secondNums[1] = 102;

            Console.WriteLine(string.Join(" ",nums1));
            Console.WriteLine(string.Join(" | ", secondNums));

            int c = nums1[1];
            c = 99999;


        }
    }
}