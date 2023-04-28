using System;

namespace Inheritance__William_Garcia
{
    class Program
    {
        static void Main(string[] args)
        {
            FPS myFPS = new FPS("M", "Call of Duty");

            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();

            FPS csGO = new FPS("E", "Skate 3");
            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();
        }
    }
}
