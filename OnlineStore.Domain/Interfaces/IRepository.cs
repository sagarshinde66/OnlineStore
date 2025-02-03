using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        T Add(T entity);
        T Update(T entity);
        T Delete(int id);
    }
}
