using Compny.Data.Contexts;
using Compny.Repos.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compny.Serveses.Serveses
{
    public class UOW
    {
        private readonly CompnyDBcontext context;

        public UOW(CompnyDBcontext context)
        {
            this.context = context;
        }
        public IEmp Emp { get; set; }
        public IDept Dept { get; set; }


        public void Complte()
        {
            context.SaveChanges();
        }
    }
}
