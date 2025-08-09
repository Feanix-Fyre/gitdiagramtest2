# ConfigurableType

A static class that provides a helper method for `EConfigurableType`.

## Description

This class contains a single static method to convert an `EConfigurableType` enum value into a user-friendly, displayable string name.

## Methods

### GetTypeName
`public static string GetTypeName(EConfigurableType type)`

Takes an `EConfigurableType` and returns its string name.

-   **Parameters:**
    -   `type`: The enum value to convert.
-   **Returns:** A formatted string for the given type (e.g., `EConfigurableType.PackagingStation` becomes "Packaging Station").
