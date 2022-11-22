using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationAssignment.CustomValidations
{
    public class CheckBoxValidation : ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-chkbox", ErrorMessage);
        }

        public override bool IsValid(object? value)
        {
           if(value == null || !(bool)value) return false;
            return true;
        }
    }
}
