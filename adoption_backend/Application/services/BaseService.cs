using Application.abstraction;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.services
{
  public  class BaseService<T> : IBaseService<T> where T : BaseEntity
  {
    private IBaseRepository<T> _baserepo;
    public BaseService(IBaseRepository<T> baseRepo)
    {
      _baserepo = baseRepo;
    }
    public async Task Add(T entity)
    {
      await _baserepo.Add(entity);
    }

    public async Task<bool> Delete(string id)
    {
      return await _baserepo.Delete(id);
    }

    public async Task<T> Get(string id)
    {
      return await _baserepo.Get(id);
    }

    public async Task<List<T>> GetAll(int startIndex, int count)
    {
      return await _baserepo.GetAll(startIndex,count);
    }

    public async Task<T> Update(T entity)
    {
      return await _baserepo.Update(entity);
    }
  }
}
