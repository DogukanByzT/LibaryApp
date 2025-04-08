using FluentValidation;
using LibraryApp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Application.Validators;

public class BookValidator : AbstractValidator<BookDto>
{
    public BookValidator() 
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Kitap Adı Boş Olamaz");
        RuleFor(x => x.PageSize).NotEmpty().WithMessage("Sayfa Sayısı Boş Olamaz");
        RuleFor(x => x.ISBN).NotEmpty().WithMessage("ISBN Numarası Boş Olamaz");
    }
}
