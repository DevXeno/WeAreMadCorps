using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreMadCorps.Dashboard
{
    public class DashSquare
    {
        public string IconImage { get; set; }

        public string BackgroundImage { get; set; }

        public string Text { get; set; }

        public int Column { get; set; }

        public int Row { get; set; }

        public Type NavigateType { get; set; }

        public bool EphemeralPage { get; set; }
    }
}
