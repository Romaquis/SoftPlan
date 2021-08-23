using Api.Application.Dtos;
using FluentValidation;

namespace Api.Application.ModelsValidator
{
    public class CategoryValitador : AbstractValidator<CategoryModel>
    {
        public CategoryValitador()
        {
            RuleFor(c => c.Title)
                .NotEmpty().WithMessage("O preenchimento do nome é obrigatório")
                .MaximumLength(50).WithMessage("O tamanho máximo o nome é de 50 caracteres");
        }
    }
}
