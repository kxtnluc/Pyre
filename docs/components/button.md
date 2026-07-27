# Button

### Basic Button
```
<Button 
    Variant="E_VARIANT.Primary" 
    OnClick="ButtonClick"
>
    Basic Button
</Button>
```

### Color Button
```
<Button 
    OnClick="ButtonClick"
    Color="E_COLOR_BASIC.OffWhite" 
>
    Basic Button
</Button>
```

### Icon Button
```
<Button 
    Variant="E_VARIANT.Outline" 
    Color="E_COLOR_BASIC.Remove" 
    Size="E_SIZE.lg"
>
    Button Icon
    <TrashIcon />
</Button>
```

## Variable Examples
```csharp
string buttonText = "";

// Button Click Function
private void ButtonClick()
{
    buttonText = "No DI Click!";
}
// Button Click with Dependency Inject Function
private void ButtonClick_DI(string message)
{
    buttonText = (message);
}
```

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| Variant | - | This is bassed on the E_VARIANT enum. It controls the buttons design style, weather its outlined or full, and so on |
| Size | - | Controls the size of the button via E_SIZE from sm-md-lg |
| Color | - | Controls the Color of the button via E_COLOR_BASIC |
| OnClick | - | The callback function when the button is clicked |

