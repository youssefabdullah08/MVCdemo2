using Compny.Data.Entites;
using Compny.Repos.InterFaces;
using Compny.Serveses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compny.Serveses.Serveses
{
    public class Deprtmentserves : IDeprtmentServes
    {
        private readonly IDept dept;

        public Deprtmentserves(IDept dept)
        {
            this.dept = dept;
        }
        public void Add(Dept entity)
        {
            dept.Add(entity);
        }

        public void Delete(Dept entity)
        {
            dept.Delete(entity);
        }

        public IEnumerable<Dept> GetAll()
        {
            return dept.GetAll();
        }

        public Dept GetById(int id)
        {
            if (id != null)
            {
                return dept.GetById(id);
            }
            return null;
        }

        public void Update(Dept entity)
        {
            dept.Update(entity);
        }
    }
}
