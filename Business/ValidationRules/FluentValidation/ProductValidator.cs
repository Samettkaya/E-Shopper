using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(b => b.BrandId).NotEmpty().WithMessage("Marka Adı boş olamaz");
            RuleFor(b => b.CategoryId).NotEmpty().WithMessage("Kategori Adı boş olamaz");
            RuleFor(b => b.Name).NotEmpty().WithMessage("Ürün Adı boş olamaz");
            RuleFor(b => b.Price).NotEmpty().WithMessage("Ürün fiyatı boş olamaz");

        }
    }

    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(b => b.CityId).NotEmpty().WithMessage("İl alanı boş bırakılamaz");
            RuleFor(b => b.AddressDetail).NotEmpty().WithMessage("Adres alanı boş olamaz");
          


        }
    }
}
