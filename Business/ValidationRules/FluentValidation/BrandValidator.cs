using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Name).MinimumLength(3).WithMessage("Marka adı 2 karakterden uzun olmalı.");
            RuleFor(b => b.Name).NotEmpty().WithMessage("Marka Adı boş olamaz");
        }
    }
}
