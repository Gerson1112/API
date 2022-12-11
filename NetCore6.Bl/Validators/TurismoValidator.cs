using FluentValidation;
using NetCore6.Bl.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore6.Bl.Validators
{
    public class TurismoValidator : AbstractValidator<TurismoDTO>
    {
        public TurismoValidator()
        {
            RuleFor(x => x.Destino)
                .NotEmpty()
                .NotNull()
                .WithMessage("Destino is required");
            RuleFor(x => x.Descripcion)
                .NotEmpty()
                .NotNull()
                .WithMessage("Descripcion is required");
            RuleFor(x => x.Region)
                .NotEmpty()
                .NotNull()
                .WithMessage("Region is required");
            RuleFor(x => x.Foto)
                .NotEmpty()
                .NotNull()
                .WithMessage("Foto is required");
        }
    }
}
