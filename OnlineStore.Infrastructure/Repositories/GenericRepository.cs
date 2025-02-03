using OnlineStore.Domain.Entites;
using OnlineStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Infrastructure.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly List<T> _items = new();

        public GenericRepository()
        {
            if (typeof(T) == typeof(User))
            {
                _items.AddRange(new List<T>
                {
                    (T)(object)new User { Id = 1, Name = "abc", Email = "abc@gmail.com" },
                    (T)(object)new User { Id = 2, Name = "xyz", Email = "xyz@gmail.com" }
                });
            }
        }

        public List<T> GetAll() => _items.ToList();

        public T Add(T entity)
        {
            _items.Add(entity);
            return entity;
        }

        public T Delete(int id)
        {
            throw new NotImplementedException();
        }

 

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
