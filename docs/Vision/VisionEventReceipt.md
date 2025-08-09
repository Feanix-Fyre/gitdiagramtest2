# VisionEventReceipt

The `VisionEventReceipt` class is a serializable data container that holds information about a vision event. It is used to pass information about what was seen and by whom.

## Properties

-   `TargetPlayer`: A `NetworkObject` that represents the player who was the target of the vision event.
-   `State`: A `PlayerVisualState.EVisualState` enum value that represents the visual state of the player when the event occurred.

## Constructors

-   `VisionEventReceipt(NetworkObject targetPlayer, PlayerVisualState.EVisualState state)`: Creates a new instance of the `VisionEventReceipt` class with the specified target player and visual state.
-   `VisionEventReceipt()`: Creates a new, empty instance of the `VisionEventReceipt` class.
