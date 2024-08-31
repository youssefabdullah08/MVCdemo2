using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compny.Data.Entites
{
    public class Base
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime createAt { get; set; }
        public DateTime updateAt { get; set; }

        public bool IsDeleted { get; set; }
    }
}
