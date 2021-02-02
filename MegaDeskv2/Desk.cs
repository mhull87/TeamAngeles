using System;

namespace MegaDeskAngeles
{
    public class Desk
    {
        public int width { get; set; }
        public int depth { get; set; }
        public int drawers { get; set; }
        public DesktopMaterial Material { get; set; }
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

        public int CalculateArea()
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
