using Domain.Entities;
using FluentValidation;

namespace Application.Common.Validators;
public class ResumeValidator : AbstractValidator<Resume>
{
    public ResumeValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name bosh bolmasligi kerak")
            .Length(3, 40)
            .WithMessage("Name 3 va 40 belgi orasida bolishi kerak");
        RuleFor(x => x.Contact)
            .NotEmpty()
            .WithMessage("Ulanish Uchun Malumot Kerak");
        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage("Qandaydir Qoshimcha Malumot Berishingiz Lozim")
            .MinimumLength(10)
            .WithMessage("10 dona beldigan uzunroq bo'lishi lozim");
        RuleFor(x => x.Location)
            .NotEmpty()
            .WithMessage("Yashash Manzili Bo'lishi Lozim");
        RuleFor(x => x.Languages)
            .NotEmpty()
            .WithMessage("So'qovmisiz?");

        RuleFor(x => x.UserId)
            .NotEmpty()
            .WithMessage("Kim Tomonidan Yozilganligini Bilishimiz Lozim Iltimos Malumot Kiriting");
    }
}
