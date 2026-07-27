# Card

### Simple Card (with Click Wrapper + data point content/footer)
```html
<ClickWraper OnClick="@(() => ButtonClick_DI("ButtonWrapperClick"))">
    <Card Variant="E_CARD.Raised" HoverEffects="true">
        <CardHeader>
            <CardTitle>
                <Icon>
                    <HouseIcon Size="22" />
                </Icon>
                <Title>East TN Home in the country</Title>
            </CardTitle>
        </CardHeader>
        <CardContent IsDataPoint="true">$400,000</CardContent>
        <CardFooter IsDataPoint="true" DataStatus="E_STATUS.Neutral">
            $32,918
        </CardFooter>
    </Card>
</ClickWraper>
```

### Full Card (header, description, content, footer)
```html
<Card Variant="E_CARD.Flat">
    <CardHeader>
        <CardTitle>
            <Icon>
                <GearIcon Size="28" />
            </Icon>
            <Title>
                Bank Settings
            </Title>
        </CardTitle>
        <CardDescription>A short description of what this card represents</CardDescription>
    </CardHeader>
    <CardContent>Card content goes here</CardContent>
    <CardFooter>Action</CardFooter>
</Card>
```

### Card with Header Action
```html
<Card Variant="E_CARD.Raised">
    <CardHeader>
        <CardTitle>
            <Icon>
                <OpenWindowIcon Size="28" />
            </Icon>
            <Title>
                Window or smth
            </Title>
        </CardTitle>
        <CardDescription>A short description of what this card represents</CardDescription>
        <CardAction>
            <Button Color="E_COLOR_BASIC.Remove">Delete</Button>
        </CardAction>
    </CardHeader>
    <CardContent>Card content goes here</CardContent>
    <CardFooter>Action</CardFooter>
</Card>
```

### Inset Card
```html
<Card Variant="E_CARD.Inset">
    <CardContent>Inset</CardContent>
</Card>
```

## Sub-Components

| Component | Description |
| :---------: | ----------: |
| CardHeader | Wraps the title, description, and optional action row at the top of the card |
| CardTitle | Wraps the optional Icon and Title inside the header |
| Icon | Wraps an icon element to render beside the title |
| Title | The main heading text of the card |
| CardDescription | Secondary descriptive text rendered under the title |
| CardAction | An optional action (e.g. a Button) rendered in the header, typically top-right |
| CardContent | The main body of the card. Supports IsDataPoint for styling numeric/dollar values |
| CardFooter | The bottom section of the card. Supports IsDataPoint and DataStatus for styled data callouts |

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| Variant | - | Controls the card's visual style via E_CARD (Raised, Flat, Inset) |
| HoverEffects | - | Boolean. Enables hover styling on the card, typically used when wrapped in a ClickWraper |
| IsDataPoint (CardContent/CardFooter) | - | Boolean. Styles the content/footer as a data point (e.g. a dollar figure) |
| DataStatus (CardFooter) | - | Controls the color/status styling of a data point footer via E_STATUS (Positive, Negative, Neutral) |