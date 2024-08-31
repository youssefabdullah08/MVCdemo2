using Compny.Data.Contexts;
using Compny.Data.Entites;
using Compny.Repos.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compny.Repos.Repos
{
    internal class EmpRepo : BaseRepo<Emp>, IEmp
    {
        private readonly CompnyDBcontext context;

        public EmpRepo(CompnyDBcontext context) : base(context)
        {
            this.context = context;
        }

        public Emp GetEmpByName(string name)
        {
            var x = context.Emps.FirstOrDefault(x => x.name == name);
            return x;
        }
    }
}
