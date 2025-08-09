# DryingRackCanvas

The `DryingRackCanvas` class is a singleton that manages the UI for a drying rack.

## Public Properties

| Property           | Type                | Description                                      |
| ------------------ | ------------------- | ------------------------------------------------ |
| `Canvas`           | `Canvas`            | The canvas for the UI.                           |
| `Container`        | `RectTransform`     | The container for the UI elements.               |
| `InputSlotUI`      | `ItemSlotUI`        | The UI for the input slot.                       |
| `OutputSlotUI`     | `ItemSlotUI`        | The UI for the output slot.                      |
| `InstructionLabel` | `TextMeshProUGUI`   | The label for the instructions.                  |
| `CapacityLabel`    | `TextMeshProUGUI`   | The label for the capacity.                      |
| `InsertButton`     | `Button`            | The button to insert items.                      |
| `IndicatorContainer` | `RectTransform`     | The container for the drying operation indicators. |
| `IndicatorAlignments`| `RectTransform[]` | An array of `RectTransform`s for the indicator alignments. |
| `IndicatorPrefab`  | `DryingOperationUI` | The prefab for the drying operation indicator.   |
| `isOpen`           | `bool`              | A boolean that indicates whether the UI is open. |
| `Rack`             | `DryingRack`        | The `DryingRack` that this UI belongs to.      |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `SetIsOpen(DryingRack rack, bool open)`     | `void`      | Opens or closes the UI.                          |
| `Insert()`                                  | `void`      | Starts a new drying operation.                   |
