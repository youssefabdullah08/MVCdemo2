using Compny.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compny.Repos.InterFaces
{
    public interface IEmp : IBaseGeneric<Emp>
    {
        Emp GetEmpByName(string name);
    }
}
