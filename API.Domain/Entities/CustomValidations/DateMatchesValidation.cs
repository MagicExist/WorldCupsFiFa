using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Entities.CustomValidations
{
    internal static class DateMatchesValidation
    {
        public static ValidationResult ValidateEventDate(DateOnly date, ValidationContext ctx)
        {
            DateOnly minDate = new DateOnly(1930,7,13);
            DateOnly maxDate = new DateOnly(3000, 1, 1);

            if(date < minDate || date > maxDate)
            {
                return new ValidationResult($"Date must be between {minDate} and {maxDate}");
            }

            return ValidationResult.Success;
        }
    }
}
