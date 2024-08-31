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
    public class BaseRepo<T> : IBaseGeneric<T> where T : Base
    {
        private readonly CompnyDBcontext _context;

        public BaseRepo(CompnyDBcontext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
