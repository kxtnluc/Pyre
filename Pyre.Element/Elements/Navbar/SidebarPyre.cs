using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pyre.Element.Navbar
{
    public class SidebarPyre
    {
        public List<NavBarTabPyre> MainTabs { get; set; } = default!;
        public NavBarActionItemPyre? ActionItem { get; set; } = null;
        public List<NavBarTabPyre> FooterTabs { get; set; } = default!;
    }
}
