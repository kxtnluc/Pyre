# Toolbar

### Basic Toolbar
```html
<Toolbar OnAdd="OpenModal"
         OnManage="OpenModalTwo"
         Position="E_TOOLBAR_POSITION.BottomRight"
         Size="E_SIZE.md"
         TooltipSubject="Bank" />
```

> Note: The Toolbar doesn't need to be placed in any specific spot in the markup, as its position on screen is controlled entirely by the `Position` parameter (absolute positioning).

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| OnAdd | - | Callback fired when the toolbar's Add action is clicked |
| OnManage | - | Callback fired when the toolbar's Manage action is clicked |
| Position | - | Controls where the toolbar renders on screen via E_TOOLBAR_POSITION (e.g. BottomRight) |
| Size | - | Controls the size of the toolbar via E_SIZE (sm-md-lg) |
| TooltipSubject | - | The subject/entity name inserted into the toolbar's tooltip text (e.g. "Bank") |