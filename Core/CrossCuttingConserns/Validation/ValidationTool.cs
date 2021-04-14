using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConserns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);   // product için dogrumalama calısılan tipte product
            //ProductValidator productValidator = new ProductValidator();
            var result = validator.Validate(context);    // ilgili context=product
            if (!result.IsValid)// eger sonuc gecerli degıl ise
            {
                throw new ValidationException(result.Errors); // hata fıllat
            }
        }
    }
}
