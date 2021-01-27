using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Wicker
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public int Drawers { get; set; }
        public DesktopMaterial Material { get; set; }
        public int ProductionDays { get; set; }
        public int Area { get; set; }
        public int Price { get; set; }

        //Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;

    }

    public enum DesktopMaterial {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
