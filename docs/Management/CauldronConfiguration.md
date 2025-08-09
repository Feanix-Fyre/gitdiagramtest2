# CauldronConfiguration

Inherits from `EntityConfiguration`.

## Description

This class holds the configuration for a `Cauldron` station. It manages the assignment of a `Chemist` employee and the destination for the output products. Its structure and logic are very similar to `BrickPressConfiguration`.

## Fields

-   **AssignedChemist**: `NPCField`
    -   A configuration field to select the `Chemist` employee who will operate this station.
-   **Destination**: `ObjectField`
    -   A configuration field to select the `ITransitEntity` (e.g., a storage shelf) where the finished products will be moved.

## Properties

-   **Station**: `Cauldron` (read-only)
    -   A reference to the `Cauldron` station this configuration belongs to.
-   **DestinationRoute**: `TransitRoute` (read-only)
    -   The `TransitRoute` from this cauldron to the selected `Destination`.

## Core Logic

-   **Initialization**: The constructor creates the `NPCField` and `ObjectField` and sets up their type requirements and filters.
-   **Transit Route Management**:
    -   When the `Destination` object is changed via the UI, the `DestinationChanged` method is called.
    -   It destroys the old `DestinationRoute` (if one existed).
    -   If a new destination is set, it creates a new `TransitRoute` from the cauldron to the destination object.
    -   The route's visuals (a line connecting the two objects) are activated when this configuration is selected in the UI (`Selected` method) and deactivated when it's deselected (`Deselected` method).
-   **Persistence**: It implements `ShouldSave` and `GetSaveString` to save the configuration data (the GUID of the destination object) to a JSON string.

## Methods

### DestinationFilter
`public bool DestinationFilter(BuildableItem obj, out string reason)`

A filter method used by the `Destination` `ObjectField`. It ensures that only objects that implement `ITransitEntity` and are not the cauldron itself can be selected as a destination.
