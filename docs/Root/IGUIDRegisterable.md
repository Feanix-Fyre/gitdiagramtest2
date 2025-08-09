# IGUIDRegisterable

The `IGUIDRegisterable` interface is designed for objects that require a unique identifier (GUID) for registration and tracking purposes.

## Properties

### `GUID`

Gets the `Guid` of the object.

## Methods

### `SetGUID(string guid)`

Sets the `Guid` of the object from a string. If the string is not a valid GUID, a warning is logged to the console.

-   **Parameters:**
    -   `guid`: The string representation of the GUID.

### `SetGUID(Guid guid)`

Sets the `Guid` of the object from a `Guid` object.

-   **Parameters:**
    -   `guid`: The `Guid` to set.
