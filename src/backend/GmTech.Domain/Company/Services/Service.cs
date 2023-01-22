using System.Linq.Expressions;
using GmTech.Domain.Company.Interfaces;
using GmTech.Domain.Company.Models;
using GmTech.Domain.Company.Helpers;

namespace GmTech.Domain.Company.Services;

public class Service : ServiceBase<ECompany>, IService
{
    private readonly IRepository _repos;

    public Service(IRepository repos) : base(repos) {
        _repos = repos;
    }
    public async Task<IEnumerable<ECompany>> DoListAsync(Expression<Func<ECompany, bool>>? param = null)
        => await _repos.DoListAsync(param);

    public async Task<ECompany> GetAsync(Guid id)
        => await _repos.GetAsync(id);

    public sealed override async Task<(bool, string msg)> AddAsync(ECompany model) {
        if(model == null || string.IsNullOrEmpty(model.Document))
            return (false, "invalid!");

        if (model.Document.Validate()) {    
            await _repos.AddAsync(model);
            return (true, "ok");    
        }
        
        return (false, "invalid!");
    }
}