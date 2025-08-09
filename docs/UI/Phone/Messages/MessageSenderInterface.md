# MessageSenderInterface

The `MessageSenderInterface` class is the UI for the message sender interface in the phone's messaging app. It allows the player to compose and send messages.

## Enums

### EVisibility

This enum defines the different visibility states of the interface.

-   `Hidden`: The interface is hidden.
-   `Docked`: The interface is docked at the bottom of the screen.
-   `Expanded`: The interface is expanded to fill the screen.

## Public Properties

| Property           | Type          | Description                                      |
| ------------------ | ------------- | ------------------------------------------------ |
| `Visibility`       | `EVisibility` | The current visibility state of the interface.   |
| `DockedMenuYPos`   | `float`       | The Y position of the menu when it is docked.    |
| `ExpandedMenuYPos` | `float`       | The Y position of the menu when it is expanded.  |
| `Menu`             | `RectTransform` | The `RectTransform` for the menu.                |
| `SendablesContainer` | `RectTransform` | The container for the sendable messages.         |
| `DockedUIElements` | `RectTransform[]` | An array of UI elements to show when the interface is docked. |
| `ExpandedUIElements`| `RectTransform[]` | An array of UI elements to show when the interface is expanded. |
| `ComposeButton`    | `Button`        | The button to compose a new message.             |
| `CancelButtons`    | `Button[]`      | An array of buttons to cancel composing a message. |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `Awake()`                                   | `void`      | Initializes the component.                       |
| `Start()`                                   | `void`      | Called when the component is started.            |
| `SetVisibility(EVisibility visibility)`     | `void`      | Sets the visibility of the interface.            |
| `UpdateSendables()`                         | `void`      | Updates the list of sendable messages.           |
| `AddSendable(SendableMessage sendable)`     | `void`      | Adds a sendable message to the list.             |
