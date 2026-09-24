# TableCompact

### Basic Table (no actions)
```html
<TableCompact>
    <TableCompactHeader>
        <TableCompactCell Ratio="1/4">Field</TableCompactCell>
        <TableCompactCell Ratio="1/4">Condition</TableCompactCell>
        <TableCompactCell Ratio="2/4">Match</TableCompactCell>
    </TableCompactHeader>

    <TableCompactRow IsOdd="true">
        <TableCompactCell Ratio="1/4">Amount</TableCompactCell>
        <TableCompactCell Ratio="1/4">is</TableCompactCell>
        <TableCompactCell Ratio="2/4">100.00</TableCompactCell>
    </TableCompactRow>
    <TableCompactRow IsOdd="false">
        <TableCompactCell Ratio="1/4">Name</TableCompactCell>
        <TableCompactCell Ratio="1/4">contains</TableCompactCell>
        <TableCompactCell Ratio="2/4">Starbucks</TableCompactCell>
    </TableCompactRow>
    <TableCompactRow IsOdd="true" IsLast="true">
        <TableCompactCell Ratio="1/4">Category</TableCompactCell>
        <TableCompactCell Ratio="1/4">is</TableCompactCell>
        <TableCompactCell Ratio="2/4">Food</TableCompactCell>
    </TableCompactRow>
</TableCompact>
```

### Table with Action Column
```html
<TableCompact HasActionColumn="true">
    <TableCompactHeader>
        <TableCompactCell Ratio="1/4">Field</TableCompactCell>
        <TableCompactCell Ratio="1/4">Condition</TableCompactCell>
        <TableCompactCell Ratio="1/1">Match</TableCompactCell>
        <TableCompactCell IsActionCell="true" Width="8rem">Actions</TableCompactCell>
    </TableCompactHeader>

    <TableCompactRow IsOdd="true">
        <TableCompactCell Ratio="1/4">Amount</TableCompactCell>
        <TableCompactCell Ratio="1/4">is</TableCompactCell>
        <TableCompactCell Ratio="1/1">100.00</TableCompactCell>
        <TableCompactCell IsActionCell="true" Width="8rem">
            <ButtonIconOnly Color="E_COLOR_BASIC.Remove">
                <TrashIcon Size="24" />
            </ButtonIconOnly>
            <ButtonIconOnly Color="E_COLOR_BASIC.Primary">
                <EditIcon Size="24" />
            </ButtonIconOnly>
        </TableCompactCell>
    </TableCompactRow>
    <TableCompactRow IsOdd="false" IsLast="true">
        <TableCompactCell Ratio="1/4">Name</TableCompactCell>
        <TableCompactCell Ratio="1/4">contains</TableCompactCell>
        <TableCompactCell Ratio="1/1">Starbucks</TableCompactCell>
        <TableCompactCell IsActionCell="true" Width="8rem">
            <ButtonIconOnly Color="E_COLOR_BASIC.Remove">
                <TrashIcon Size="24" />
            </ButtonIconOnly>
            <ButtonIconOnly Color="E_COLOR_BASIC.Primary">
                <EditIcon Size="24" />
            </ButtonIconOnly>
        </TableCompactCell>
    </TableCompactRow>
</TableCompact>
```

### Rendering from a List
```html
<TableCompact HasActionColumn="true">
    <TableCompactHeader>
        <TableCompactCell Ratio="1/4">Field</TableCompactCell>
        <TableCompactCell Ratio="1/4">Condition</TableCompactCell>
        <TableCompactCell Ratio="1/1">Match</TableCompactCell>
        <TableCompactCell IsActionCell="true" Width="8rem">Actions</TableCompactCell>
    </TableCompactHeader>

    @for (int i = 0; i < conditions.Count; i++)
    {
        var condition = conditions[i];
        <TableCompactRow IsOdd="@(i % 2 != 0)" IsLast="@(i == conditions.Count - 1)">
            <TableCompactCell Ratio="1/4">@condition.Field</TableCompactCell>
            <TableCompactCell Ratio="1/4">@condition.Condition</TableCompactCell>
            <TableCompactCell Ratio="1/1">@condition.Match</TableCompactCell>
            <TableCompactCell IsActionCell="true" Width="8rem">
                <ButtonIconOnly Color="E_COLOR_BASIC.Remove" OnClick="@(() => Delete(condition.Id))">
                    <TrashIcon Size="24" />
                </ButtonIconOnly>
                <ButtonIconOnly Color="E_COLOR_BASIC.Primary" OnClick="@(() => Edit(condition.Id))">
                    <EditIcon Size="24" />
                </ButtonIconOnly>
            </TableCompactCell>
        </TableCompactRow>
    }
</TableCompact>
```

## Variable Examples
```csharp
// For rendering from a list
List<RuleConditionDTO> conditions = new();

protected override async Task OnInitializedAsync()
{
    conditions = await _service.GetConditionsAsync();
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

## Sub-Components

| Component | Description |
| :---------: | ----------: |
| TableCompactHeader | Wraps the header row of the table. Place TableCompactCell components inside to define column headings |
| TableCompactRow | A single data row. Use IsOdd and IsLast to control alternating row styles and bottom border radius |
| TableCompactCell | A single cell inside a header or row. Use Ratio to control proportional width, Width for a fixed pixel/rem width, IsActionCell for the action column |

## Parameters

### TableCompact

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| HasActionColumn | - | Boolean. Signals to child components that an action column is present. Used for layout awareness |
| DebugBorders | - | Boolean. Enables colored debug borders on rows and cells to help visualise layout during development |

### TableCompactRow

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| IsOdd | - | Boolean. Applies alternating row background styling |
| IsLast | - | Boolean. Applies bottom border radius to the last row to match the table container |

### TableCompactCell

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| Ratio | - | Controls the cell's proportional flex width. Format is `numerator/denominator` e.g. `1/4`, `2/4`. Cells in the same row should use matching ratios to keep columns aligned |
| Width | - | Overrides Ratio with a fixed CSS width e.g. `8rem`. The cell will not grow or shrink. Use this for action columns |
| IsActionCell | - | Boolean. Applies action cell styling — right-aligned, flex row layout for icon buttons |
| FillRemaining | - | Boolean. Makes the cell take up all remaining space after fixed and ratio columns. Use on the last variable-width column when a fixed Width action cell is present |