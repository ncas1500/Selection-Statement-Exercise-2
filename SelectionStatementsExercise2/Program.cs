namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "science":
                    Console.WriteLine("Some careers to choose from are astronomer, meteorologist or a chemist.");
                    break;

                case "math":
                    Console.WriteLine("Some careers to choose from economist, financial planner, accountant, or a investment banker.");
                    break;

                case "english":
                    Console.WriteLine("Some careers to choose from are public relations, journalist, copywriter, news reporter, or a advertiser.");
                    break;

                    case "visual arts":
                    Console.WriteLine("Some careers to choose from are architectural design, filmmaking, painter, photographer or a painter.");
                    break;

                    case "foreign language":
                    Console.WriteLine("Some jobs to choose from foreign language teacher, intelligence analyst, immigration paralegal, travel agent or a translator.");
                    break;

                default:
                    Console.WriteLine("We're expanding the range of subjects to determine possible career options, Please come back soon.");
                    break;
            }
        }
    }
}