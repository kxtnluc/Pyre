# ClickWraper

### Basic ClickWraper (wrapping a Card)
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

> ClickWraper is a generic wrapper that makes any child content clickable without that child needing its own click handling built in. It's commonly paired with `Card` + `HoverEffects="true"` to make an entire card act as a clickable element.

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| OnClick | Yes | The callback function fired when anywhere inside the wrapped content is clicked |
| ChildContent | Yes | The element(s) being wrapped and made clickable |