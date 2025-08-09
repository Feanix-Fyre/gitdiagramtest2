# DryingOperationUI

The `DryingOperationUI` class is the UI for a drying operation on a drying rack. It displays the icon and quantity of the item being dried, as well as a tooltip with the time remaining until the next quality tier. It also has a button that can be used to end the operation.

## Public Properties

| Property            | Type              | Description                                      |
| ------------------- | ----------------- | ------------------------------------------------ |
| `Rect`              | `RectTransform`   | The `RectTransform` of the UI.                   |
| `Icon`              | `Image`           | The `Image` for the item's icon.                 |
| `QuantityLabel`     | `TextMeshProUGUI` | The `TextMeshProUGUI` for the item's quantity.   |
| `Button`            | `Button`          | The `Button` to end the operation.               |
| `Tooltip`           | `Tooltip`         | The `Tooltip` for the time remaining.            |
| `AssignedOperation` | `DryingOperation` | The `DryingOperation` that this UI represents.   |
| `Alignment`         | `RectTransform`   | The `RectTransform` to align to.                 |

## Public Methods

| Method                  | Return Type | Description                                      |
| ----------------------- | ----------- | ------------------------------------------------ |
| `SetOperation(DryingOperation operation)` | `void`      | Sets the `DryingOperation` for this UI.          |
| `SetAlignment(RectTransform alignment)` | `void`      | Sets the alignment for this UI.                  |
| `RefreshQuantity()`     | `void`      | Refreshes the quantity label.                    |
| `Start()`               | `void`      | Initializes the component.                       |
| `UpdatePosition()`      | `void`      | Updates the position of the UI.                  |
