# PropertyDoorController

Inherits from `DoorController`.

## Description

This class extends the `DoorController` to add logic specific to doors of player-ownable properties. It handles locking and unlocking based on property ownership and adds special behavior related to police presence.

## Fields

-   **Property**: `ScheduleOne.Property.Property`
    -   A reference to the property this door belongs to.

## Methods

### Awake
`public override void Awake()`

Initializes the door. By default, it sets the `PlayerAccess` to `ExitOnly`. It subscribes the `Unlock` method to the `onThisPropertyAcquired` event of the `Property` and starts a repeating check to see if the door should be closed.

### Unlock
`public void Unlock()`

Unlocks the door by setting `PlayerAccess` to `Open`. This is called when the associated property is acquired by the player.

### CheckClose
`private void CheckClose()`

Periodically checks if the door should be automatically closed. If the door is open and unlocked, it checks if there is a wanted player nearby. If so, it closes the door. This is likely to prevent players from easily escaping into their properties during a police chase.

### CanPlayerAccess
`protected override bool CanPlayerAccess(EDoorSide side, out string reason)`

Overrides the base access check. It adds a condition that prevents players from entering from the exterior if a wanted player is nearby and the police are also close or have recently seen the wanted player.

-   **Parameters:**
    -   `side`: The side of the door the player is on.
    -   `reason`: An out parameter for the reason access is denied.
-   **Returns:** `false` if police are nearby a wanted player, otherwise returns the result of the base class's check.

### GetNearestWantedPlayer
`private Player GetNearestWantedPlayer()`

Finds and returns the player with an active pursuit level who is closest to the door.

-   **Returns:** The nearest wanted `Player`, or `null` if no wanted players are nearby.
