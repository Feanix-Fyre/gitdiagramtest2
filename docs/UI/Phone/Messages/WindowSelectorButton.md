# WindowSelectorButton

The `WindowSelectorButton` class is a UI component for a button that selects a deal window in the phone's messaging app.

## Public Constants

| Constant                  | Type  | Description                                      |
| ------------------------- | ----- | ------------------------------------------------ |
| `SELECTION_INDICATOR_SCALE` | `float` | The scale of the hover indicator when it is shown. |
| `INDICATOR_LERP_TIME`     | `float` | The time it takes for the hover indicator to scale up or down. |

## Public Properties

| Property        | Type            | Description                                      |
| --------------- | --------------- | ------------------------------------------------ |
| `OnSelected`    | `UnityEvent`    | An event that is invoked when the button is selected. |
| `WindowType`    | `EDealWindow`   | The type of deal window that this button selects. |
| `Button`        | `Button`        | The `Button` component for this button.          |
| `InactiveOverlay` | `GameObject`    | The overlay to show when the button is inactive. |
| `HoverIndicator`| `RectTransform` | The `RectTransform` for the hover indicator.     |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `SetInteractable(bool interactable)`        | `void`      | Sets whether the button is interactable.         |
| `HoverStart()`                              | `void`      | Called when the mouse starts hovering over the button. |
| `HoverEnd()`                                | `void`      | Called when the mouse stops hovering over the button. |
| `Clicked()`                                 | `void`      | Called when the button is clicked.               |
| `SetHoverIndicator(bool shown)`             | `void`      | Shows or hides the hover indicator.              |
