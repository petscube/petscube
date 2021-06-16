using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.services
{
  public interface IBaseService<T> where T : BaseEntity
  {
    Task<List<T>> GetAll(int startIndex, int count);
    Task<T> Get(string id);
    Task Add(T entity);
    Task<T> Update(T entity);
    Task<bool> Delete(string id);
  }
}
