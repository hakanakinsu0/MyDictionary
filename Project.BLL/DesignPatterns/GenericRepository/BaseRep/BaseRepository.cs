using Project.BLL.DesignPatterns.GenericRepository.IntRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext _db;

        public BaseRepository()
        {
            _db = DbTool.DbInstance;
        }
        public void Add(T entity)
        {
            _db.Set<T>().Add(entity);
            Save();
        }

        private void Save()
        {
            _db.SaveChanges();
        }

        public int Count()
        {
            return _db.Set<T>().Count();

        }

        public void Delete(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = ENTITIES.Enums.DataStatus.Deleted;
            Save();
        }

        public void Destroy(T entity)
        {
            _db.Set<T>().Remove(entity);
            Save();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().FirstOrDefault(predicate);
        }

        public List<T> GetActives()
        {
            return Where(x=>x.Status != ENTITIES.Enums.DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public List<T> GetDeleted()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted);

        }

        public List<T> GetUpdateds()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Updated);

        }

        public void Update(T entity)
        {
            T orijinalEntity = GetById(entity.Id);
            entity.ModifiedDate = DateTime.Now;
            entity.Status = ENTITIES.Enums.DataStatus.Updated;

            _db.Entry(orijinalEntity).CurrentValues.SetValues(entity);
            Save();
        }

        public List<T> Where(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate).ToList();
        }
    }
}
