using System.Linq.Expressions;
using GmTech.Domain.Album.Models;

namespace GmTech.Domain.Album.Interfaces;
public interface IRepositoryAlbum : IRepositoryBase<EAlbum> {
    Task<EAlbum> GetAsync(Guid id);
    Task<IEnumerable<EAlbum>> DoListAsync(Expression<Func<EAlbum, bool>>? param = null);
}