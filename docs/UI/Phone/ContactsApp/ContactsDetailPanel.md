# ContactsDetailPanel

The `ContactsDetailPanel` class is the UI for the detail panel in the contacts app. It displays information about an NPC, such as their name, type, relationship, and addiction. It also has a button to show the NPC on the map.

## Public Properties

| Property                | Type                | Description                                      |
| ----------------------- | ------------------- | ------------------------------------------------ |
| `DependenceColor_Min`   | `Color`             | The color to use for the dependence label when the dependence level is low. |
| `DependenceColor_Max`   | `Color`             | The color to use for the dependence label when the dependence level is high. |
| `LayoutGroup`           | `VerticalLayoutGroup` | The layout group for the UI.                     |
| `NameLabel`             | `Text`              | The label for the NPC's name.                    |
| `TypeLabel`             | `Text`              | The label for the NPC's type.                    |
| `UnlockHintLabel`       | `Text`              | The label for the unlock hint.                   |
| `RelationshipContainer` | `RectTransform`     | The container for the relationship UI.           |
| `RelationshipScrollbar` | `Scrollbar`         | The scrollbar for the relationship UI.           |
| `RelationshipLabel`     | `Text`              | The label for the relationship.                  |
| `AddictionContainer`    | `RectTransform`     | The container for the addiction UI.              |
| `AddictionScrollbar`    | `Scrollbar`         | The scrollbar for the addiction UI.              |
| `AddictionLabel`        | `Text`              | The label for the addiction.                     |
| `PropertiesContainer`   | `RectTransform`     | The container for the properties UI.             |
| `PropertiesLabel`       | `Text`              | The label for the properties.                    |
| `ShowOnMapButton`       | `Button`            | The button to show the NPC on the map.           |
| `StandardsContainer`    | `RectTransform`     | The container for the standards UI.              |
| `StandardsStar`         | `Image`             | The image for the standards star.                |
| `StandardsLabel`        | `Text`              | The label for the standards.                     |
| `SelectedNPC`           | `NPC`               | The currently selected NPC.                      |

## Public Methods

| Method           | Return Type | Description                                      |
| ---------------- | ----------- | ------------------------------------------------ |
| `Open(NPC npc)`  | `void`      | Opens the detail panel for an NPC.               |
| `ShowOnMap()`    | `void`      | Shows the NPC on the map.                        |
