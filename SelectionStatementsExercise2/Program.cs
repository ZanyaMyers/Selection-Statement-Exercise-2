namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch(subject)
            {
                case "Math":
                    Console.WriteLine("Math is my least favorite subject");
                break;
                case "History":
                    Console.WriteLine("History is my favorite subject");
                    break;
                case "English":
                    Console.WriteLine("English is fun!");
                    break;
                case "Science":
                    Console.WriteLine("Science is a hard subject");
                    break;
                default:
                    Console.WriteLine($"Oh wow! I have not taken that subject. {subject} sounds fun!");
                    break; 



           
            }
       
        }
    }
}