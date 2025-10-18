namespace dotgrep
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: dotgrep [OPTION]... PATTERNS [FILE]...\r\n");
                Environment.Exit(2);
            }
            string? input = Console.In.ReadToEnd();
            if (args.Length == 2 && input != null)
            {
                if (input.Contains(args[1]))
                    Console.WriteLine(input);
                Environment.Exit(0);
            }

            string path = args[2];
            StreamReader sr = new StreamReader(path);

            string? line = sr.ReadLine();

            while (line != null)
            {
                if (line.Contains(args[1]))
                    Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
        }
    }
}