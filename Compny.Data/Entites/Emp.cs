using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compny.Data.Entites
{
    public class Emp : Base
    {
        public Dept Dept { get; set; }
    }
}
