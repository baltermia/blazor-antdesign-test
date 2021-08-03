using AntDesign;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace blazor_antdesign_test.Shared
{
    public partial class SimpleTable
    {
        [Parameter]
        public string DividerTopMargin { get; set; }

        [Parameter]
        public string FormSize { get; set; } = AntSizeLDSType.Default;

        [Parameter]
        public Dictionary<string, string> TableValues { get; set; }

        [Parameter]
        public int SpanWidth { get; set; } = 8;
    }
}
