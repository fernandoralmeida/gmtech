using System.Linq.Expressions;
using GmTech.Domain.Contact.Models;

namespace GmTech.Domain.Contact.Interfaces;
public interface IServiceFone : IServiceBase<EFone>
{
    Task<EFone> GetAsync(Guid id);
    Task<IEnumerable<EFone>> DoListAsync(Expression<Func<EFone, bool>>? param = null);
}