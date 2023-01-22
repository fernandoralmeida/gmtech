using System.Linq.Expressions;
using GmTech.Domain.Feeds.Interfaces;
using GmTech.Domain.Feeds.Models;
using GmTech.Domain.Profile.Interfaces;
using GmTech.Domain.Profile.Models;

namespace GmTech.Domain.Feeds.Services;
public class ServiceFeed : IServiceFeed {   
    private readonly IRepository _repos;
    public ServiceFeed(IRepository repository) {
        _repos = repository;
    }
    public async Task<IEnumerable<EProfile>> DoListAsync(Expression<Func<EProfile, bool>>? param = null) 
        => await _repos.DoListAsync(param);
}