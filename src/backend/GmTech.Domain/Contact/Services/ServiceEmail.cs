using GmTech.Domain.Contact.Models;
using GmTech.Domain.Contact.Interfaces;
using System.Linq.Expressions;

namespace GmTech.Domain.Contact.Services;

public class ServiceEmail : ServiceBase<EEmail>, IServiceEmail
{
    private readonly IRepositoryEmail _reps;

    public ServiceEmail(IRepositoryEmail repository)
        : base(repository) {
            _reps = repository;
        }

    public async Task<IEnumerable<EEmail>> DoListAsync(Expression<Func<EEmail, bool>>? param = null)
        => await _reps.DoListAsync(param);

    public async Task<EEmail> GetAsync(Guid id)
        => await _reps.GetAsync(id);
}