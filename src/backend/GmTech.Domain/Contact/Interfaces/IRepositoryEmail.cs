using System.Linq.Expressions;
using GmTech.Domain.Contact.Models;

namespace GmTech.Domain.Contact.Interfaces;
public interface IRepositoryEmail : IRepositoryBase<EEmail>
{
    Task<EEmail> GetAsync(Guid id);
    Task<IEnumerable<EEmail>> DoListAsync(Expression<Func<EEmail, bool>>? param = null);
}