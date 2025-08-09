# Crime

A serializable base class for all crimes.

## Description

This class serves as the parent for all specific crime types in the game (e.g., `Assault`, `Theft`). It provides a common structure and a `CrimeName` property.

## Properties

-   **CrimeName**: `string` (read-only)
    -   The display name of the crime. This is intended to be overridden by derived classes.
