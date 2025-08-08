# StorageEntityVisualizer

The `StorageEntityVisualizer` class is responsible for visualizing the contents of a `StorageEntity`. It inherits from the `StorageVisualizer` class.

## Methods

### `Start()`

Called when the script instance is being loaded. This method gets the `StorageEntity` component, adds a listener to the `onContentsChanged` event, adds all the item slots from the storage entity to the visualizer, and queues a refresh if the storage entity is not empty.
