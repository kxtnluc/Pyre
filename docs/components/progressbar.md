# ProgressBar

### Basic
```html
<ProgressBar Complete="40" Total="100" />
```

### Size Variants
```html
<ProgressBar Complete="60" Total="100" Size="E_SIZE.xs" />
<ProgressBar Complete="60" Total="100" Size="E_SIZE.sm" />
<ProgressBar Complete="60" Total="100" Size="E_SIZE.md" />
<ProgressBar Complete="60" Total="100" Size="E_SIZE.lg" />
<ProgressBar Complete="60" Total="100" Size="E_SIZE.xl" />
```

### Custom Colors
```html
<ProgressBar 
    Complete="750" 
    Total="1000"
    CompleteColor="E_COLOR_BASIC.Info"
    IncompleteColor="E_COLOR_BASIC.OffWhite" />
```

### Bound to a Value
```html
<ProgressBar 
    Complete="@currentProgress" 
    Total="@totalSteps"
    CompleteColor="E_COLOR_BASIC.Primary"
    Size="E_SIZE.md" />
```

### Inside a Card
```html
<Card>
    <CardHeader>
        <CardTitle><Title>Budget Used</Title></CardTitle>
    </CardHeader>
    <CardContent>
        <ProgressBar 
            Complete="@spent" 
            Total="@budget"
            CompleteColor="E_COLOR_BASIC.Secondary"
            Size="E_SIZE.lg" />
    </CardContent>
</Card>
```

## Variable Examples
```csharp
private double currentProgress = 65;
private double totalSteps = 100;

private double spent = 430;
private double budget = 1000;

// Updating progress dynamically
private void IncrementProgress()
{
    currentProgress = Math.Min(currentProgress + 10, totalSteps);
}
```

## Notes
- `Complete` and `Total` are `double` values — pass any unit (dollars, steps, percent points) as long as both use the same unit
- `Complete` is automatically clamped between `0` and `Total` so it can never overflow
- `Size` controls the height (thickness) of the bar, not the width — the bar always fills its parent container width
- Both the complete and incomplete segments have fully rounded ends via `border-radius: 999px`
- The bar animates width changes with a `400ms ease` transition when `Complete` changes

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| Complete | ✓ | The current completed value. Clamped between 0 and Total |
| Total | ✓ | The maximum value representing 100% completion. Defaults to 100 |
| CompleteColor | - | Color of the filled portion via E_COLOR_BASIC. Defaults to Primary |
| IncompleteColor | - | Color of the unfilled portion via E_COLOR_BASIC. Defaults to OffWhite |
| Size | - | Controls the height of the bar via E_SIZE (xs through xl). Defaults to sm |