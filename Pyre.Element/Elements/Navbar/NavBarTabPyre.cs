using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pyre.Element.Navbar
{
    public class NavBarTabPyre
    {
        public string Label { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public RenderFragment? Icon { get; set; }
    }
}
