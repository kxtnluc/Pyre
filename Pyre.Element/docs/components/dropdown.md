# Dropdown

### Basic Dropdown
```html
<Dropdown 
    Options="@(["Option 1", "Option 2", "Option 3", "Option 4"])" 
    Label="Default" 
    @bind-Value="@inputDropdown" 
/>
```

### Advanced Dropdown
```html
<Dropdown 
    Options="@(["Option 1", "Option 2", "Option 3", "Option 4"])" 
    Label="Default" 
    Size="E_SIZE.sm"
    IncludeEmptyOption=true
    @bind-Value="@inputDropdown" 
    OnChange="OnDropdownChange"
/>
```

## Variable Examples

```csharp
string inputDropdown = "Exact";

private void OnDropdownChange()
{
    // TODO
}
```
