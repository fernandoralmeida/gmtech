using System.Linq.Expressions;
using GmTech.Domain.Address.Models;

namespace GmTech.Domain.Address.Interfaces;
public interface IRepository : IRepositoryBase<EAddress>
{
    Task<EAddress> GetAsync(Guid id);
    Task<IEnumerable<EAddress>> DoListAsync(Expression<Func<EAddress, bool>>? param = null);
}