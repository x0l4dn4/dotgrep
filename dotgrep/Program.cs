namespace dotgrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: read input from a file
            string input = Console.In.ReadToEnd();
            Console.WriteLine(input);
            if (input.Contains(args[1]))
            {
                Console.WriteLine(input);
                Environment.Exit(0);
            }
            Environment.Exit(1);

        }
    }
}
