using GmTech.Domain.Album.Models;
using GmTech.Domain.Album.Interfaces;
using System.Linq.Expressions;

namespace GmTech.Domain.Album.Services;
public class ServiceImage : ServiceBase<EImage>, IServiceImage {
    private readonly IRepositoryImage _repos;

    public ServiceImage(IRepositoryImage repository) : base(repository) {
        _repos = repository;   
    }

    public async Task<IEnumerable<EImage>> DoListAsync(Expression<Func<EImage, bool>>? param = null)
        => await _repos.DoListAsync(param);

    public async Task<EImage> GetAsync(Guid id)
        => await _repos.GetAsync(id);
}