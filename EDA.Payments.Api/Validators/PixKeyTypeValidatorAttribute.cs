using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Validators;

public class PixKeyTypeValidatorAttribute: ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        return base.IsValid(value, validationContext);
    }
}