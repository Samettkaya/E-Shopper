using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class DistrictValidator : AbstractValidator<District>
    {
        public DistrictValidator()
        {
        }
    }
}
