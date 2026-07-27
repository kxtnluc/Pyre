# Modal

### Basic Modal
```html
<Modal 
    Title="Modal One"
    Size="E_SIZE.md"
    Open="showModalOne"
    OnClose="CloseModal"
    HelpBtn="true"
    Variant="E_MODAL.AddEdit"
>
    <div></div>
</Modal>
```

### Modal with a Form inside
```html
<Modal Title="Edit Bank"
       Size="E_SIZE.lg"
       Open="showModalTwo"
       OnClose="CloseModalTwo"
       Variant="E_MODAL.AddEdit">
    <Form>
        <FormContent>
            <FormRow>
                <FormCell Ratio="1/2">
                    <Input Variant="INPUT_VARIANT.Default" Label="Name" @bind-Value="inputText" />
                </FormCell>
                <FormCell Ratio="1/4">
                    <Dropdown Variant="E_DROPDOWN.Default" Label="Country" Options="@(["USA", "CAN", "MEX"])" @bind-Value="inputDropdown" />
                </FormCell>
                <FormCell Ratio="1/4">
                    <Dropdown Variant="E_DROPDOWN.Default" Label="State" Options="@(["TN", "AK", "OR", "NY"])" @bind-Value="inputDropdown" />
                </FormCell>
            </FormRow>
        </FormContent>
        <FormFooter>
            <Button Variant="E_VARIANT.Secondary" Color="E_COLOR_BASIC.OffWhite" Onclick="CloseModalTwo">Cancel</Button>
            <Button Variant="E_VARIANT.Primary" Color="E_COLOR_BASIC.Info" Onclick="CloseModalTwo">Create</Button>
        </FormFooter>
    </Form>
</Modal>
```

### Opening a Modal (parent page)
```html
<Button Variant="E_VARIANT.Primary" OnClick="OpenModal">
    Open Modal
</Button>
```

## Variable Examples

```csharp
    private bool showModalOne;
    private bool showModalTwo;
    private void OpenModal() => showModalOne = true;
    private void CloseModal() => showModalOne = false;
    private void OpenModalTwo() => showModalTwo = true;
    private void CloseModalTwo() => showModalTwo = false;
```

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| Title | - | The string displayed in the modal's header |
| Size | - | Controls the modal's width/size via E_SIZE (sm-md-lg) |
| Open | Yes | Boolean bound to a parent page's field that controls modal visibility |
| OnClose | Yes | Callback fired when the modal requests to close (backdrop click, close button, etc.) |
| HelpBtn | - | Boolean. Shows/hides a help icon button in the modal header |
| Variant | - | Controls the modal's styling/behavior via E_MODAL (e.g. AddEdit) |
| ChildContent | Yes | The content rendered inside the modal body, commonly a Form |