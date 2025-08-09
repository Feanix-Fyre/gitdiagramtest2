# ContactsApp

The `ContactsApp` class is the UI for the contacts app on the phone. It displays a list of all the NPCs that the player has met, and it allows the player to view information about each NPC.

## Classes

### RegionUI

This class is a container for the UI elements of a single region.

-   `Region`: The `EMapRegion` of the region.
-   `Button`: The `Button` to select the region.
-   `Container`: The `RectTransform` for the container.
-   `ConnectionsContainer`: The `RectTransform` for the connections container.
-   `npcs`: A list of all the NPCs in the region.

## Public Properties

| Property                   | Type                      | Description                                      |
| -------------------------- | ------------------------- | ------------------------------------------------ |
| `SelectedRegion`           | `EMapRegion`              | The currently selected region.                   |
| `CirclesContainer`         | `RectTransform`           | The container for the relation circles.          |
| `DemoCirclesContainer`     | `RectTransform`           | The container for the relation circles in the demo. |
| `TutorialCirclesContainer` | `RectTransform`           | The container for the relation circles in the tutorial. |
| `ConnectionsContainer`     | `RectTransform`           | The container for the connections.               |
| `ContentRect`              | `RectTransform`           | The `RectTransform` for the content.             |
| `SelectionIndicator`       | `RectTransform`           | The indicator for the selected relation circle.  |
| `DetailPanel`              | `ContactsDetailPanel`     | The detail panel for the selected NPC.           |
| `RegionUIs`                | `RegionUI[]`              | An array of all the region UIs.                  |
| `RegionSelectionContainer` | `RectTransform`           | The container for the region selection.          |
| `RegionSelectionIndicator` | `RectTransform`           | The indicator for the selected region.           |
| `LockedRegionContainer`    | `RectTransform`           | The container for the locked region UI.          |
| `RegionRankRequirementLabel`| `Text`                   | The label for the rank requirement of a region.  |
| `SelectedRegionIcon`       | `Image`                   | The icon for the selected region.                |
| `ConnectionPrefab`         | `GameObject`              | The prefab for the connections.                  |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `SetOpen(bool open)`                        | `void`      | Opens or closes the app.                         |
| `SetSelectedRegion(EMapRegion region)`      | `void`      | Sets the selected region.                        |
| `Select(RelationCircle circ)`               | `void`      | Selects a relation circle.                       |
