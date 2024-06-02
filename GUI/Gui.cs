using System.Reflection.Metadata;

namespace consoleRPG
{
    class Gui
    {
        public static void Title(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            str = $"==== {str} ====\n\n";

            Console.Write(str);
            Console.ResetColor();
        }

        public static void MenuTitle(string str)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            str = $"=== {str}\n";

            Console.Write(str);
            Console.ResetColor();
        }

        public static void MenuOption(params string[] str)
        {
            for (int i = 1; i <= str.Length; i++)
            {
                Console.Write($"- ({i}): {str[i-1]}\n");
            }
        }

        public static void GetInput(string str)
        {
            str = $"- {str}: ";

            Console.Write(str);
        }

        public static int GetInputInt(string message)
        {
            Nullable<int> input = null;

            while (input == null)
            {
                try
                {
                    Gui.GetInput(message);
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return input.Value;
        }

        public static void Announcment(string str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            str = $"\n(~) {str}!\n";

            Console.Write(str);
            Console.ResetColor();
        }

    }
}