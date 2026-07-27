# Checkbox

### Basic Checkbox
```
<Checkbox @bind-Value="inputCheckbox" />
```

## Variable Examples
```csharp
private bool inputCheckbox = false;
```

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| Value | Yes | Boolean bound via @bind-Value, representing the checked/unchecked state |