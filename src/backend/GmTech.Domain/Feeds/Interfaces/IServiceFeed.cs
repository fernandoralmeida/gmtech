using System.Linq.Expressions;
using GmTech.Domain.Feeds.Models;
using GmTech.Domain.Profile.Models;

namespace GmTech.Domain.Feeds.Interfaces;
public interface IServiceFeed {
    Task<IEnumerable<EProfile>> DoListAsync(Expression<Func<EProfile, bool>>? param = null);
}