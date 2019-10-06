using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_BekahHowe
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }


        //Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;

        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
    }
    enum SurfaceMaterial { oak, laminate, pine, rosewood, veneer };
}
