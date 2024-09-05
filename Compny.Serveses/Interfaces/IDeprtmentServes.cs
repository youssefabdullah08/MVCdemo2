using Compny.Data.Entites;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compny.Serveses.Interfaces
{
    public interface IDeprtmentServes
    {
        Dept GetById(int id);
        IEnumerable<Dept> GetAll();
        void Add(Dept entity);
        void Update(Dept entity);
        void Delete(Dept entity);
    }
}
