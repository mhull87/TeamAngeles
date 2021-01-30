using System;

namespace MegaDeskAngeles
{
    public class Desk
    {
        public int width;
        public int depth;
        public int drawers;
        public DesktopMaterial Material;
        public int area;

        //Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        public Desk()
        {
            width = 0;
            depth = 0;
            drawers = 0;
            Material = 0;
        }

        public int calculateArea()
        {
            area = width * depth;
            return area;
        }
    }

    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
