using System.Globalization;
using eventAppAPI.Application.ViewModels.Events;
using FluentValidation;

namespace eventAppAPI.Application.Validators.Events;

public class CreateEventValidator : AbstractValidator<VM_Create_Event>
{
    public CreateEventValidator()
    {
        RuleFor(e => e.BrideName)
            .NotEmpty()
            .NotNull()
            .WithMessage(x => ValidatorOptions.Global.LanguageManager.GetString("Bride Name not empty.", new CultureInfo("tr-TR")));

        RuleFor(e => e.GroomName)
            .NotEmpty()
            .NotNull()
            .WithMessage("Boş birakilamaz.");
        RuleFor(e => e.eventDate)
            .NotEmpty()
            .NotNull()
            .WithMessage("Boş birakilamaz.");
        RuleFor(e => e.EventType).NotNull().WithMessage("Boş birakilamaz.");
        RuleFor(e => e.Phone).NotEmpty().NotNull().WithMessage("Telefon numarası boş birakılamaz.");
        RuleFor(e => e.HostedNameSurname).NotEmpty().NotNull().WithMessage("Boş birakilamaz.");


    }
}