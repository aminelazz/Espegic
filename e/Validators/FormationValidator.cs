using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e.Validators
{
    public class FormationValidator : AbstractValidator<FORMATION>
    {
        public FormationValidator()
        {
            // Validate formation name
            RuleFor(f => f.NAME)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Le nom de la formation est vide")
                .Length(3, 100).WithMessage("Le nom de la formation plus petit ou grand")
                .Must(BeValideFormationName).WithMessage("La forme du nom de la formation incorrect");

            // Validate formation duration
            RuleFor(f => f.DURATION.ToString())
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("La durée de la formation est vide")
                .Length(1,2).WithMessage("La forme de la durée de la formation incorrect")
                .Must(BeValideNumber).WithMessage("La forme du téléphone incorrect");

            // Validate formation price
            RuleFor(p => p.PRICE)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Le prix est vide")
                .Length(3, 5).WithMessage("Le prix plus petit ou grand")
                .Must(BeValideNumber).WithMessage("La forme du prix incorrect");
        }

        //
        // Valide formation name
        //
        protected bool BeValideFormationName(string name)
        {
            var replace = name.Replace(" ", "");
            return replace.All(char.IsLetterOrDigit) ? true : false;
        }

        //
        // Valide duration & price
        //
        protected bool BeValideNumber(string duration)
        {
            return duration.All(char.IsDigit) ? true : false;
        }
    }
}
