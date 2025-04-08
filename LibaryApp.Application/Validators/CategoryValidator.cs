using FluentValidation;
using LibraryApp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Application.Validators
{
    public class CategoryValidator : AbstractValidator<CategoryDto>
    {
        public CategoryValidator() {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adı boş geçilemez");
        }
    }
}
