# StorageVisualizationUtility

The `StorageVisualizationUtility` class is a static utility class that provides methods for visualizing the contents of a storage container.

## Methods

### `GetVisualRepresentation(Dictionary<StorableItemInstance, int> inputDictionary, int TotalFootprintSize)`

Gets a visual representation of the contents of a storage container. This method takes a dictionary of storable items and their quantities and returns a dictionary of storable items and the number of times they should be displayed in the visual representation.

**Parameters:**

* `inputDictionary`: A dictionary of storable items and their quantities.
* `TotalFootprintSize`: The total footprint size of the storage container.

**Returns:** `Dictionary<StorableItemInstance, int>`
