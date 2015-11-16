using System;
using System.Collections.Generic;
using System.Linq;

namespace TelephoneBook.DatabaseStructure.Repository
{
    public abstract class Repository<T>: IRepository<T> where T: class
    {
        public Phones Context { get; set; }

        public virtual List<T> GetAll(Func<T, bool> func = null)
        {
            //using (Context = new Phones())
            //{
                if (func != null)
                {
                    return Context.Set<T>().Where(func).ToList();
                }
                return Context.Set<T>().ToList();
            //}
        }

        public virtual T Get(Guid id)
        {
            //using (Context = new Phones())
            //{
                return Context.Set<T>().Find(id);
            //}
        }

        public virtual bool Save(T value, Guid id)
        {
            //using (Context = new Phones())
            //{
                if (Context.Set<T>().Find(id) == null)
                {
                    Context.Set<T>().Add(value);
                    Context.SaveChanges();
                    return true;
                }
                return Edit(value);
            //}
        }
        
        public abstract bool Edit(T value);
       
        public virtual bool Delete(Guid id)
        {
            //using (Context = new Phones())
            //{
                T t = Context.Set<T>().Find(id);
                if (t != null)
                {
                    Context.Set<T>().Remove(t);
                    Context.SaveChanges();
                    return true;
                }
                return false;
           //}
        }

        public virtual void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
        }
    }
}