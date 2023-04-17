using FluentValidation;
using FluentValidationing.DTOs;

namespace FluentValidationing.Validations
{
    public class RegisterValidation:AbstractValidator<RegisterViewModel>
    {
        public RegisterValidation()
        {
            //valdation propertic
            
            RuleFor(x=>x.Name).NotEmpty()
                .WithMessage("Enter your Name")
                .MaximumLength(50)
                .MinimumLength(2);

            RuleFor(x=>x.Familty).NotEmpty()
                .WithMessage("Enter your Lastname")
                .MinimumLength(120);

            RuleFor(x => x.PhoneNumber).NotEmpty()
                 .WithMessage("Enter your PhoneNumber")
                 .Length(10, 13);

            RuleFor(x => x.Age).NotEmpty()
                .Must(x => x > 16 && x<50);

            RuleFor(x => x.BearthDay).NotEmpty()
                .NotNull()
                .NotEqual(DateTime.Now).WithMessage("Enter your Date of Braeth cerrect !");


            // Validation List in our ViewModel

            RuleForEach(x => x.course).SetValidator(new CourseValidations());


        }
    }

    public  class CourseValidations : AbstractValidator<CourseViewModel>
    {
        public CourseValidations()
        {
            RuleFor(x => x.CourseName).NotNull().NotEmpty();
        }
    }
}
