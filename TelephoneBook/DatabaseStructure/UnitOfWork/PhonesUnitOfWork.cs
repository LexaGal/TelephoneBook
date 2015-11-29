using System;
using System.Collections.Generic;
using System.Linq;
using TelephoneBook.DatabaseStructure.DbContext;
using TelephoneBook.DatabaseStructure.Repository;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook.DatabaseStructure.UnitOfWork
{
    public class PhonesUnitOfWork : IDisposable
    {
        private readonly Phones _phones;
        private bool _disposed;

        public PhonesUnitOfWork()
        {
            _phones = new Phones();
        }

        public Dictionary<Type, object> Repositories = new Dictionary<Type, object>();

        public IRepository<T> Repository<T>() where T : class
        {
            if (Repositories.Keys.Contains(typeof (T)))
            {
                return Repositories[typeof (T)] as IRepository<T>;
            }
            IRepository<T> repo = new Repository<T>(_phones);
            Repositories.Add(typeof(T), repo);
            return repo;
        }

        public void SaveChanges()
        {
            _phones.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _phones.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}