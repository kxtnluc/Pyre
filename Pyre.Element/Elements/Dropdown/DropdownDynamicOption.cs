namespace Pyre.Element.Dropdown;

public class DropdownDynamicOption<TValue>
{
    public string Label { get; set; } = string.Empty;
    public TValue Value { get; set; } = default!;
}