# Sidebar

### Basic Sidebar
```html
@using Pyre.Element.Icons
@using Pyre.Element.Navbar
@inherits LayoutComponentBase

<div class="layout @(_collapsed ? "layout--collapsed" : "")">
    
    <NavBarSide 
        Label="Pyre2" 
        OnToggle="HandleToggle"
        Sidebar="Sidebar"    
    />
    
    <main class="layout__main">
        @Body 
    </main>

</div>
```

### Sidebar in Full MainLayout Element
```html
@using Pyre.Element.Icons
@using Pyre.Element.Navbar
@inherits LayoutComponentBase

<div class="layout @(_collapsed ? "layout--collapsed" : "")">
    
    <NavBarSide 
        Label="Pyre2" 
        OnToggle="HandleToggle"
        Sidebar="Sidebar"    
    />
    
    <main class="layout__main">
        @Body 
    </main>

</div>

<div id="blazor-error-ui" data-nosnippet>
    An unhandled error has occurred.
    <a href="." class="reload">Reload</a>
    <span class="dismiss">🗙</span>
</div>

@code {
```
```csharp
    private bool _collapsed = false;
    private void HandleToggle() => _collapsed = !_collapsed;

    private string test = "Hello World";

    // Move initialization here — runs before anything else
    public SidebarPyre Sidebar = new SidebarPyre();

    protected override void OnInitialized()
    {
        Sidebar.MainTabs = new()
        {
            new NavBarTabPyre { Label = "Home", Url = "/", Icon = @<HouseIcon Size="26" /> },
            new NavBarTabPyre { Label = "Dashboard", Url = "/dashboard", Icon = @<OpenWindowIcon Size="26" /> },
            new NavBarTabPyre { Label = "Users", Url = "/users", Icon = @<GearIcon Size="26" /> }
        };

        Sidebar.FooterTabs = new()
        {
            new NavBarTabPyre { Label = "Logout", Url = "/logout", Icon = @<OpenWindowIcon Size="26" /> },
            new NavBarTabPyre { Label = "Settings", Url = "/settings", Icon = @<GearIcon Size="26" /> },
        };

        Sidebar.ActionItem = new NavBarActionItemPyre
        {
            CallbackAction = EventCallback.Factory.Create(this, VeryCoolAction),
            Icon = @<BookmarkIcon Size="26" />,
            Label = "Set Reminder"
        };
    }

    private void VeryCoolAction()
    {
        test = "Very cool action executed!";
    }
```

### Reccomended CSS for Layout Page
```css
.layout {
    display: flex;
}

.layout__main {
    margin-left: 16rem; /* must match sidebar width */
    width: calc(100% - 16rem);
    transition: margin-left 250ms ease, width 250ms ease; /* matches sidebar transition */
}

/* When sidebar is collapsed */
.layout--collapsed .layout__main {
    margin-left: 3.5rem;
    width: calc(100% - 3.5rem);
}
```

## Variable Examples

```csharp
    private bool _collapsed = false;
    private void HandleToggle() => _collapsed = !_collapsed;

    private string test = "Hello World";

    // Move initialization here — runs before anything else
    public SidebarPyre Sidebar = new SidebarPyre();

    protected override void OnInitialized()
    {
        Sidebar.MainTabs = new()
        {
            new NavBarTabPyre { Label = "Home", Url = "/", Icon = @<HouseIcon Size="26" /> },
            new NavBarTabPyre { Label = "Dashboard", Url = "/dashboard", Icon = @<OpenWindowIcon Size="26" /> },
            new NavBarTabPyre { Label = "Users", Url = "/users", Icon = @<GearIcon Size="26" /> }
        };

        Sidebar.FooterTabs = new()
        {
            new NavBarTabPyre { Label = "Logout", Url = "/logout", Icon = @<OpenWindowIcon Size="26" /> },
            new NavBarTabPyre { Label = "Settings", Url = "/settings", Icon = @<GearIcon Size="26" /> },
        };

        Sidebar.ActionItem = new NavBarActionItemPyre
        {
            CallbackAction = EventCallback.Factory.Create(this, VeryCoolAction),
            Icon = @<BookmarkIcon Size="26" />,
            Label = "Set Reminder"
        };
    }

    private void VeryCoolAction()
    {
        test = "Very cool action executed!";
    }
```

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| Label | - | The string displayed in the Sidebars header |
| Open | Yes | Boolean bound to a parent page's field that controls Sidebars visibility |
| OnToggle | Yes | Callback fired when the Sidebar requests to close |
| Closeable | - | Boolean. Determines weather or not the Sidebar is allowed to be closed/opened |
| Sidebar | - | A custom Pyre class that holds all the information for the tabs and actions |