﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnimeValidator:AbstractValidator<Anime>
    {
        public AnimeValidator()
        {
        //    RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Boş bırakılamaz.");
        //    RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Boş bırakılamaz.");
        //    RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Boş bırakılamaz.");
        //    RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Max 150 karakter.");
        //    RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Min 5 karakter.");

        }
    }
}
