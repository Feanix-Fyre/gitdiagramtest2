# WorldspacePopupUI

The `WorldspacePopupUI` class is the UI component for a worldspace popup.

## Public Properties

| Property    | Type              | Description                                      |
| ----------- | ----------------- | ------------------------------------------------ |
| `Popup`     | `WorldspacePopup` | The `WorldspacePopup` that this UI belongs to.   |
| `Rect`      | `RectTransform`   | The `RectTransform` of the popup.                |
| `FillImage` | `Image`           | The `Image` for the fill effect.                 |
| `onDestroyed` | `UnityEvent`      | An event that is invoked when the popup is destroyed. |

## Public Methods

| Method        | Return Type | Description                           |
| ------------- | ----------- | ------------------------------------- |
| `SetFill(float fill)` | `void`      | Sets the fill amount of the `FillImage`. |
| `Destroy()`     | `void`      | Destroys the popup.                   |
