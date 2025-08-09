# ACAssetPathReplicator<T>

The `ACAssetPathReplicator<T>` class is a generic component used in the avatar customization system. It is responsible for replicating asset path selections, ensuring that the visual representation of the avatar matches the selected settings.

## Generic Parameters

-   `T`: The type of `Object` that this replicator handles.

## Methods

### `Awake()`

Initializes the component by getting a reference to the `ACSelection<T>` component on the same `GameObject`.

### `AvatarSettingsChanged(AvatarSettings newSettings)`

This method is called when the avatar's settings have changed. It updates the `ACSelection<T>` component to select the option that corresponds to the new asset path in the `AvatarSettings`.
