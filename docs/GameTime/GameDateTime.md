# GameDateTime

A serializable struct that represents a specific point in the game's time.

## Description

This struct combines a day count and a time-of-day value to represent any moment in the game world. It provides constructors and helper methods for creating and manipulating `GameDateTime` values, often by converting to and from a total "minute sum" (the total number of minutes that have passed since the start of the game).

## Fields

-   **elapsedDays**: `int`
    -   The number of full days that have passed.
-   **time**: `int`
    -   The time of day, represented as a 24-hour integer (e.g., 1300 for 1:00 PM).

## Constructors

### GameDateTime(int _elapsedDays, int _time)
Creates a `GameDateTime` from a day count and a 24-hour time.

### GameDateTime(int _minSum)
Creates a `GameDateTime` from a total number of minutes passed since the game started. It calculates the days and the time of day from this total.

### GameDateTime(GameDateTimeData data)
Creates a `GameDateTime` from a `GameDateTimeData` object, used for deserialization when loading a save game.

## Methods

### GetMinSum
`public int GetMinSum()`

Calculates and returns the total number of minutes represented by this `GameDateTime` (total minutes = `elapsedDays` * 1440 + minutes into the current day).

### AddMins
`public GameDateTime AddMins(int mins)`

Adds a specified number of minutes to the current `GameDateTime` and returns a new `GameDateTime` representing the result.

## Operators

The struct overloads several operators to make `GameDateTime` arithmetic and comparison intuitive:
-   `+`: Adds two `GameDateTime` values together.
-   `-`: Subtracts one `GameDateTime` from another.
-   `>`: Compares if one `GameDateTime` is later than another.
-   `<`: Compares if one `GameDateTime` is earlier than another.
