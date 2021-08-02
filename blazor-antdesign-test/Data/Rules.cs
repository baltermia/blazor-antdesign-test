using System.Text.RegularExpressions;

namespace blazor_antdesign_test.Shared
{
    public class Rules
    {
        public static Regex MachineRegex = new(@"^([A-Z]\d{4}[A-Z]\d{4})$");
    }
}
