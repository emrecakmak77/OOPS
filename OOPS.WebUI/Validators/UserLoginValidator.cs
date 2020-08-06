using FluentValidation;
using FluentValidation.Validators;
using OOPS.WebUI.Models;

namespace OOPS.WebUI.Validators
{
    public class UserLoginValidator : AbstractValidator<UserLoginViewModel>
    {
        public UserLoginValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress(EmailValidationMode.AspNetCoreCompatible)
                .WithMessage("E-Mail Adresi Geçersiz")
                .NotNull().WithMessage("E-Mail Alanı Boş Olamaz");
            RuleFor(x => x.Password).NotNull().WithMessage("Şifre Alanı Boş Olamaz");
        }
    }
}
