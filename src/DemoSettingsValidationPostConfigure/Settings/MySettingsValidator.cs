using Microsoft.Extensions.Options;
using System;

namespace DemoSettingsValidationPostConfigure.Settings
{
    public class MySettingsValidator : IPostConfigureOptions<MySettings>
    {
        public void PostConfigure(string name, MySettings options)
        {
            if (options.Validate())
            {
                return;
            }

            throw new InvalidOperationException($"Invalid {nameof(MySettings)} options. {string.Join(",", options.ValidationResult)}");
        }
    }
}