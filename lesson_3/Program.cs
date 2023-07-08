namespace lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
           
            int randomNumber = random.Next(1, 100);          
            int number;          
            int n = 0;

            do
            {
                   Console.Write("Son kiriting (1 dan 100 gacha): ");
                    
                     number = Convert.ToInt32(Console.ReadLine());
                   
                     n++;

                if (number > randomNumber)
                {
                    Console.WriteLine("Men oylagan son kichikroq");
                }
                else if (number < randomNumber)
                {
                    Console.WriteLine("Men oylagan son kattaroq");
                }
                else
                {
                    Console.WriteLine("TABRIKLAYMAN SIZ " +n+ " - urinishda topdingiz!");
                    break;
                }

             } while (number != randomNumber) ;

                     Console.ReadLine();
        }
    }
}