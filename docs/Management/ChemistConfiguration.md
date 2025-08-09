# ChemistConfiguration

Inherits from `EntityConfiguration`.

## Description

This class holds the configuration and assignments for a `Chemist` employee. It is similar to `BotanistConfiguration` but manages chemistry-related stations. It handles which bed the chemist sleeps in and which stations (`ChemistryStation`, `LabOven`, `Cauldron`, `MixingStation`) they are assigned to work on.

## Fields

-   **Bed**: `ObjectField` - A configuration field to select the `BedItem` the chemist will use.
-   **Stations**: `ObjectListField` - A configuration field to select the various chemistry stations the chemist is assigned to.
-   **ChemStations / LabOvens / Cauldrons / MixStations**: `List<T>` - Separate lists to hold the assigned stations, categorized by their specific type.

## Properties

-   **chemist**: `Chemist` (read-only) - A reference to the `Chemist` employee this configuration belongs to.
-   **bedItem**: `BedItem` (read-only) - A reference to the assigned `BedItem`.

## Core Logic

-   **Initialization**: The constructor creates the `ObjectField` and `ObjectListField` instances and sets up their type requirements and event listeners.
-   **Station Assignment**: The `AssignedStationsChanged` method is the core of the assignment logic. When the `Stations` list is modified in the UI:
    -   It compares the new list of assigned objects with the old lists (`ChemStations`, `LabOvens`, etc.).
    -   For any station that was removed, it un-assigns the chemist from that station's own configuration.
    -   For any station that was newly added, it adds it to the appropriate typed list and assigns the chemist to that station's configuration. This ensures a two-way link between the chemist and their assigned stations.
-   **Validation (`IsStationValid`)**: This method is used as a filter for the `Stations` list. It prevents the player from assigning a station that is already assigned to a different chemist.
-   **Cleanup (`Destroy`)**: When the configuration is destroyed, it ensures the chemist is un-assigned from their bed and all their assigned stations.
-   **Persistence**: It implements `ShouldSave` and `GetSaveString` to save the configuration data (the GUIDs of the assigned bed and stations) to a JSON string.

## Methods

### AssignedStationsChanged
`public void AssignedStationsChanged(List<BuildableItem> objects)`

The callback method for when the `Stations` list changes. It updates the assignments on both this configuration and the configurations of the individual station objects.
