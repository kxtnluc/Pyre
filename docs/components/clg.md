# ConsumptionLineGraph

### Basic Consumption Line Graph
```html
<ConsumptionLineGraph 
    DataSet="exampleDictionary" 
/>
```

### Status Variants
```html
<ConsumptionLineGraph 
    DataSet="exampleDictionary" 
    Variant="E_STATUS.Negative" 
/>

<ConsumptionLineGraph 
    DataSet="exampleDictionary" 
    Variant="E_STATUS.Neutral" 
/>
```

> Renders a line graph intended to visualize percentage of datapoint in regards to the sum, like a pie chart, but more spacially efficient.

### Example Dictionary Dataset
```csharp
	public Dictionary<string, double> exampleDictionary { get; set; } = new Dictionary<string, double>
	{
		{ "1", 5341}, { "2", 1211 },  { "3", 3281 }, { "4", 3281 }, { "5", 2222 }, { "6", 5738 }
	};
```

## Parameters

| Parameter | Required | Description |
| :---------: | :------: | ----------: |
| DataSet | Yes | The Dataset that the graph represents |
| Variant | - | Controls the color/status styling of the graph line via E_STATUS (Positive, Negative, Neutral) |