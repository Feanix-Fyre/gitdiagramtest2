# MessageBubble

The `MessageBubble` class is the UI for a single message bubble in the messaging app.

## Enums

### Alignment

This enum defines the different alignments for a message bubble.

-   `Center`: The bubble is aligned to the center.
-   `Left`: The bubble is aligned to the left.
-   `Right`: The bubble is aligned to the right.

## Public Properties

| Property              | Type        | Description                                      |
| --------------------- | ----------- | ------------------------------------------------ |
| `text`                | `string`    | The text to display in the bubble.               |
| `alignment`           | `Alignment` | The alignment of the bubble.                     |
| `showTriangle`        | `bool`      | A boolean that indicates whether to show the triangle. |
| `bubble_MinWidth`     | `float`     | The minimum width of the bubble.                 |
| `bubble_MaxWidth`     | `float`     | The maximum width of the bubble.                 |
| `alignTextCenter`     | `bool`      | A boolean that indicates whether to align the text to the center. |
| `autosetPosition`     | `bool`      | A boolean that indicates whether to automatically set the position of the bubble. |
| `container`           | `RectTransform` | The container for the bubble.                    |
| `button`              | `Button`    | The button component for the bubble.             |
| `height`              | `float`     | The height of the bubble.                        |
| `spacingAbove`        | `float`     | The spacing above the bubble.                    |
| `backgroundColor_Left`| `Color32`   | The background color for left-aligned bubbles.   |
| `textColor_Left`      | `Color32`   | The text color for left-aligned bubbles.         |
| `backgroundColor_Right`| `Color32`  | The background color for right-aligned bubbles.  |
| `textColor_Right`     | `Color32`   | The text color for right-aligned bubbles.        |
| `baseBubbleSpacing`   | `float`     | The base spacing for bubbles.                    |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `SetupBubble(string _text, Alignment _alignment, bool alignCenter = false)` | `void` | Sets up the bubble with the specified text and alignment. |
| `RefreshDisplayedText()`                    | `void`      | Refreshes the displayed text.                    |
