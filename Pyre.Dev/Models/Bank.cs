using Microsoft.EntityFrameworkCore.Metadata;
using Pyre.Dev.Models.Interfaces;

namespace Pyre.Dev.Models
{
    public class Bank : IFinanceTables
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;

        public bool Validate(out string error, out HashSet<string> invalidFields)
        {
            invalidFields = new HashSet<string>();

            if (string.IsNullOrWhiteSpace(Name)) invalidFields.Add(nameof(Name));

            if (string.IsNullOrWhiteSpace(Country)) invalidFields.Add(nameof(Country));

            if (string.IsNullOrWhiteSpace(State)) invalidFields.Add(nameof(State));

            error = invalidFields.Count > 0 ? "Please fill in the required fields." : "";
            return invalidFields.Count == 0;
        }
    }
}