# LineBreak

### Default
```html
<LineBreak />
```

### Color Variants
```html
<LineBreak Color="E_COLOR_BASIC.Primary" />
<LineBreak Color="E_COLOR_BASIC.Secondary" />
<LineBreak Color="E_COLOR_BASIC.Info" />
<LineBreak Color="E_COLOR_BASIC.Remove" />
```

### Size Variants
```html
<LineBreak Size="E_SIZE.xs" />
<LineBreak Size="E_SIZE.sm" />
<LineBreak Size="E_SIZE.md" />
<LineBreak Size="E_SIZE.lg" />
<LineBreak Size="E_SIZE.xl" />
```

### Custom Width
```html
@* Half width *@
<LineBreak Width="50%" />

@* Fixed width decorative bar *@
<LineBreak Width="4rem" Size="E_SIZE.xl" Color="E_COLOR_BASIC.Info" />
```

### Custom Hex Color
```html
<LineBreak HexColor="#ff6f4e" Size="E_SIZE.lg" />
<LineBreak HexColor="#3a86ff" Width="50%" />
```

### As a Section Divider
```html
<Title Size="E_SIZE.lg">Section One</Title>
<LineBreak Size="E_SIZE.sm" Color="E_COLOR_BASIC.Secondary" />
<p>Content goes here</p>
```

## Notes
- Defaults to full width (`100%`) and fits whatever container holds it
- When `HexColor` is provided it takes priority over `Color`
- Color is automatically rendered at a faded opacity using the `--color-{color}-faded` token, keeping it subtle by default
- `Size` controls the height (thickness) of the line, not the width
- Fully rounded ends on all sizes via `border-radius: 999px`

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| Size | - | Controls the height (thickness) of the line via E_SIZE (xs through xl). Defaults to sm |
| Color | - | Controls the line color via E_COLOR_BASIC. Renders at faded opacity. Defaults to Primary |
| HexColor | - | Overrides Color with a custom hex string e.g. `#ff6f4e`. When set, Color is ignored |
| Width | - | CSS width value e.g. `100%`, `50%`, `4rem`. Defaults to `100%` |