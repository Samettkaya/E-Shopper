using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class SubCategoryValidator : AbstractValidator<Category>
    {
        public SubCategoryValidator()
        {
        }
    }
}
