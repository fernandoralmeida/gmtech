using System.Linq.Expressions;
using GmTech.Domain.Profile.Models;

namespace GmTech.Domain.Profile.Interfaces;

public interface IService : IServiceBase<EProfile> {
    Task<EProfile> GetAsync(Guid id);
    Task<IEnumerable<EProfile>> DoListAsync(Expression<Func<EProfile, bool>>? param = null);
}