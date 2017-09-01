using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BudgetManagerV2.Models
{
    public class MyValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            int g;
            if (int.TryParse(value.ToString(), out g))
            {
                if (g >= 0)
                    return true;
            }

            return false;
        }
    }
}