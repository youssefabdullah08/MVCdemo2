using Compny.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compny.Repos.InterFaces
{
    public interface IDept : IBaseGeneric<Dept>
    {
        Dept GetDeptByName(string name);
    }
}
