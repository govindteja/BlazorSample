using FluentValidation;

namespace BlazorSample.Data.Models.Validators
{
    public class MovieValidator : AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.ReleaseYear).NotEmpty();
        }
    }
}
