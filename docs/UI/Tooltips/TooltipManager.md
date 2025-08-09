# TooltipManager

The `TooltipManager` class is a singleton that manages the display of tooltips. It checks for tooltips on UI elements that the mouse is hovering over, and it displays the tooltip text in a floating panel.

## Public Properties

| Property | Type             | Description                                      |
| -------- | ---------------- | ------------------------------------------------ |
| `canvases` | `List<Canvas>` | A list of all the canvases to check for tooltips. |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `AddCanvas(Canvas canvas)`                  | `void`      | Adds a canvas to the list of canvases to check.  |
| `ShowTooltip(string text, Vector2 position, bool worldspace)` | `void` | Shows a tooltip with the specified text and position. |
