namespace MegaDeskRazor.Models
{
 //   public enum DesktopMaterial
 //   {
 //       Oak,
 //       Laminate,
 //       Pine,
 //       Rosewood,
 //       Veneer
//    }

    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public DesktopMaterial Material { get; set; }
        public int area;

        //Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        public Desk()
        {
            Width = 0;
            Depth = 0;
            Drawers = 0;
            Material = 0;
        }

        public int CalculateArea()
        {
            area = Width * Depth;
            return area;
        }
    }
}