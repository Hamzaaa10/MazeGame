using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    public interface Imazeobject
    {
        char Icon { get;  }
        bool Solid { get;  }
    }
}
