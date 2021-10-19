using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(b => b.Name).MinimumLength(3).WithMessage("Kategori adı 2 karakterden uzun olmalı.");
            RuleFor(b => b.Name).NotEmpty().WithMessage("Kategori Adı boş olamaz");
        }
    }
}
