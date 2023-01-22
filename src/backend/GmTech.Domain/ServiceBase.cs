using System.Linq.Expressions;

namespace GmTech.Domain;
public class ServiceBase<Model> : IServiceBase<Model> where Model : class {
    private readonly IRepositoryBase<Model> _reps;

    public ServiceBase(IRepositoryBase<Model> repository){
        _reps = repository;
    }

    public virtual async Task AddAsync(Model model)
        => await _reps.AddAsync(model);

    public async Task<IEnumerable<Model>> DoListSingleAsync(Expression<Func<Model, bool>>? param = null)
        => await _reps.DoListSingleAsync(param);

    public async Task RemoveAsync(Model model)
        => await _reps.RemoveAsync(model);

    public async Task<Model> SingleAsync(Guid id)
        => await _reps.SingleAsync(id);

    public async Task UpdateAsync(Model model)
        => await _reps.UpdateAsync(model);
}