﻿using System.Web.Mvc;

namespace WebPortal.CustomValidators
{
    public class ModelClientValidationNotEqualToRule : ModelClientValidationRule
    {
        public ModelClientValidationNotEqualToRule(string errorMessage, string otherProperties)
        {
            ErrorMessage = errorMessage;
            ValidationType = "notequalto";
            ValidationParameters.Add("otherproperties", otherProperties);
        }
    }
}
