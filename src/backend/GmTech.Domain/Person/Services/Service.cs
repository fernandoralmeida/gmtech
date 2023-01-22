using GmTech.Domain.Person.Helpers;
using GmTech.Domain.Person.Models;
using GmTech.Domain.Person.Interfaces;
using System.Linq.Expressions;

namespace GmTech.Domain.Person.Services;

public class Service : ServiceBase<EPerson>, IService
{
    private readonly IRepository _reps;

    public Service(IRepository repository)
        : base(repository)
    {
        _reps = repository;
    }

    public async Task<IEnumerable<EPerson>> DoListAsync(Expression<Func<EPerson, bool>>? param = null)
        => await _reps.DoListAsync(param);

    public async Task<EPerson> GetAsync(Guid id)
        => await _reps.GetAsync(id);

    public override async Task<(bool, string msg)> AddAsync(EPerson model)
    {
        bool ret = false;
        var message = string.Empty;
        var validate = model.Validate();

        if (validate == (true, "ok"))
        {
            var p = await _reps.SingleAsync(model.Id);

            switch (p.PessoaExist(model))
            {
                case false:
                    await _reps.AddAsync(model);
                    ret = true;
                    message = "ok";
                    break;

                case true:
                    ret = false;
                    message = "exist";
                    break;
            }

            return (ret, message);
        }
        else
            return validate;
    }
}