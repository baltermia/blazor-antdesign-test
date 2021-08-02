using System.ComponentModel.DataAnnotations;

namespace blazor_antdesign_test.Data
{
    public class SimpleFormModel
    {
        [Required]
        public string MachineNr { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string User { get; set; }
    }
}
