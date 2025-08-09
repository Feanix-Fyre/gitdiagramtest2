# CurfewInstance

A serializable class that defines the parameters and manages the state for a city-wide curfew.

## Description

This class represents a potential curfew that can be activated or deactivated based on the game's "Law Enforcement Intensity" level. It is managed by the `LawController` and communicates with the `CurfewManager` to enact the curfew's effects.

## Fields

-   **ActiveInstance**: `static CurfewInstance`
    -   A static reference to the currently active curfew instance.
-   **IntensityRequirement**: `int`
    -   The minimum "Law Enforcement Intensity" level required for this curfew to become active.
-   **shouldDisable**: `bool`
    -   A flag that gets set when the intensity drops below the requirement, marking the curfew to be disabled the next time the player sleeps.

## Properties

-   **Enabled**: `bool` (read-only)
    -   True if this curfew instance is currently active.

## Core Logic

-   **Evaluation (`Evaluate`)**: This method is called periodically by the `LawController`. It checks if the `LE_Intensity` has met the `IntensityRequirement` and if the player is sleeping. If both are true, it calls `Enable()`.
-   **Minute Pass (`MinPass`)**: Once enabled, this method is subscribed to the `TimeManager.onMinutePass` event.
    -   It checks if the `LE_Intensity` has dropped below the requirement. If so, it sets `shouldDisable` to true.
    -   If `shouldDisable` is true and the player starts sleeping, it calls `Disable()`.
-   **Activation (`Enable`)**: Sets this instance as the `ActiveInstance`, marks it as `Enabled`, subscribes `MinPass` to the time manager, and calls `Enable` on the `CurfewManager` singleton to apply the actual gameplay effects of the curfew.
-   **Deactivation (`Disable`)**: Marks the curfew as disabled, unsubscribes from the time manager, and calls `Disable` on the `CurfewManager` to remove the curfew's effects.

## Public Methods

### Evaluate
`public void Evaluate(bool ignoreSleepReq = false)`

Checks if the conditions are met to enable the curfew.

### Enable
`public void Enable()`

Activates the curfew.

### Disable
`public void Disable()`

Deactivates the curfew.
