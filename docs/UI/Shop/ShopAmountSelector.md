# ShopAmountSelector

The `ShopAmountSelector` class is a UI component that allows the player to select an amount of an item to buy.

## Public Properties

| Property      | Type            | Description                                      |
| ------------- | --------------- | ------------------------------------------------ |
| `Container`   | `RectTransform` | The container for the UI elements.               |
| `InputField`  | `TMP_InputField`| The input field for the amount.                  |
| `onSubmitted` | `UnityEvent<int>` | An event that is invoked when the amount is submitted. |
| `IsOpen`      | `bool`          | A boolean that indicates whether the amount selector is open. |
| `SelectedAmount`| `int`           | The selected amount.                             |

## Public Methods

| Method  | Return Type | Description                                      |
| ------- | ----------- | ------------------------------------------------ |
| `Open()`  | `void`      | Opens the amount selector.                       |
| `Close()` | `void`      | Closes the amount selector.                      |
