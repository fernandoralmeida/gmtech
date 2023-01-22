using GmTech.Domain.Contact.Models;
using GmTech.Domain.Contact.Interfaces;
using System.Linq.Expressions;

namespace GmTech.Domain.Contact.Services;

public class ServiceFone : ServiceBase<EFone>, IServiceFone
{
    private readonly IRepositoryFone _reps;

    public ServiceFone(IRepositoryFone repository)
        : base(repository) {
            _reps = repository;
        }

    public async Task<IEnumerable<EFone>> DoListAsync(Expression<Func<EFone, bool>>? param = null)
        => await _reps.DoListAsync(param);

    public async Task<EFone> GetAsync(Guid id)
        => await _reps.GetAsync(id);
}