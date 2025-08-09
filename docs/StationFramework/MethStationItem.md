# MethStationItem

The `MethStationItem` class is a type of `StationItem` that represents a meth item in a station. It initializes the visual appearance of the meth item.

## Public Properties

| Property | Type                       | Description                                                     |
| -------- | -------------------------- | --------------------------------------------------------------- |
| `Visuals`| `FilledPackagingVisuals[]` | An array of `FilledPackagingVisuals` to be applied to the meth item. |

## Public Methods

| Method                                      | Return Type | Description                                                                    |
| ------------------------------------------- | ----------- | ------------------------------------------------------------------------------ |
| `Initialize(StorableItemDefinition itemDefinition)` | `void`      | Initializes the `MethStationItem` with the given `itemDefinition`. This method is an override of the base `StationItem.Initialize` method. |
