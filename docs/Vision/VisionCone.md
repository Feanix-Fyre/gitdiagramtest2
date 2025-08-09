# VisionCone

The `VisionCone` class is a `NetworkBehaviour` that represents the vision of an NPC. It defines a view frustum and can detect players within it, considering factors like line of sight, distance, and player visibility. It creates and manages `VisionEvent`s to track how "noticed" a player is. It also handles network communication to synchronize vision events between the server and clients.

## Enums

### EEventLevel

This enum defines the different levels of a vision event.

-   `Start`: The event has just started.
-   `Half`: The event is halfway to being fully noticed.
-   `Full`: The event is fully noticed.
-   `Zero`: The event has expired (the notice level has returned to zero).

## Classes

### StateContainer

This class is a container for the settings of a specific `PlayerVisualState.EVisualState`.

-   `state`: The `PlayerVisualState.EVisualState` that this container represents.
-   `Enabled`: Whether this state is currently being watched for.
-   `RequiredNoticeTime`: The time it takes for this state to be fully noticed.

### PlayerSightData

This class holds data about a player that is currently within the vision cone.

-   `Player`: The `Player` that is being seen.
-   `VisionDelta`: A value representing how much the player is visible in the current frame.
-   `TimeVisible`: The total time the player has been visible.

## Properties

-   `DisableSightUpdates`: If true, the vision cone will not be updated.
-   `HorizontalFOV`: The horizontal field of view of the vision cone.
-   `VerticalFOV`: The vertical field of view of the vision cone.
-   `Range`: The maximum range of the vision cone.
-   `MinorWidth`: The width of the near plane of the vision cone.
-   `MinorHeight`: The height of the near plane of the vision cone.
-   `VisionOrigin`: The transform from which the vision cone originates.
-   `DEBUG_FRUSTRUM`: If true, the frustum will be drawn in the editor.
-   `VisionEnabled`: If false, the vision cone will be disabled.
-   `VisionFalloff`: An animation curve that defines how vision is affected by distance.
-   `VisibilityBlockingLayers`: The layers that can block the vision of the cone.
-   `RangeMultiplier`: A multiplier for the range of the vision cone.
-   `StatesOfInterest`: A list of `StateContainer`s that define which player states the vision cone is interested in.
-   `MinVisionDelta`: The minimum vision delta required to create a `VisionEvent`.
-   `Attentiveness`: A multiplier for how quickly the notice level of a `VisionEvent` increases.
-   `Memory`: A multiplier for how long a `VisionEvent` is remembered after the player is no longer visible.
-   `WorldspaceIconsEnabled`: If true, worldspace icons (question marks, exclamation points) will be displayed above the target.
-   `QuestionMarkPopup`: The `WorldspacePopup` to display when a player is being noticed.
-   `ExclamationPointPopup`: The `WorldspacePopup` to display when a player is fully noticed.
-   `ExclamationSound`: The sound to play when a player is fully noticed.

## Events

-   `onVisionEventStarted`: An event that is fired when a new `VisionEvent` is started.
-   `onVisionEventHalf`: An event that is fired when a `VisionEvent` is halfway to being fully noticed.
-   `onVisionEventFull`: An event that is fired when a `VisionEvent` is fully noticed.
-   `onVisionEventExpired`: An event that is fired when a `VisionEvent` expires.

## Methods

-   `IsPointWithinSight(Vector3 point, bool ignoreLoS = false, LandVehicle vehicleToIgnore = null)`: Checks if a point is within the vision cone.
-   `GetEvent(Player target, PlayerVisualState.VisualState state)`: Gets the `VisionEvent` for a specific player and state.
-   `IsPlayerVisible(Player player)`: Checks if a player is currently visible.
-   `GetPlayerVisibility(Player player)`: Gets the visibility of a player.
-   `IsPlayerVisible(Player player, out PlayerSightData data)`: Checks if a player is currently visible and returns the `PlayerSightData`.
-   `SetGeneralCrimeResponseActive(Player player, bool active)`: Sets whether the vision cone should respond to general crime.
-   `ClearEvents()`: Clears all active vision events.
