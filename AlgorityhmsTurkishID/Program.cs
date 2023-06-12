namespace AlgorityhmsTurkishID
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            bool alwaysRun = true;
            while (alwaysRun==true) 
            {
                algorithmsturkishıddelegate();            
            }
        }

        public delegate void algorithmsTurkishIDDelegate();
        public static  algorithmsTurkishIDDelegate algorithmsturkishıddelegate=AlgorithmID;
        public static void AlgorithmID()
        {
            Console.WriteLine("Please enter number");
            long allbasecount = 0;
            long enterId;
            bool controller = long.TryParse(Console.ReadLine(), out enterId);
            string number = enterId.ToString();
            int count = number.Length;

            if (controller == true && count == 11)
            {
                long firstbase = (enterId % 10);

                for (int i = 0; i < count; i++)
                {

                    long bases = (enterId % 10);
                    allbasecount = allbasecount + bases;
                    enterId = (enterId / 10);

                }
                long result = ((allbasecount - firstbase) % 2);

                if (result == 0)
                {
                    Console.WriteLine("Id Correct");

                }
                else
                {
                    Console.WriteLine("Id Wrong");
                }
            }
            else
            {
                Console.WriteLine(enterId);
                Console.WriteLine("11 sayıdan az");
            }
            Console.ReadLine();

        }

    }
}