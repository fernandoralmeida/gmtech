using System.Linq.Expressions;
using GmTech.Domain.Album.Models;

namespace GmTech.Domain.Album.Interfaces;
public interface IRepositoryImage : IRepositoryBase<EImage> {
    Task<EImage> GetAsync(Guid id);
    Task<IEnumerable<EImage>> DoListAsync(Expression<Func<EImage, bool>>? param = null);
}