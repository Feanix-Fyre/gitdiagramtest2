# ConstructionManager

Inherits from `Singleton<ConstructionManager>`.

## Description

The central manager for the property construction/decoration system. This system is distinct from the player's inventory-based building system. It handles entering and exiting a top-down "construction mode" for a specific property, and manages the process of deploying new objects or moving existing ones.

## Key Properties

-   **currentProperty**: `ScheduleOne.Property.Property`
    -   A reference to the property currently being edited.
-   **constructionModeEnabled**: `bool` (read-only)
    -   Is the construction mode currently active?
-   **isDeployingConstructable**: `bool` (read-only)
    -   Is the player currently in the process of placing a new object?
-   **isMovingConstructable**: `bool` (read-only)
    -   Is the player currently in the process of moving an existing object?

## Core Logic & Events

-   **Events**:
    -   `onConstructionModeEnabled`: Invoked when construction mode is entered.
    -   `onConstructionModeDisabled`: Invoked when construction mode is exited.
    -   `onNewConstructableBuilt`: Invoked when a new object is successfully placed.
    -   `onConstructableMoved`: Invoked when an existing object is successfully moved.

-   **Construction Flow**:
    1.  `EnterConstructionMode` is called, targeting a specific `Property`. This disables normal player controls and enables a top-down camera view (`BirdsEyeView`).
    2.  The player selects an item to build from the `ConstructionMenu`.
    3.  `DeployConstructable` is called. It instantiates the appropriate "Construction Handler" prefab for that object.
    4.  The Construction Handler (e.g., `ConstructUpdate_OutdoorGrid`) takes over, showing a ghost model and handling placement logic.
    5.  When placement is confirmed, the handler calls a `CreateConstructable` method on this manager to spawn the final object.
    6.  When placement is cancelled, `StopConstructableDeploy` is called to clean up the handler.
    7.  A similar flow exists for moving existing objects with `MoveConstructable` and `StopMovingConstructable`.
    8.  `ExitConstructionMode` is called to return to normal gameplay.

## Public Methods

### EnterConstructionMode
`public void EnterConstructionMode(ScheduleOne.Property.Property prop)`

Enables construction mode for a given property, disabling player movement and enabling the construction UI and camera.

### ExitConstructionMode
`public void ExitConstructionMode()`

Disables construction mode and returns the player to normal control.

### DeployConstructable
`public void DeployConstructable(ConstructionMenu.ConstructionMenuListing listing)`

Starts the process of placing a new constructable object. It finds the correct "Construction Handler" prefab from the object's definition in the `Registry` and instantiates it.

### StopConstructableDeploy
`public void StopConstructableDeploy()`

Cancels the current deployment process by destroying the active construction handler.

### MoveConstructable
`public void MoveConstructable(Constructable_GridBased c)`

Starts the process of moving an existing constructable object, instantiating its construction handler to manage the move.

### StopMovingConstructable
`public void StopMovingConstructable()`

Cancels the current move process.

### CreateConstructable_GridBased
`public Constructable_GridBased CreateConstructable_GridBased(string ID, Grid grid, Vector2 originCoordinate, float rotation)`

Instantiates, initializes, and spawns a new grid-based constructable object on the network.

### CreateConstructable
`public Constructable CreateConstructable(string prefabID)`

Instantiates a new non-grid-based constructable object.
