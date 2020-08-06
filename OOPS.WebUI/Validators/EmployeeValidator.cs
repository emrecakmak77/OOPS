using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Validators;
using OOPS.DTO.Employee;
using OOPS.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Validators
{
    public class EmployeeValidator : AbstractValidator<EmployeeDTO>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("İsim Alanı Boş Olamaz").MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Surname).NotNull().WithMessage("Soyisim Alanı Boş Olamaz").MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.EmailBusiness).NotNull().WithMessage("E-Mail Alanı Boş Olamaz");
            RuleFor(x => x.EmailBusiness).EmailAddress(EmailValidationMode.AspNetCoreCompatible).WithMessage("E-Mail Formatı Doğru Değil");
            RuleFor(x => x.Title).NotNull().WithMessage("Ünvan Alanı Boş Olamaz").MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.PhoneBusiness).NotNull().WithMessage("Telefon(iş) Alanı Boş Olamaz").MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.PhonePersonal).NotNull().WithMessage("Telefon(Kişisel) Alanı Boş Olamaz").MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.ContractTypeID).NotNull().WithMessage("Sözleşme Türü Alanı Boş Olamaz");
            RuleFor(x => x.AccessTypeID).NotNull().WithMessage("Erişim Türü Alanı Boş Olamaz");
            RuleFor(x => x.StartDate).NotNull().WithMessage("İşe Başlama Tarihi Boş Olamaz");
            RuleFor(x => x.ContractEndDate).NotNull().WithMessage("Sözleşme Bitiş Tarihi Boş Olamaz");
        }
    }
}
