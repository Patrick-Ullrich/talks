using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventIO.Application.Session.Commands.SignUpSession
{
    public class SignUpSessionValidator : AbstractValidator<SignUpSessionCommand>
    {
        public SignUpSessionValidator()
        {
            RuleFor(x => x.SessionId).NotEmpty();
        }
    }
}
