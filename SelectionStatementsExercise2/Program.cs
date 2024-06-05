namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite subject out of the choices below...\n" +
                "Math\n" +
                "Science\n" +
                "History\n" +
                "English\n" +
                "Physical Education\n");
            string favSub = Console.ReadLine();

            switch (favSub)
            {
                case "Math":
                    Console.WriteLine();
                    Console.WriteLine($"{favSub} is useful in fields such as engineering and phsyics!");
                    break;
                case "Science":
                    Console.WriteLine();
                    Console.WriteLine($"{favSub} is useful in fields such as biology and health sciences!");
                    break;
                case "History":
                    Console.WriteLine();
                    Console.WriteLine($"{favSub} is useful in a field such as archeology");
                    break;
                case "English":
                    Console.WriteLine();
                    Console.WriteLine($"{favSub} was my least favorite subject!");
                    break;
                case "Physical Education":
                    Console.WriteLine();
                    Console.WriteLine($"{favSub} is a great way to learn about the body and stay in shape!");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("You did not enter one of the choices listed");
                    break;
            }

        }
    }
}