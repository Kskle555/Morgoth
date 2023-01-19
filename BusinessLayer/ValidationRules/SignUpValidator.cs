using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SignUpValidator:AbstractValidator<AppUser>
    {
        public SignUpValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Boş bırakılamaz");
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Boş bırakılamaz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Boş bırakılamaz");
            RuleFor(x => x.PasswordHash).NotEmpty().WithMessage("Boş bırakılamaz");
        }
    }
}
