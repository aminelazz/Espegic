using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e.Validators
{
    public class ModuleValidator : AbstractValidator<MODULE>
    {
        public ModuleValidator()
        {
            // Validate module name
            RuleFor(f => f.NAME)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Le nom du module est vide")
                .Length(3, 50).WithMessage("Le nom du module plus petit ou grand")
                .Must(BeValideModuleName).WithMessage("La forme du nom du module incorrect");
        }

        //
        // Valide module name
        //
        protected bool BeValideModuleName(string name)
        {
            var replace = name.Replace(" ", "");
            return replace.All(char.IsLetterOrDigit) ? true : false;
        }
    }
}
