using aw_1_CanberkTimurlenk.Constants.Staff;
using aw_1_CanberkTimurlenk.Models;
using aw_1_CanberkTimurlenk.Validations.RegularExpressions;
using FluentValidation;

namespace aw_1_CanberkTimurlenk.Validations;
public class StaffValidator : AbstractValidator<Staff>
{
    public StaffValidator()
    {
        // Validation rules for Staff

        // For Name
        RuleFor(x => x.Name)
                            .NotEmpty()
                            .WithMessage("Name is required.");

        RuleFor(x => x.Name)
                            .Length(10, 250)
                            .WithMessage("Name must be between 10 and 250 characters.");

        // For Email
        RuleFor(x => x.Email)
                             .EmailAddress()
                             .WithMessage("Email address is not valid.");

        // For Phone
        RuleFor(x => x.Phone)
                             .Matches(RegexValidations.Phone)
                             .WithMessage("Phone is not valid.");

        // For HourlySalary
        RuleFor(x => x.HourlySalary)
                                    .InclusiveBetween(StaffConstants.MinStaffHourlySalary, StaffConstants.MaxStaffHourlySalary)
                                    .WithMessage("Hourly salary does not fall within allowed range.");
    }
}