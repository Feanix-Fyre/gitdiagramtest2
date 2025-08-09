# MapApp

The `MapApp` class is the UI for the map app on the phone. It displays a map of the world, and it can focus on a specific position.

## Public Constants

| Constant       | Type  | Description                                      |
| -------------- | ----- | ------------------------------------------------ |
| `KeyMoveSpeed` | `float` | The speed at which the map moves when using the keys. |

## Public Properties

| Property              | Type            | Description                                      |
| --------------------- | --------------- | ------------------------------------------------ |
| `ContentRect`         | `RectTransform` | The `RectTransform` for the map content.         |
| `PoIContainer`        | `RectTransform` | The container for the points of interest.        |
| `HorizontalScrollbar` | `Scrollbar`     | The horizontal scrollbar for the map.            |
| `VerticalScrollbar`   | `Scrollbar`     | The vertical scrollbar for the map.              |
| `BackgroundImage`     | `Image`         | The background image for the map.                |
| `LabelGroup`          | `CanvasGroup`   | The canvas group for the labels.                 |
| `DemoMapSprite`       | `Sprite`        | The sprite for the demo map.                     |
| `MainMapSprite`       | `Sprite`        | The sprite for the main map.                     |
| `TutorialMapSprite`   | `Sprite`        | The sprite for the tutorial map.                 |
| `LabelScrollMin`      | `float`         | The minimum scroll value for the labels to be visible. |
| `LabelScrollMax`      | `float`         | The maximum scroll value for the labels to be fully visible. |
| `SkipFocusPlayer`     | `bool`          | If true, the map will not focus on the player when it is opened. |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `SetOpen(bool open)`                        | `void`      | Opens or closes the app.                         |
| `FocusPosition(Vector2 anchoredPosition)`   | `void`      | Focuses the map on a specific position.          |
