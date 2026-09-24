# HexColorPicker

### Basic
```html
<HexColorPicker @bind-Value="myColor" Label="Brand Color" />
```

### No Label
```html
<HexColorPicker @bind-Value="myColor" Label="" />
```

### Size Variants
```html
<HexColorPicker @bind-Value="myColor" Label="Small" Size="E_SIZE.sm" />
<HexColorPicker @bind-Value="myColor" Label="Medium" Size="E_SIZE.md" />
<HexColorPicker @bind-Value="myColor" Label="Large" Size="E_SIZE.lg" />
```

### Disabled
```html
<HexColorPicker @bind-Value="myColor" Label="Brand Color" Disabled="true" />
```

### Inside a Form
```html
<Form>
    <FormContent>
        <FormRow>
            <FormCell>
                <HexColorPicker @bind-Value="payload.HexColor" Label="Category Color" />
            </FormCell>
        </FormRow>
    </FormContent>
    <FormFooter>
        <FormSubmit Variant="FORM_VARIANT.Add" />
    </FormFooter>
</Form>
```

### With OnChange Callback
```html
<HexColorPicker 
    @bind-Value="myColor" 
    Label="Accent Color"
    OnChange="HandleColorChange" />
```

## Variable Examples
```csharp
private string myColor = "#ff6f4e";

private void HandleColorChange(string newColor)
{
    // newColor is the selected hex string e.g. "#3a86ff"
    myColor = newColor;
}
```

## Notes
- The hex value is always a valid 6-character hex string prefixed with `#` e.g. `#ff6f4e`
- The selected hex value is displayed as text beside the color swatch
- Supports `@bind-Value` for two-way binding
- When placed inside a `<Form>`, the component integrates with form validation and clears its error state on change
- The native OS color picker is used — its appearance varies by operating system and browser

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| Value | ✓ | The current hex color string. Use `@bind-Value` for two-way binding. Defaults to `#000000` |
| Label | - | Label text displayed above the picker. Pass an empty string to hide it |
| Size | - | Controls the size of the color swatch via E_SIZE. Defaults to md |
| Disabled | - | Boolean. Disables the picker input |
| OnChange | - | Optional callback fired whenever the color value changes, receives the new hex string |