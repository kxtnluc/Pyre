# Form

### Basic Form (with header)
```
<Form>
    <FormHeader>
        <FormTitle>Create Bank Account</FormTitle>
        <FormDescription>Manually enter bank account information to file transactions and cards under</FormDescription>
    </FormHeader>
    <FormContent>
        <FormRow>
            <FormCell Ratio="1">
                <Input InputType="E_INPUT_TYPE.Text" Label="Name" @bind-Value="inputText" Placeholder="First Horizon Checking" />
            </FormCell>
        </FormRow>
        <FormRow>
            <FormCell Ratio="1/2">
                <Input InputType="E_INPUT_TYPE.Text" @bind-Value="inputText" Label="Account Number" Placeholder="4444000012349876" />
            </FormCell>
            <FormCell Ratio="1/2">
                <Input InputType="E_INPUT_TYPE.Text" @bind-Value="inputText" Label="Routing Number" Placeholder="4444000012349876" />
            </FormCell>
        </FormRow>
    </FormContent>
    <FormFooter>
        <Button Variant="E_VARIANT.Primary" Color="E_COLOR_BASIC.OffWhite" OnClick="@(() => ButtonClick_DI("Form Cancel"))">Cancel</Button>
        <Button Variant="E_VARIANT.Primary" OnClick="@(() => ButtonClick_DI("Form Create"))">Create</Button>
    </FormFooter>
</Form>
```

### Form without a header (used inside a Modal)
```
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
```

### Single full-width field
```
<FormRow>
    <FormCell Ratio="1">
        <Input Variant="INPUT_VARIANT.Default" Label="Name" @bind-Value="inputText" />
    </FormCell>
</FormRow>
```

## Sub-Components

| Component | Description |
| :---------: | ----------: |
| FormHeader | Optional. Wraps the FormTitle and FormDescription at the top of the form |
| FormTitle | The main heading text of the form |
| FormDescription | Secondary descriptive text rendered under the title, explaining the form's purpose |
| FormContent | Wraps all FormRow elements that make up the form's fields |
| FormRow | A horizontal row of one or more FormCell elements |
| FormCell | A single field slot within a FormRow. Uses Ratio to control its width relative to sibling cells |
| FormFooter | The bottom section of the form, typically holding Cancel/Submit Buttons |

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| Ratio (FormCell) | - | Controls the width of the cell relative to its row, e.g. "1" (full width), "1/2", "1/4" |
| ChildContent | Yes | Applies to FormHeader, FormContent, FormRow, FormCell, and FormFooter — the content rendered inside each respective section |