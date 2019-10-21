using FluentValidation;

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
