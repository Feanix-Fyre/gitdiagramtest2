# VisionEvent

The `VisionEvent` class represents a single instance of a `VisionCone` detecting a `Player`. It manages the "notice level" of the event, which is a value that increases when the player is visible and decreases when they are not. When the notice level reaches certain thresholds, it triggers methods on the `VisionCone` that owns the event.

## Properties

-   `Target`: The `Player` that is the target of this vision event.
-   `State`: The `PlayerVisualState.VisualState` of the player when the event was created.
-   `Owner`: The `VisionCone` that created and owns this event.
-   `FullNoticeTime`: The time it takes for the notice level to reach 100% when the player is fully visible.
-   `NormalizedNoticeLevel`: The current notice level, normalized to a value between 0 and 1.

## Methods

-   `UpdateEvent(float visionDeltaThisFrame, float tickTime)`: Updates the notice level of the event based on how visible the player was in the last frame.
-   `EndEvent()`: Called when the event is over (e.g., the notice level has reached zero). It notifies the `VisionCone` owner that the event has ended.
