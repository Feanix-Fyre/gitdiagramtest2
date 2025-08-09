# GameInput

The `GameInput` class is a persistent singleton responsible for managing all player input. It uses Unity's Input System to handle various actions and provides a centralized way to access input state.

## Enums

### `ButtonCode`

This enum defines all possible input actions that the player can perform.

| Member | Description |
| --- | --- |
| `PrimaryClick` | Primary mouse button click. |
| `SecondaryClick` | Secondary mouse button click. |
| ... | ... |
| `Reload` | Reloads the player's weapon. |

## Nested Classes

### `ExitListener`

This class represents a listener for the "exit" or "back" action (e.g., pressing the Escape key).

-   `listenerFunction`: The delegate function to be called.
-   `priority`: The priority of the listener, which determines the order of execution.

## Delegates

### `ExitDelegate(ExitAction exitAction)`

A delegate for handling exit actions.

## Properties

-   `PlayerInput`: The `PlayerInput` component that handles the input actions.
-   `IsTyping`: A static boolean that indicates whether the player is currently typing in an input field.
-   `MotionAxis`: A static `Vector2` that represents the movement input axis (e.g., from a joystick or WASD keys).
-   `MouseDelta`: A static `Vector2` representing the mouse movement since the last frame.
-   `MousePosition`: A static `Vector3` representing the current mouse position in screen coordinates.
-   `MouseScrollDelta`: A static float representing the mouse scroll wheel delta.

## Methods

### `GetButton(ButtonCode buttonCode)`

Returns `true` if the specified button is currently held down.

### `GetButtonDown(ButtonCode buttonCode)`

Returns `true` during the frame the user pressed the specified button.

### `GetButtonUp(ButtonCode buttonCode)`

Returns `true` during the frame the user released the specified button.

### `RegisterExitListener(ExitDelegate listener, int priority = 0)`

Registers a new listener for the exit action.

### `DeregisterExitListener(ExitDelegate listener)`

Deregisters an exit listener.

### `GetAction(ButtonCode code)`

Returns the `InputAction` associated with the given `ButtonCode`.
