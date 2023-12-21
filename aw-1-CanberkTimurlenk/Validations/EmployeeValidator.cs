using aw_1_CanberkTimurlenk.Constants.Employee;
using aw_1_CanberkTimurlenk.Models;
using aw_1_CanberkTimurlenk.Validations.RegularExpressions;
using FluentValidation;

namespace aw_1_CanberkTimurlenk.Validations;
public class EmployeeValidator : AbstractValidator<Employee>
{
    public EmployeeValidator()
    {
        // Validation rules for Employee

        // For Name
        RuleFor(e => e.Name)
                            .NotEmpty()
                            .WithMessage("Name is required.");

        RuleFor(e => e.Name)
                            .Length(10, 250)
                            .WithMessage("Invalid Name.");

        // For DateOfBirth
        RuleFor(e => e.DateOfBirth)
                                   .NotEmpty()
                                   .WithMessage("Date of birth is required.");

        RuleFor(e => e.DateOfBirth)
                                   .Must(d => d > DateTime.Now.AddYears(-65))
                                   .WithMessage("Birthdate is not valid.");

        // For EmailAddress
        RuleFor(e => e.Email)
                             .EmailAddress()
                             .WithMessage("Email address is not valid.");

        // For Phone Number
        RuleFor(e => e.Phone)
                             .Matches(RegexValidations.Phone)
                             .WithMessage("Phone is not valid.");

        // For HourlySalary
        RuleFor(e => e.HourlySalary)
                                    .InclusiveBetween(50, 400)
                                    .WithMessage("Hourly salary does not fall within allowed range.");

        RuleFor(e => e.HourlySalary)
                                    .Must((e, _) =>
                                        BeGreaterThanMinLegalSalary(e, EmployeeConstants.MinJuniorHourlySalary, EmployeeConstants.MinSeniorHourlySalary))
                                    .WithMessage("Minimum hourly salary is not valid.");
    }

    private bool BeGreaterThanMinLegalSalary(Employee employee, double minJuniorSalary, double minSeniorSalary)
    {
        var dateBeforeThirtyYears = DateTime.Today.AddYears(-1 * EmployeeConstants.SeniorPromotionAge);

        var isOlderThanThirdyYears = employee.DateOfBirth <= dateBeforeThirtyYears;

        return isOlderThanThirdyYears
            ? employee.HourlySalary >= minJuniorSalary
            : employee.HourlySalary >= minSeniorSalary;
    }
}