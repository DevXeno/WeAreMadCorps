using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreMadCorps.Dashboard
{
    public class WidgetTappedEventArgs : EventArgs
    {
        private Type _page;
        public Type Page
        {
            get { return _page; }
        }

        public WidgetTappedEventArgs(Type page)
        {
            _page = page;
        }
    }
}
