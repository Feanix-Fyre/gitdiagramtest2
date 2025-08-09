# UtilitiesApp

The `UtilitiesApp` class is the UI for the utilities app on the phone. It displays information about the player's water and electricity usage, as well as the cost of emptying their dumpsters.

## Protected Properties

| Property            | Type               | Description                                      |
| ------------------- | ------------------ | ------------------------------------------------ |
| `water_Usage`       | `Text`             | The label for the water usage.                   |
| `water_Cost`        | `Text`             | The label for the water cost.                    |
| `water_Total`       | `Text`             | The label for the total water cost.              |
| `electricity_Usage` | `Text`             | The label for the electricity usage.             |
| `electricity_Cost`  | `Text`             | The label for the electricity cost.              |
| `electricity_Total` | `Text`             | The label for the total electricity cost.        |
| `dumpster_Count`    | `Text`             | The label for the number of dumpsters.           |
| `dumpster_EmptyCost`| `Text`             | The label for the cost of emptying a dumpster.   |
| `dumpster_Total`    | `Text`             | The label for the total cost of emptying the dumpsters. |
| `dumpsterButton`    | `Button`           | The button to empty the dumpsters.               |
| `propertySelector`  | `PropertyDropdown` | The dropdown to select a property.               |

## Public Methods

| Method               | Return Type | Description                                      |
| -------------------- | ----------- | ------------------------------------------------ |
| `SetOpen(bool open)` | `void`      | Opens or closes the app.                         |

## Protected Methods

| Method                | Return Type | Description                                      |
| --------------------- | ----------- | ------------------------------------------------ |
| `Awake()`             | `void`      | Initializes the component.                       |
| `OnDestroy()`         | `void`      | Called when the component is destroyed.          |
| `Update()`            | `void`      | Updates the component.                           |
| `RefreshShownValues()`| `void`      | Refreshes the values shown in the UI.            |
| `OnDayPass()`         | `void`      | Called when a day passes.                        |
