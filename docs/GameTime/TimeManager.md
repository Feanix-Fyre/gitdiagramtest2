# TimeManager

Inherits from `NetworkSingleton<TimeManager>` and implements `IBaseSaveable`, `ISaveable`.

## Description

The central manager for all in-game time and date progression. It handles the 24-hour day/night cycle, tracks elapsed days, and provides numerous events for other systems to subscribe to (e.g., `onMinutePass`, `onDayPass`). The time is controlled by the server and synchronized to all clients.

## Key Properties

-   **TimeProgressionMultiplier**: `float` - A multiplier to speed up or slow down the flow of time.
-   **SleepInProgress**: `bool` (read-only) - Is the game currently in a fast-forwarding "sleep" state?
-   **ElapsedDays**: `int` (read-only) - The total number of days that have passed since the game started.
-   **CurrentTime**: `int` (read-only) - The current time of day, represented as a 24-hour integer (e.g., 900 for 9:00 AM, 2359 for 11:59 PM).
-   **IsNight**: `bool` (read-only) - True if the current time is between 6 PM and 6 AM.
-   **CurrentDay**: `EDay` (read-only) - The current day of the week.
-   **NormalizedTime**: `float` (read-only) - The current time of day as a value between 0.0 and 1.0.

## Events (Actions)

The `TimeManager` provides a wide range of events for other systems to hook into:
-   **onMinutePass**: Invoked every time an in-game minute passes.
-   **onHourPass**: Invoked every time an in-game hour passes.
-   **onDayPass**: Invoked when the day changes.
-   **onWeekPass**: Invoked when a new week starts (on Monday).
-   **onSleepStart**: Invoked when the sleep sequence begins.
-   **onSleepEnd**: Invoked when the sleep sequence finishes, passing the number of minutes slept.
-   **onTimeChanged**: Invoked whenever the time is set manually.

## Core Logic

-   **Time Loop**: The `TimeLoop` coroutine is the heart of the manager. It waits for a duration equivalent to one in-game minute (calculated using `TimeProgressionMultiplier` and `Time.timeScale`) and then calls `Tick()`.
-   **Tick()**: This is the main time progression method.
    -   It increments `CurrentTime`.
    -   It handles wrapping around at the end of a minute (e.g., 959 -> 1000) and the end of a day (2359 -> 0000).
    -   When a day or week passes, it invokes the corresponding events.
    -   It invokes the `onMinutePass` event, which is used by many other systems (like `AnalogueClock` and `DeliveryManager`) to update themselves.
-   **Sleep**:
    -   The server checks if all players are ready to sleep (`Player.AreAllPlayersReadyToSleep()`).
    -   If so, it calls `StartSleep()`, which invokes the `onSleepStart` event and begins fast-forwarding time.
    -   When the designated wake-up time is reached, `EndSleep()` is called, which invokes the `onSleepEnd` event and restores the normal time progression.
-   **Networking**: The server is the authority for time. When a new client joins, the server calls `SendTimeData`, which sends an RPC to the client to synchronize their `ElapsedDays` and `CurrentTime`.

## Public Methods

### SetTime
`public void SetTime(int _time, bool local = false)`

Sets the current time of day. Can only be called by the server unless `local` is true.

### SetElapsedDays
`public void SetElapsedDays(int days)`

Sets the total number of elapsed days. Can only be called by the server.

### FastForwardToWakeTime
`public void FastForwardToWakeTime()`

A server-only method that advances the time to the next designated wake-up time (usually 7:00 AM). It handles advancing the day/week if necessary and invokes the `onSleepEnd` event.

### GetDateTime
`public GameDateTime GetDateTime()`

Returns a `GameDateTime` struct representing the current date and time.
