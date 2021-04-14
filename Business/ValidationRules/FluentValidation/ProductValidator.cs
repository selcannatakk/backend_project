using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();         // bos olamaz
            RuleFor(p => p.ProductName).MinimumLength(2);   //min 2 caracter
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);    // 0 dan buyuk olmalı
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);   //categori için min 10 
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile baslamalı");    // names a ile başlamalı demek // true ise olur false ise bu satır patlar
        }

        private bool StartWithA(string arg)  // arg = ProductName
        {
            return arg.StartsWith("A");
        }
    }
}
