﻿using System.Text.RegularExpressions;

namespace blazor_antdesign_test.Shared
{
    public class Rules
    {
        public static readonly Regex MachineRegex = new(@"^([A-Za-z]\d{4}[A-Za-z]\d{4})$");
    }
}
