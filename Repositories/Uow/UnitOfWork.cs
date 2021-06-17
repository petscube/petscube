//using Infrastructure;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace Repositories.Uow
//{
//  public class UnitOfWork : IUnitOfWork
//  {
//    private AppDbContext _dbContext;
//    public UnitOfWork(AppDbContext context)
//    {
//      _dbContext = context;
//    }
//    public async Task<int> CommitAsync()
//    {
//      return await _dbContext.SaveChangesAsync();
//    }
//  }
//}
