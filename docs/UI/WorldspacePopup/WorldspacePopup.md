# WorldspacePopup

The `WorldspacePopup` class represents a popup that appears in the world space. It can be displayed on the HUD as well as in the world, and it can be scaled with distance.

## Public Properties

| Property           | Type                      | Description                                      |
| ------------------ | ------------------------- | ------------------------------------------------ |
| `ActivePopups`     | `List<WorldspacePopup>`   | A static list of all the active popups.          |
| `CurrentFillLevel` | `float`                   | The current fill level of the popup.             |
| `UIPrefab`         | `WorldspacePopupUI`       | The prefab for the popup's UI.                   |
| `DisplayOnHUD`     | `bool`                    | A boolean that indicates whether the popup should be displayed on the HUD. |
| `ScaleWithDistance`| `bool`                    | A boolean that indicates whether the popup should be scaled with distance. |
| `WorldspaceOffset` | `Vector3`                 | The offset of the popup in world space.          |
| `Range`            | `float`                   | The range of the popup.                          |
| `SizeMultiplier`   | `float`                   | A multiplier for the size of the popup.          |
| `WorldspaceUI`     | `WorldspacePopupUI`       | The UI for the worldspace popup.                 |
| `HUDUI`            | `RectTransform`           | The UI for the HUD popup.                        |
| `HUDUIIcon`        | `WorldspacePopupUI`       | The icon for the HUD popup.                      |
| `HUDUICanvasGroup` | `CanvasGroup`             | The canvas group for the HUD popup.              |

## Public Methods

| Method                  | Return Type         | Description                                      |
| ----------------------- | ------------------- | ------------------------------------------------ |
| `CreateUI(RectTransform parent)` | `WorldspacePopupUI` | Creates the UI for the popup.                    |
| `Popup()`               | `void`              | Animates the popup.                              |
