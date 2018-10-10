using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP
{
    public class Figures
    {
        //Figure abstract class has the fields that every shape should override
        public abstract class Figure
        {
            public int[,] Geometry;
            public byte Color;
            public string FigureName;
        }
        public class Triangle : Figure
        {
            public Triangle()
            {
                Geometry = new int[4, 4] { { 0, 0, 1, 0 }, { 0, 1, 1, 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
                Color = 1;
                FigureName = "Triangle";
            }
        }
        public class Zet : Figure
        {
            public Zet()
            {
                Geometry = new int[4, 4] { { 0, 1, 1, 0 }, { 0, 0, 1, 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
                Color = 2;
                FigureName = "Zet";
            }
        }
        public class ZetReverse : Figure
        {
            public ZetReverse()
            {
                Geometry = new int[4, 4] { { 0, 1, 1, 0 }, { 1, 1, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
                Color = 3;
                FigureName = "Reverse Zet";
            }
        }
        public class LUp : Figure
        {
            public LUp()
            {
                Geometry = new int[4, 4] { { 0, 1, 1, 1 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
                Color = 4;
                FigureName = "L Up";
            }
        }
        public class LDown : Figure
        {
            public LDown()
            {
                Geometry = new int[4, 4] { { 1, 0, 0, 0 }, { 1, 1, 1, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
                Color = 5;
                FigureName = "L Down";
            }
        }
        public class Vertical : Figure
        {
            public Vertical()
            {
                Geometry = new int[4, 4] { { 1, 0, 0, 0 }, { 1, 0, 0, 0 }, { 1, 0, 0, 0 }, { 1, 0, 0, 0 } };
                Color = 6;
                FigureName = "Vertical";
            }
        }
    }
}
