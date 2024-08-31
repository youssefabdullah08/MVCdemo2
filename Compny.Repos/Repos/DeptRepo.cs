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
    public class DeptRepo : BaseRepo<Dept>, IDept
    {
        private readonly CompnyDBcontext context;

        public DeptRepo(CompnyDBcontext context) : base(context)
        {
            this.context = context;
        }
        public Dept GetDeptByName(string name)
        {
            var x = context.Depts.FirstOrDefault(x => x.name == name);
            return x;
        }
    }
}
