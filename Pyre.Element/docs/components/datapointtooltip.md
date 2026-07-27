# DataPointTooltip

### Basic Data Point Tooltip
```html
<DataPointTooltip DataPoint="$500">
    This is some cool content :D
</DataPointTooltip>
```

### Status Variants
```html
<DataPointTooltip DataPoint="$500" Variant="E_STATUS.Positive">
    Pos
</DataPointTooltip>

<DataPointTooltip Position="E_DIRECTION_CARDINAL.Right" DataPoint="$500" Variant="E_STATUS.Negative">
    Neg
</DataPointTooltip>
```

> Typically used on graphs and reports to indicicate or show greater information on a datapoint.

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| DataPoint | Yes | The value displayed as the anchor data point (e.g. a dollar amount) |
| Variant | - | Controls the color/status styling of the data point via E_STATUS (Positive, Negative, Neutral) |
| Position | - | Controls which side the tooltip content renders on via E_DIRECTION_CARDINAL (Up, Down, Left, Right) |
| ChildContent | Yes | The explanatory content displayed inside the tooltip when the data point is hovered |