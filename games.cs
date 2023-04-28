using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance__William_Garcia
{
     abstract class Games
    {

        public string Esrb { get; set; }

        public string Title { get; set; }

        public Games(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }

        /// <summary>
        /// Print the title and say it is starting.
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");
        }

        public abstract string Describe();
    }
}
