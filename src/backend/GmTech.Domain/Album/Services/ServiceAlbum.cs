using GmTech.Domain.Album.Models;
using GmTech.Domain.Album.Interfaces;
using System.Linq.Expressions;

namespace GmTech.Domain.Album.Services;
public class ServiceAlbum : ServiceBase<EAlbum>, IServiceAlbum {
    private readonly IRepositoryAlbum _repos;
    public ServiceAlbum(IRepositoryAlbum repository)
        :base(repository) {
            _repos = repository;
        }

    public async Task<IEnumerable<EAlbum>> DoListAsync(Expression<Func<EAlbum, bool>>? param = null)
        => await _repos.DoListAsync(param);

    public async Task<EAlbum> GetAsync(Guid id)
        => await _repos.GetAsync(id);
}