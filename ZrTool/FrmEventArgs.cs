using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZrTool
{
    public class FrmEventArgs : EventArgs
    {
        public int Temp { get; set; }

        public object Obj { get; set; }

        public string Name { get; set; }
    }
}
