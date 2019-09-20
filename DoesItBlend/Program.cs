using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendables> blenables = new List<IBlendables>();
            blenables.Add(new Strawberry());
            blenables.Add(new Banana());
            blenables.Add(new CellPhone());
            blenables.Add(new IceCubes());
            for (int i = 0; i < 10; i++)
            {
                blenables.Add(new Mango());
            }
            Banana b = new Banana();
            Console.WriteLine(b.Blend());
            blenables.Add(b);
            string mess = "";
            foreach (IBlendables blendable in blenables)
            {
                mess += blendable.Blend();
            }
            Console.WriteLine(mess);
        }
    }
}
