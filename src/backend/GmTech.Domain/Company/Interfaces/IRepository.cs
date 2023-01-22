using System.Linq.Expressions;
using GmTech.Domain.Company.Models;

namespace GmTech.Domain.Company.Interfaces;

public interface IRepository : IRepositoryBase<ECompany> {
    Task<ECompany> GetAsync(Guid id);
    Task<IEnumerable<ECompany>> DoListAsync(Expression<Func<ECompany, bool>>? param = null);
}