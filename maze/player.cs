using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    internal class player : Imazeobject
    {
        public int x {  get; set; } 
        public int y { get; set; }
        public char Icon { get => '@'; }
        public bool Solid { get => true ; }
    }
}
