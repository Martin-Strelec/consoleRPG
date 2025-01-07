using System.Reflection.Metadata;

namespace consoleRPG
{
    class Gui
    {
        //Input methods
        public static void GetInput(string str)
        {
            str = $"- {str}: ";

            Console.Write(str);
        }
        //
        public static int GetInputInt(string message)
        {
            int input;

            try
            {
                Gui.GetInput(message);
                input = int.Parse(Console.ReadLine());
                return input;
            }
            catch (FormatException e)
            {
                Console.Clear();
                Console.WriteLine("Nothing entered!");
                Gui.PressKeyToContinue();
                return -1;
            }
            
        }
            

    //Announcments
    public static void PressKeyToContinue()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("==> Press any key to continue");
        Console.ReadKey();
    }
    public static void Title(string str)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        str = $"==== {str} ====";

        Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (str.Length / 2)) + "}\n",str));
        Console.ResetColor();
    }

    public static void MenuTitle(string str)
    {
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        str = $"=== {str} ===";

        Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (str.Length / 2)) + "}\n",str));
        Console.ResetColor();
    }

    public static void MenuOption(params string[] str)
    {
        for (int i = 1; i <= str.Length; i++)
        {
            Console.Write($"- ({i}): {str[i - 1]}\n");
        }
    }

    public static void Announcment(string str)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        str = $"\n(~) {str}\n";

        Console.Write(str);
        Console.ResetColor();
    }

    public static void Error(string str)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        str = $"(!) {str}\n";

        Console.Write(str);
        Console.ResetColor();
    }

    //Visual guides
    public static string ProgressBar(int min, int max, int width)
    {
        double percentage = (double)min / max;
        int done = Convert.ToInt32(percentage * width);
        int undone = width - done;

        string bar = "[";
        for (int i = 0; i < done; i++)
        {
            bar += "*";
        }
        for (int i = 0; i < undone; i++)
        {
            bar += "-";
        }
        bar += "]";

        return bar;
    }

}
}