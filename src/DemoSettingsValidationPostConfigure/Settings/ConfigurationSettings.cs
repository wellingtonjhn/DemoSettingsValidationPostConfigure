using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoSettingsValidationPostConfigure.Settings
{
    public abstract class ConfigurationSettings
    {
        public List<ValidationResult> ValidationResult = new List<ValidationResult>();

        public bool Validate() => Validator.TryValidateObject(
                this,
                new ValidationContext(this),
                ValidationResult,
                validateAllProperties: true);
    }
}