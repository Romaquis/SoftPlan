using Api.Application.Dtos;
using FluentValidation;

namespace Api.Application.ModelsValidation
{
    public class ProductValidator: AbstractValidator<ProductModel>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("O preenchimento da descrição é obrigatório")
                .MaximumLength(50).WithMessage("O tamanho máximo da descrição é de 50 caracteres");
            RuleFor(x => x.Price)
                .GreaterThan(0)
                .WithMessage("O preenchimento do preço de custo é obrigatório");
            RuleFor(x => x.CategoryId)
                .GreaterThan(0)
                .WithMessage("O preenchimento da categoria é obrigatório");
        }

    }
}
