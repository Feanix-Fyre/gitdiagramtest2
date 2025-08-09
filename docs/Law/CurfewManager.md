# CurfewManager

Inherits from `NetworkSingleton<CurfewManager>`.

## Description

This singleton manager handles the gameplay effects and UI notifications for a city-wide curfew. It is enabled and disabled by a `CurfewInstance` and synchronizes its state to all clients.

## Constants

-   **WARNING_TIME**: `2030` (8:30 PM) - The time a warning sound and message are played.
-   **CURFEW_START_TIME**: `2100` (9:00 PM) - The time the curfew officially begins.
-   **CURFEW_END_TIME**: `500` (5:00 AM) - The time the curfew officially ends.

## Fields

-   **VMSBoards**: `VMSBoard[]` - An array of references to Variable Message Sign boards around the city that will display curfew information.
-   **CurfewWarningSound**: `AudioSourceController` - The sound played at `WARNING_TIME`.
-   **CurfewAlarmSound**: `AudioSourceController` - The sound played at `CURFEW_START_TIME`.
-   **onCurfewEnabled / onCurfewDisabled / etc**: `UnityEvent`s - Events invoked at different stages of the curfew for other systems to hook into.

## Properties

-   **IsEnabled**: `bool` (read-only) - Is the curfew system enabled for the current day? This is set by a `CurfewInstance`.
-   **IsCurrentlyActive**: `bool` (read-only) - Is the current in-game time within the curfew hours (9 PM to 5 AM)?
-   **IsCurrentlyActiveWithTolerance**: `bool` (read-only) - Similar to `IsCurrentlyActive`, but with a 15-minute grace period at the start.

## Core Logic

-   **Time-Based Events (`MinPass`)**: The manager subscribes to the `TimeManager.onMinutePass` event. Every minute, it checks the time:
    -   At `WARNING_TIME` (8:30 PM), it plays a warning sound and may show a tutorial hint.
    -   Between the warning and the start, it updates `VMSBoard`s with a countdown.
    -   Between `CURFEW_START_TIME` (9:00 PM) and `CURFEW_END_TIME` (5:00 AM), it sets `IsCurrentlyActive` to true, plays an alarm sound, and updates `VMSBoard`s to show that the curfew is active.
    -   Outside of these times, it resets its state.

## Public Methods

### Enable
`public void Enable(NetworkConnection conn)`

An `ObserversRpc` called by a `CurfewInstance` to enable the curfew system for the day. It sets `IsEnabled` to true, invokes the `onCurfewEnabled` event, and activates the `VMSBoard` GameObjects.

### Disable
`public void Disable()`

An `ObserversRpc` called by a `CurfewInstance` to disable the curfew system. It sets `IsEnabled` to false, invokes `onCurfewDisabled`, and deactivates the `VMSBoard`s.
