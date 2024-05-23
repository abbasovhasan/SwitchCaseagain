namespace SwitchCaseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  seasons = Console.Readline().ToLowercase();
            string f = " ";

            switch (seasons)
            {
                case "spring":
                   fesil = "yaz";
                    break;
                case "summer":
                    fesil = "yay";
                    break;
                case "autumn":
                    fesil = "payiz";
                    break;  
                case "winter":
                    fesil = "qis";
                    break;  
                    default:
                    Console.WriteLine("Yalnis melumat");
                    break;

            }
        }
    }
}
