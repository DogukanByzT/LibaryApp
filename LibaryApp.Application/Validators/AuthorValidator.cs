using FluentValidation;
using LibraryApp.Application.Dtos.AuthorDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Application.Validators
{
    public class AuthorValidator : AbstractValidator<AuthorDto>
    {
        public AuthorValidator() {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar Adı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Yazar Soyadı Boş Geçilemez");
        }
    }
}
