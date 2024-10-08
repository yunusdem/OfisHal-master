using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OfisHal.Core
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredIfAttribute : RequiredAttribute, IClientValidatable
    {
        private string PropertyName { get; set; }

        private object DesiredValue { get; set; }

        private readonly RequiredAttribute _innerAttribute;

        public RequiredIfAttribute(string propertyName,object desiredValue)
        {
            PropertyName = propertyName;
            DesiredValue = desiredValue;
            _innerAttribute = new RequiredAttribute();
            //ErrorMessage = "The {0} field is required."; //used if error message is not set on attribute itself
        }

        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            var dependentValue = context.ObjectInstance.GetType().GetProperty(PropertyName).GetValue(context.ObjectInstance, null);

            if (dependentValue.ToString() == DesiredValue.ToString())
            {
                if (!_innerAttribute.IsValid(value))
                    return new ValidationResult(FormatErrorMessage(context.DisplayName), new[] { context.MemberName });
            }
            return ValidationResult.Success;
            /*
            var instance = context.ObjectInstance;
            var type = instance.GetType();
            bool.TryParse(type.GetProperty(PropertyName).GetValue(instance)?.ToString(), out bool propertyValue);

            if (propertyValue && (value == null || string.IsNullOrWhiteSpace(value?.ToString())))
                return new ValidationResult(ErrorMessage);
            return ValidationResult.Success;*/
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule
            {
                ErrorMessage = ErrorMessageString,
                ValidationType = "requiredif",
            };

            rule.ValidationParameters["dependentproperty"] = (context as ViewContext).ViewData.TemplateInfo.GetFullHtmlFieldId(PropertyName);
            rule.ValidationParameters["desiredvalue"] = DesiredValue is bool ? DesiredValue.ToString().ToLower() : DesiredValue;

            yield return rule;
        }
    }
}