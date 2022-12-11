using AutoMapper;
using FluentValidation;
using NetCore6.Bl.DTOs;
using NetCore6.Model.Entities;
using NetCore6.Model.Repositories;

namespace NetCore6.Services.Services
{
    public interface ITurismoService : IBaseService<Turismo, TurismoDTO> { }

    public class TurismoService : BaseService<Turismo, TurismoDTO>, ITurismoService
    {
        public TurismoService(
            ITurismoRepository repository,
            IMapper mapper,
            IValidator<TurismoDTO> validator) : base(repository, mapper, validator) { }
    }
}