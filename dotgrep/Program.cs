namespace dotgrep
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(args.Length);

            if (args[1] == null)
            {
                // TODO: read input from the terminal
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