namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 1-10: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    int v = j % 2;
                    int w = i % 2;
                    string row = v == w ? "◼︎" : "◻︎";
                    Console.Write(row);
                }
                Console.WriteLine("");
            }
        }
    }
}
