using AntDesign;
using Microsoft.AspNetCore.Components;
using blazor_antdesign_test.Data;
using System.Collections.Generic;

namespace blazor_antdesign_test.Shared
{
    public partial class SimpleForm
    {
        [Parameter]
        public string DividerTopMargin { get; set; }

        [Parameter]
        public string FormSize { get; set; } = AntSizeLDSType.Default;

        private readonly SimpleFormModel formModel = new();

        // Rules ----------------------------------------------------------------
        private readonly FormValidationRule[] machineNrRules = new FormValidationRule[]
        {
            new FormValidationRule { Pattern = Rules.MachineRegex.ToString(), Message = "Invalid machine number" }
        };
        // ----------------------------------------------------------------------

        // Options --------------------------------------------------------------
         private readonly List<string> userOptions = new()
        {
            "Placeholder 1",
            "Placeholder 2",
            "Placeholder 3"
        };       
        // ----------------------------------------------------------------------        
    }
}
