using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compny.Data.Entites
{
    public class Dept : Base
    {
        public IEnumerable<Emp> Emps { get; set; } = new List<Emp>();
    }
}
