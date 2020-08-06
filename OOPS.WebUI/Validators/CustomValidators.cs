using FluentValidation;

namespace OOPS.WebUI.Validators
{
    public static class CustomValidators
    {
        public static IRuleBuilderOptions<T, TElement> PhoneNumber<T, TElement>(this IRuleBuilder<T, TElement> ruleBuilder)
        {
            return ruleBuilder.Must(x => x is string && System.Text.RegularExpressions.Regex.IsMatch(x.ToString(), @"^\d{3}-\d{3}-\d{4}$"))
                .WithMessage("Telefon numarası geçersiz");
        }
    }
}
