using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreMadCorps.Pages.LeStaff
{
    public class StaffMember
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string NameToUpper { get { return Name.ToUpper(); } }
    }
}
