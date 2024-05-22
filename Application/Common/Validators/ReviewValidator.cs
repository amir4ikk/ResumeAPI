using Domain.Entities;
using FluentValidation;

namespace Application.Common.Validators;
public class ReviewValidator : AbstractValidator<Review>
{
    public ReviewValidator()
    {
        RuleFor(x => x.NeedWorkingExperience)
            .NotEmpty()
            .WithMessage("Sorov Bosh Bolmasligi Lozim");
        RuleFor(x => x.NeedEducation)
            .NotEmpty()
            .WithMessage("Sorov Bosh Bolmasligi Lozim");
        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage("Qandaydir Qoshimcha Malumot Berishingiz Lozim")
            .MinimumLength(10)
            .WithMessage("10 dona beldigan uzunroq bo'lishi lozim");
        RuleFor(x => x.NeedProgrammingLanguages)
            .NotEmpty()
            .WithMessage("Zavod Ishchilarini Ishga Olmoqchimisiz?");
        RuleFor(x => x.NeedLanguages)
            .NotEmpty()
            .WithMessage("Soqov Yo Karmisiz?");

        RuleFor(x => x.UserId)
            .NotEmpty()
            .WithMessage("E'lonni Kim Qo'yganligini Bilishimiz Lozim");
    }
}
