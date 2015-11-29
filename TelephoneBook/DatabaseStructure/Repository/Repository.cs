using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TelephoneBook.DatabaseStructure.DbContext;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook.DatabaseStructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Phones Context { get; set; }

        public Repository(Phones context)
        {
            Context = context;
        }

        public virtual List<T> GetAll(Func<T, bool> func = null)
        {
            if (func != null)
            {
                return Context.Set<T>().Where(func).ToList();
            }
            return Context.Set<T>().ToList();
        }

        public virtual T Get(Guid id)
        {
            return Context.Set<T>().Find(id);
        }

        public virtual bool Save(T value, Guid id)
        {
            if (Context.Set<T>().Find(id) == null)
            {
                Context.Entry(value).State = EntityState.Added;
                return true;
            }
            return Edit(value);
        }

        public bool Edit(T value)
        {
            Context.Entry(value).State = EntityState.Modified;
            return true;
        }

        public virtual bool Delete(Guid id)
        {
            T t = Context.Set<T>().Find(id);
            if (t != null)
            {
                Context.Set<T>().Remove(t);
                return true;
            }
            return false;
        }

        public virtual void Dispose()
        {
            Context?.Dispose();
        }
    }
}