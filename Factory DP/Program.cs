using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Factory_DP.FactoryMethod;
using static Factory_DP.Figures;

namespace Factory_DP
{
  
    class Program
    {
        static void Main(string[] args)
        {
            IFigureCreator[] creator = new IFigureCreator[6];
            creator[0] = new LUpCreator();
            creator[1] = new VerticalCreator();
            creator[2] = new LDownCreator();
            creator[3] = new ZetCreator();
            creator[4] = new ZetReverseCreator();
            creator[5] = new TriangleCreator();
            foreach (var item in creator)
            {
                //get the figure type and then with if set the color
                Figure figure = item.Creator();
                if (figure.Color == 1)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else if (figure.Color == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (figure.Color == 3)
                    Console.ForegroundColor = ConsoleColor.Blue;
                else if (figure.Color == 4)
                    Console.ForegroundColor = ConsoleColor.Cyan;
                else if (figure.Color == 5)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.White;

                /*put all values in the list for check, this allows to avoid 
                tostring override requirement*/
                var list = figure.Geometry;

                //counter to get into next line
                int count = 0;
                foreach (var number in list)
                {
                    if (number==1)
                        Console.Write("1 ");
                    else
                        Console.Write("  ");
                    ++count;
                    if (count == 4)
                    {
                        count = 0;
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
