namespace Pyre.Dev.Models.Interfaces
{
    public interface IFinanceTables : ITable
    {
        bool Validate(out string error, out HashSet<string> invalidFields);
    }
}
