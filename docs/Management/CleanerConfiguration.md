# CleanerConfiguration

Inherits from `EntityConfiguration`.

## Description

This class holds the configuration and assignments for a `Cleaner` employee. It manages which bed they sleep in and which trash containers they are assigned to empty.

## Fields

-   **Bed**: `ObjectField`
    -   A configuration field to select the `BedItem` the cleaner will use.
-   **Bins**: `ObjectListField`
    -   A configuration field to select the `TrashContainerItem`s the cleaner is responsible for.

## Properties

-   **cleaner**: `Cleaner` (read-only)
    -   A reference to the `Cleaner` employee this configuration belongs to.
-   **binItems**: `List<TrashContainerItem>` (read-only)
    -   A list of the `TrashContainerItem`s currently assigned to this cleaner.
-   **bedItem**: `BedItem` (read-only)
    -   A reference to the assigned `BedItem`.

## Core Logic

-   **Initialization**: The constructor creates the `ObjectField` and `ObjectListField` instances and sets up their type requirements and filters.
-   **Bin Assignment**: The `AssignedBinsChanged` method is the callback for when the `Bins` list is modified in the UI. It updates the internal `binItems` list to match the selection.
-   **Validation (`IsObjValid`)**: This method is used as a filter for the `Bins` list. It ensures that only `TrashContainerItem`s that have the `UsableByCleaners` flag set to true can be assigned.
-   **Bed Assignment**: The `BedChanged` method is a callback for when the `Bed` field changes. It ensures the employee is assigned to the new bed and un-assigned from the old one.
-   **Persistence**: It implements `ShouldSave` and `GetSaveString` to save the configuration data (the GUIDs of the assigned bed and bins) to a JSON string.

## Methods

### AssignedBinsChanged
`public void AssignedBinsChanged(List<BuildableItem> objects)`

The callback method for when the `Bins` list changes. It updates the internal list of assigned trash containers.
