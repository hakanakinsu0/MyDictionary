using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Destroy(T entity);

        T GetById(int id);  
        List<T> GetAll();
        List<T> Where(Expression<Func<T, bool>> predicate);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);

        List<T> GetActives(); // Aktif olan veriler
        List<T> GetUpdateds(); // Güncellenmiş veriler
        List<T> GetDeleted(); // Silinmiş (soft deleted) veriler
        int Count();

    }
}
