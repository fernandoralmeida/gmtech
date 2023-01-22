using GmTech.Domain.Address.Models;
using GmTech.Domain.Address.Interfaces;
using System.Linq.Expressions;

namespace GmTech.Domain.Address.Services;

public class Service : ServiceBase<EAddress>, IService
{
    private readonly IRepository _reps;

    public Service(IRepository repository)
        : base(repository)
    {
        _reps = repository;
    }

    public async Task<IEnumerable<EAddress>> DoListAsync(Expression<Func<EAddress, bool>>? param = null)
        => await _reps.DoListAsync(param);

    public async Task<EAddress> GetAsync(Guid id)
        => await _reps.GetAsync(id);
}