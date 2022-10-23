using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
        public interface IRepository<T> where T: class
        {
            T GetById(dynamic id);
            IEnumerable<T> List();
            void Add(T entity);
            void Delete(T entity);
            void Edit(T entity);


        }
}
