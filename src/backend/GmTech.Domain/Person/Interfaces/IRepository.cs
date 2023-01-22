using System.Linq.Expressions;
using GmTech.Domain.Person.Models;

namespace GmTech.Domain.Person.Interfaces;
public interface IRepository : IRepositoryBase<EPerson> {
    Task<EPerson> GetAsync(Guid id);
    Task<IEnumerable<EPerson>> DoListAsync(Expression<Func<EPerson, bool>>? param = null);
}