using System.Linq.Expressions;

namespace GmTech.Domain;
public interface IServiceBase<Model> where Model : class {
    Task AddAsync(Model model);
    Task UpdateAsync(Model model);
    Task RemoveAsync(Model model);    
    Task<Model> SingleAsync(Guid id);
    Task<IEnumerable<Model>> DoListSingleAsync(Expression<Func<Model, bool>>? param = null );
}