# LawController

Inherits from `Singleton<LawController>` and implements `IBaseSaveable`, `ISaveable`.

## Description

This singleton class is the central controller for the game's law enforcement system. It manages the overall "Law Enforcement Intensity" level and uses this, along with the day of the week, to determine which police activities (patrols, checkpoints, curfews) should be active.

## Fields

-   **LE_Intensity**: `int`
    -   The public-facing Law Enforcement Intensity level, on a scale of 1 to 10. This value is derived from `internalLawIntensity`.
-   **MondaySettings / TuesdaySettings / etc.**: `LawActivitySettings`
    -   A set of `LawActivitySettings` for each day of the week, defining which police activities are possible on that day.
-   **IntensityIncreasePerDay**: `float`
    -   A value used in the demo to automatically increase the law intensity each day.

## Properties

-   **CurrentSettings**: `LawActivitySettings` (read-only)
    -   The `LawActivitySettings` object that is currently active, based on the day of the week or an override.

## Core Logic

-   **Intensity Management**: The controller maintains an internal float `internalLawIntensity` (from 0.0 to 1.0). This is converted to the public integer `LE_Intensity` (1 to 10). The internal value can be changed by game events, and it also increases automatically each day.
-   **Daily Settings**: The `GetSettings()` method retrieves the appropriate `LawActivitySettings` for the current day of the week.
-   **Evaluation (`MinPass`)**: The `MinPass` method is subscribed to the `TimeManager.onMinutePass` event. Every in-game minute, it calls `Evaluate()` on the `CurrentSettings` object. This is the core loop that checks all possible police activities and activates or deactivates them based on their individual conditions (e.g., intensity level, time of day).
-   **Persistence**: As an `ISaveable`, it saves the `internalLawIntensity` value when the game is saved and loads it back when a game is loaded.

## Public Methods

### GetSettings
`public LawActivitySettings GetSettings()`

Returns the currently active `LawActivitySettings`, accounting for any overrides.

### OverrideSetings
`public void OverrideSetings(LawActivitySettings settings)`

Allows another script to temporarily override the daily settings with a different set of activities.

### EndOverride
`public void EndOverride()`

Removes the settings override and returns to the normal daily schedule.

### ChangeInternalIntensity / SetInternalIntensity
`public void ChangeInternalIntensity(float change)` and `public void SetInternalIntensity(float intensity)`

Methods to modify the internal law intensity level, which in turn updates the public `LE_Intensity`.
