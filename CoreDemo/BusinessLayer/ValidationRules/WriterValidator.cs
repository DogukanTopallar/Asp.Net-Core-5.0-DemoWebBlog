using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar e-mail adresi boş geçilemez!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar şifresi boş geçilemez!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az iki karakter giriniz!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla elli karakter giriniz!");

        }
    }
}
