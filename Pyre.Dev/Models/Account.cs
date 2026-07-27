using Pyre.Dev.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pyre.Dev.Models
{
    public class Account : IFinanceTables
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Account_Number { get; set; }
        public string Routing_Number { get; set; }
        public bool Validate(out string error, out HashSet<string> invalidFields)
        {
            invalidFields = new HashSet<string>();

            if (string.IsNullOrWhiteSpace(Name))
                invalidFields.Add(nameof(Name));
            if (string.IsNullOrWhiteSpace(Account_Number))
                invalidFields.Add(nameof(Account_Number));

            error = invalidFields.Count > 0 ? "Please fill in the required fields." : "";
            return invalidFields.Count == 0;
        }
    }
}