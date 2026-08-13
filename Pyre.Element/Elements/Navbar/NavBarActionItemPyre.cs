using Microsoft.AspNetCore.Components;

namespace Pyre.Element.Navbar
{
    public class NavBarActionItemPyre
    {
        public EventCallback CallbackAction { get; set; }
        public RenderFragment? Icon { get; set; }
        public string Label { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
    }
}
