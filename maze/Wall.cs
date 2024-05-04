using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    internal class Wall : Imazeobject
    {
        public char Icon { get => '#'; }
        public bool Solid { get => true; }
    }
}
