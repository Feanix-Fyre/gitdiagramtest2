# ShopColorPicker

The `ShopColorPicker` class is a UI component that allows the player to pick a color for a piece of clothing.

## Public Properties

| Property            | Type                       | Description                                      |
| ------------------- | -------------------------- | ------------------------------------------------ |
| `AssetIconImage`    | `Image`                    | The image for the item's icon.                   |
| `ColorLabel`        | `TextMeshProUGUI`          | The label for the selected color.                |
| `ColorButtonParent` | `RectTransform`            | The parent transform for the color buttons.      |
| `ColorButtonPrefab` | `GameObject`               | The prefab for the color buttons.                |
| `onColorPicked`     | `UnityEvent<EClothingColor>` | An event that is invoked when a color is picked. |
| `IsOpen`            | `bool`                     | A boolean that indicates whether the color picker is open. |

## Public Methods

| Method                  | Return Type | Description                                      |
| ----------------------- | ----------- | ------------------------------------------------ |
| `Start()`               | `void`      | Initializes the component.                       |
| `Open(ItemDefinition item)` | `void`      | Opens the color picker for an item.              |
| `Close()`               | `void`      | Closes the color picker.                         |
