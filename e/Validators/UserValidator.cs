using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e.Validators
{
    public class UserValidator : AbstractValidator<USER>
    {
        public UserValidator()
        {
            // Validate cin
            RuleFor(u => u.CIN)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Le numero de cin est vide")
                .Length(5, 10).WithMessage("Le numero de cin plut petit ou grand")
                .Must(BeValideCin).WithMessage("La form du cin incorrect");

            // Validate first name
            RuleFor(u => u.F_NAME)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Le prenom est vide")
                .Length(3, 15).WithMessage("Le prenom plus petit ou grand")
                .Must(BeValideName).WithMessage("La form du prenom incorrect");

            // Validate last name
            RuleFor(u => u.L_NAME)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Le nom est vide")
                .Length(3, 15).WithMessage("Le nom plus petit ou grand")
                .Must(BeValideName).WithMessage("La form du nom incorrect");

            // Validate phone
            RuleFor(u => u.PHONE)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Le téléphone est vide")
                .Length(10).WithMessage("La forme du téléphone incorrect")
                .Must(BeValidePhone).WithMessage("La forme du téléphone incorrect");

            // Validate email
            RuleFor(u => u.EMAIL)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("L'email est vide")
                .EmailAddress().WithMessage("L'email incorrect");

            // Validate password
            RuleFor(u => u.PASSWORD)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Le mot de passe est vide")
                .Length(5, 10).WithMessage("Le mot de passe plus petit ou grand");
        }

        //
        // Valide cin
        //
        protected bool BeValideCin(string cin)
        {
            var l1 = cin.Substring(0,1);
            var l2 = cin.Substring(1,2);
            var n = cin.Substring(2);
            return l1.All(char.IsLetter) && l2.All(char.IsLetterOrDigit) && n.All(char.IsDigit) ? true : false;
        }

        //
        // Valide name
        //
        protected bool BeValideName(string name)
        {
            var replace = name.Replace(" ", "");
            return replace.All(char.IsLetter) ? true : false;
        }

        //
        // Valide phone
        //
        protected bool BeValidePhone(string phone)
        {
            return phone.All(char.IsDigit) ? true : false;
        }
    }
}
