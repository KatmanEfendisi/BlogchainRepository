using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("E-mail adresi boş geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre kısmı boş geçilemez.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter yazınız.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter yazınız.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkında boş geçilemez.");
        }
    }
}