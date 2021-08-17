using AntDesign;
using Microsoft.AspNetCore.Components;
using blazor_antdesign_test.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Forms;
using blazor_antdesign_test.Models;

namespace blazor_antdesign_test.Shared
{
    public partial class SimpleForm
    {
        [Parameter]
        public string DividerTopMargin { get; set; }

        [Parameter]
        public string FormSize { get; set; } = AntSizeLDSType.Default;

        private readonly SimpleFormModel formModel = new();

        private Dictionary<string, string> simpleTableValues = null;

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

        private void OnFinish(EditContext editContext)
        {
            simpleTableValues = new()
            {
                ["Machine"] = formModel.MachineNr,
                ["Name"] = formModel.Name,
                ["User"] = formModel.User
            };
        }
    }
}
