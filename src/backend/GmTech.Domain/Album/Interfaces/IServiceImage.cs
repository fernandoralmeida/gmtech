using System.Linq.Expressions;
using GmTech.Domain.Album.Models;

namespace GmTech.Domain.Album.Interfaces;
public interface IServiceImage : IServiceBase<EImage> {
    Task<EImage> GetAsync(Guid id);
    Task<IEnumerable<EImage>> DoListAsync(Expression<Func<EImage, bool>>? param = null);    
}