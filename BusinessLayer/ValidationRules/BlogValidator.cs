using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator: AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x=>x.BlogTitle).NotEmpty().WithMessage("Blog Başlığı Boş Geçilemez");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriği Boş Geçilemez");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Resimi Eklemeniz Gerekmektedir.");
            RuleFor(x => x.BlogContent).MaximumLength(150).WithMessage("Lütfen 150 Karakterden Daha Az Veri Girişi Yapınız");
            RuleFor(x => x.BlogContent).MinimumLength(5).WithMessage("Lütfen 4 Karakterden Daha Fazla Veri Girişi Yapınız");

        }
    }
}
