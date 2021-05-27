using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e.Validators
{
    public class StudentValidator : AbstractValidator<STUDENT>
    {
        public StudentValidator()
        {
            // Validate cin
            RuleFor(s => s.CIN)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Le numero de cin est vide")
                .Length(5, 10).WithMessage("Le numero de cin plut petit ou grand")
                .Must(BeValideCin).WithMessage("La form du cin incorrect");

            // Validate first name
            RuleFor(s => s.F_NAME)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Le prenom est vide")
                .Length(3, 15).WithMessage("Le prenom plus petit ou grand")
                .Must(BeValideName).WithMessage("La form du prenom incorrect");

            // Validate last name
            RuleFor(s => s.L_NAME)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Le nom est vide")
                .Length(3, 15).WithMessage("Le nom plus petit ou grand")
                .Must(BeValideName).WithMessage("La form du nom incorrect");

            // Validate phone
            RuleFor(s => s.PHONE)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Le téléphone est vide")
                .Length(10).WithMessage("La forme du téléphone incorrect")
                .Must(BeValidePhone).WithMessage("La forme du téléphone incorrect");

            // Validate email
            RuleFor(s => s.EMAIL)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("L'email est vide")
                .EmailAddress().WithMessage("L'email incorrect");

            // Validate establishment
            RuleFor(s => s.ESTABLISHEMENT)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("L'établissement est vide")
                .Length(3, 150).WithMessage("L'établissement plus petit ou grand")
                .Must(BeValideName).WithMessage("La forme d'établissement incorrect");

            // Validate nationality
            RuleFor(s => s.NATIONALITY)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("La nationalité est vide")
                .Length(3, 20).WithMessage("La nationalité plus petit ou grand")
                .Must(BeValideName).WithMessage("La forme de la nationalité incorrect");

            // Validate province
            RuleFor(s => s.PROVINCE)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("La province est vide")
                .Length(3, 150).WithMessage("La province plus petit ou grand")
                .Must(BeValideName).WithMessage("La forme de la province incorrect");

            // Validate commune
            RuleFor(s => s.COMMUN)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("La commune est vide")
                .Length(3, 150).WithMessage("La commune plus petit ou grand")
                .Must(BeValideName).WithMessage("La forme de la commune incorrect");

            // Validate massar id
            RuleFor(s => s.MASSAR)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("L'ID Massar est vide")
                .Length(9, 12).WithMessage("L'ID Massar plus petit ou grand")
                .Must(BeValideMassarID).WithMessage("La forme de l'ID Massar incorrect");

            // Validate adresse
            RuleFor(s => s.ADRESS)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("L'adresse est vide")
                .Length(3, 300).WithMessage("L'adresse plus petit ou grand")
                .Must(BeValideAdress).WithMessage("La forme de l'adresse incorrect");
        }

        //
        // Valide cin
        //
        protected bool BeValideCin(string cin)
        {
            var l1 = cin.Substring(0, 1);
            var l2 = cin.Substring(1, 2);
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

        //
        // Valide adress
        //
        protected bool BeValideAdress(string adress)
        {
            adress.Replace(" ", "");
            adress.Replace(",", "");
            return adress.All(char.IsLetterOrDigit) ? true : false;
        }
        //
        // Valide massar id
        //
        protected bool BeValideMassarID(string cin)
        {
            var l = cin.Substring(0, 1);
            var n = cin.Substring(1);
            return l.All(char.IsLetter) && n.All(char.IsDigit) ? true : false;
        }

    }
}
