# Input

### Basic Input
```html
<Input 
    Label="Cool Label" 
    InputType="E_INPUT_TYPE.Text" 
    @bind-Value="inputText" 
/>
```

## Variable Examples

```csharp
string inputText = "";

private void OnInputChange()
{
    // TODO
}
```

## Input Types

Using E_INPUT_TYPE, the following input types are available.

- Text
- Email
- Password
- Url
- Search
- Tel (telephone)