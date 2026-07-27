# Tooltip

### Basic Tooltip (over a div)
```html
<Tooltip Text="Over Div" Position="E_DIRECTION_CARDINAL.Down">
    <div>
        Cool Text
    </div>
</Tooltip>
```

### Tooltip over an Icon
```html
<Tooltip Text="Over Icon" Position="E_DIRECTION_CARDINAL.Down">
    <PlusIcon Size="24" />
</Tooltip>
```

### Positioned Tooltips
```html
<Tooltip Text="Over Div Left" Position="E_DIRECTION_CARDINAL.Left">
    <div class="icon">
        <TrashIcon Size="24" />
    </div>
</Tooltip>

<Tooltip Text="Over Div Right" Position="E_DIRECTION_CARDINAL.Right">
    <div class="icon">
        <TrashIcon Size="24" />
    </div>
</Tooltip>

<Tooltip Text="Over Div Top" Position="E_DIRECTION_CARDINAL.Up">
    <div class="icon">
        <TrashIcon Size="24" />
    </div>
</Tooltip>
```

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| Text | - | The string content displayed inside the tooltip when the wrapped element is hovered |
| Position | - | Controls which side of the wrapped element the tooltip renders on, via E_DIRECTION_CARDINAL (Up, Down, Left, Right) |
| ChildContent | Yes | The element(s) the tooltip wraps and attaches its hover trigger to |