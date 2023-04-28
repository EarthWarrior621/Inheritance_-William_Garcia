using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance__William_Garcia
{
    class FPS : Games
    {

        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }
        public override string Describe()
        {
            return $"{Title} is a fps game rated {Esrb}!";
        }
    }
}
