using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class MinimumDateValidatorAttribute : ValidationAttribute
{
    private readonly DateTime _minDate;

    public MinimumDateValidatorAttribute(string minDate)
    {
        _minDate = DateTime.ParseExact(minDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        ErrorMessage = $"The field {{0}} must be greater than or equal to {_minDate:d}";
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult(ErrorMessage);
        }

        if (!(value is DateTime))
        {
            throw new ArgumentException("Value must be a DateTime object");
        }

        DateTime dateValue = (DateTime)value;

        if (dateValue < _minDate)
        {
            return new ValidationResult(ErrorMessage);
        }

        return ValidationResult.Success;
    }
}
