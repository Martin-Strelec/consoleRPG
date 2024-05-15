/*
*	Name: consoleRPG
*	Author: Martin Strelec
*	Date: 02/May/2024
*	Purpose: Learning to make a console game in C#
*/

namespace consoleRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Console formatting command

            Game game = new Game();
            game.Run();
            
        }
    }
}