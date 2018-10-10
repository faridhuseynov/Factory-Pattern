using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Factory_DP.Figures;

namespace Factory_DP
{
    public class FactoryMethod
    {
        //interface for factory method responsible for creation of the figures
        public interface IFigureCreator
        {
            Figure Creator();
        }

        //virtual constructors created with return type being common interface Figure
        public class TriangleCreator : IFigureCreator
        {
            public Figure Creator()
            {
                Figure figure = new Triangle();
                return figure;
            }
        }
        public class ZetCreator : IFigureCreator
        {
            public Figure Creator()
            {
                Figure figure = new Zet();
                return figure;
            }
        }
        public class ZetReverseCreator : IFigureCreator
        {
            public Figure Creator()
            {
                Figure figure = new ZetReverse
    ();
                return figure;
            }
        }
        public class LUpCreator : IFigureCreator
        {
            public Figure Creator()
            {
                Figure figure = new LUp
    ();
                return figure;
            }
        }
        public class LDownCreator : IFigureCreator
        {
            public Figure Creator()
            {
                Figure figure = new LDown();
                return figure;
            }
        }
        public class VerticalCreator : IFigureCreator
        {
            public Figure Creator()
            {
                Figure figure = new Vertical();
                return figure;
            }
        }
    }
}
