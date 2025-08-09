# BotanistConfiguration

Inherits from `EntityConfiguration`.

## Description

This class holds the configuration and assignments for a `Botanist` employee. It manages which bed they sleep in, where they get their supplies from, and which `Pot`s and `DryingRack`s they are assigned to work on.

## Fields

-   **Bed**: `ObjectField` - A configuration field to select the `BedItem` the botanist will use.
-   **Supplies**: `ObjectField` - A configuration field to select a `PlaceableStorageEntity` from which the botanist will get supplies (e.g., seeds, soil).
-   **AssignedStations**: `ObjectListField` - A configuration field to select the `Pot`s and `DryingRack`s the botanist is assigned to.
-   **AssignedPots**: `List<Pot>` - A list of the `Pot`s currently assigned to this botanist.
-   **AssignedRacks**: `List<DryingRack>` - A list of the `DryingRack`s currently assigned to this botanist.

## Properties

-   **botanist**: `Botanist` (read-only) - A reference to the `Botanist` employee this configuration belongs to.
-   **bedItem**: `BedItem` (read-only) - A reference to the assigned `BedItem`.

## Core Logic

-   **Initialization**: The constructor creates the `ObjectField` and `ObjectListField` instances and sets up their type requirements and event listeners. For example, when the assigned bed changes, it automatically assigns the botanist to the new bed.
-   **Station Assignment**: The `AssignedPotsChanged` method handles the logic when the list of assigned stations is modified.
    -   It iterates through the new list and assigns the botanist to any newly added pots or racks.
    -   It iterates through the old list to find any stations that were removed and un-assigns the botanist from them.
-   **Validation (`IsStationValid`)**: This method is used as a filter for the `AssignedStations` list. It prevents the player from assigning a station that is already assigned to a different botanist.
-   **Cleanup (`Destroy`)**: When the configuration is destroyed (e.g., the employee is fired), it ensures the botanist is un-assigned from their bed and all their assigned stations.
-   **Persistence**: It implements `ShouldSave` and `GetSaveString` to save the configuration data (the GUIDs of the assigned objects) to a JSON string.

## Methods

### AssignedPotsChanged
`public void AssignedPotsChanged(List<BuildableItem> objects)`

The callback method for when the `AssignedStations` list changes. It updates the assignments on the `Pot` and `DryingRack` objects themselves.
