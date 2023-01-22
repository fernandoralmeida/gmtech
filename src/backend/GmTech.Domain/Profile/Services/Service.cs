using System.Linq.Expressions;
using GmTech.Domain.Profile.Interfaces;
using GmTech.Domain.Profile.Models;

namespace GmTech.Domain.Profile.Services;

public class Service : ServiceBase<EProfile>, IService {

    private readonly IRepository _repos;
    public Service(IRepository repository) : base(repository)
    {
        _repos = repository;
    }
    public async Task<IEnumerable<EProfile>> DoListAsync(Expression<Func<EProfile, bool>>? param = null)
        => await _repos.DoListAsync(param);

    public async Task<EProfile> GetAsync(Guid id)
        => await _repos.GetAsync(id);
}