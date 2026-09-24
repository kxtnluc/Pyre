# ButtonIconOnly

### Basic Icon Button
```html
<ButtonIconOnly OnClick="ButtonClick">
    <TrashIcon Size="18" />
</ButtonIconOnly>
```

### Color Variants
```html
<ButtonIconOnly Color="E_COLOR_BASIC.Remove" OnClick="ButtonClick">
    <TrashIcon Size="18" />
</ButtonIconOnly>

<ButtonIconOnly Color="E_COLOR_BASIC.Info" OnClick="ButtonClick">
    <EditIcon Size="18" />
</ButtonIconOnly>

<ButtonIconOnly Color="E_COLOR_BASIC.Primary" OnClick="ButtonClick">
    <BookmarkIcon Size="18" />
</ButtonIconOnly>
```

### Size Variants
```html
<ButtonIconOnly Color="E_COLOR_BASIC.Remove" Size="E_SIZE.sm">
    <TrashIcon Size="14" />
</ButtonIconOnly>

<ButtonIconOnly Color="E_COLOR_BASIC.Info" Size="E_SIZE.lg">
    <EditIcon Size="24" />
</ButtonIconOnly>

<ButtonIconOnly Color="E_COLOR_BASIC.Primary" Size="E_SIZE.xl">
    <BookmarkIcon Size="30" />
</ButtonIconOnly>
```

### Disabled
```html
<ButtonIconOnly Color="E_COLOR_BASIC.Remove" Disabled="true">
    <TrashIcon Size="18" />
</ButtonIconOnly>
```

### Inside a Table Action Cell
```html
<TableCompactCell IsActionCell="true" Width="8rem">
    <ButtonIconOnly Color="E_COLOR_BASIC.Remove" OnClick="@(() => Delete(item.Id))">
        <TrashIcon Size="24" />
    </ButtonIconOnly>
    <ButtonIconOnly Color="E_COLOR_BASIC.Primary" OnClick="@(() => Edit(item.Id))">
        <EditIcon Size="24" />
    </ButtonIconOnly>
</TableCompactCell>
```

## Variable Examples
```csharp
private void ButtonClick()
{
    // handle click
}

private void Delete(int id)
{
    // handle delete
}

private void Edit(int id)
{
    // handle edit
}
```

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| Color | - | Controls the icon color via E_COLOR_BASIC. Defaults to Primary |
| Size | - | Controls the padding around the icon via E_SIZE (xs through xl). Defaults to md. Note: icon size is controlled by the icon component itself, not this parameter |
| Disabled | - | Boolean. Disables the button and reduces opacity |
| OnClick | - | The callback function fired when the button is clicked |