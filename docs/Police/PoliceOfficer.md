# PoliceOfficer

The `PoliceOfficer` class represents a police officer NPC in the game. It inherits from the `NPC` class and adds a lot of functionality specific to police officers, such as pursuing players, conducting body searches, and managing checkpoints.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `OnPoliceVisionEvent` | `Action<VisionEventReceipt>` | An event that is invoked when a police officer has a vision event. |
| `Officers` | `List<PoliceOfficer>` | A list of all police officers in the game. |
| `AssignedVehicle` | `LandVehicle` | The vehicle that the police officer is assigned to. |
| `PursuitBehaviour` | `PursuitBehaviour` | The pursuit behaviour of the police officer. |
| `VehiclePursuitBehaviour` | `VehiclePursuitBehaviour` | The vehicle pursuit behaviour of the police officer. |
| `BodySearchBehaviour` | `BodySearchBehaviour` | The body search behaviour of the police officer. |
| `CheckpointBehaviour` | `CheckpointBehaviour` | The checkpoint behaviour of the police officer. |
| `FootPatrolBehaviour` | `FootPatrolBehaviour` | The foot patrol behaviour of the police officer. |
| `ProxCircle` | `ProximityCircle` | The proximity circle of the police officer. |
| `VehiclePatrolBehaviour` | `VehiclePatrolBehaviour` | The vehicle patrol behaviour of the police officer. |
| `SentryBehaviour` | `SentryBehaviour` | The sentry behaviour of the police officer. |
| `ChatterVO` | `PoliceChatterVO` | The police chatter voice-over of the police officer. |
| `CheckpointDialogue` | `DialogueContainer` | The dialogue container for the checkpoint. |
| `BatonPrefab` | `AvatarEquippable` | The prefab for the baton. |
| `TaserPrefab` | `AvatarEquippable` | The prefab for the taser. |
| `GunPrefab` | `AvatarEquippable` | The prefab for the gun. |
| `AutoDeactivate` | `bool` | If `true`, the police officer will be automatically deactivated when they are not needed. |
| `ChatterEnabled` | `bool` | If `true`, the police officer will chatter. |
| `Suspicion` | `float` | The suspicion level of the police officer. |
| `Leniency` | `float` | The leniency level of the police officer. |
| `BodySearchChance` | `float` | The chance that the police officer will conduct a body search. |
| `BodySearchDuration` | `float` | The duration of a body search. |
| `TargetPlayerNOB` | `NetworkObject` | The network object of the player that the police officer is targeting. |

## Methods

### `BeginFootPursuit_Networked(NetworkObject target, bool includeColleagues = true)`

Begins a foot pursuit of a player.

**Parameters:**

* `target`: The player to pursue.
* `includeColleagues`: If `true`, other police officers in the area will also join the pursuit.

### `BeginVehiclePursuit_Networked(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)`

Begins a vehicle pursuit of a player.

**Parameters:**

* `target`: The player to pursue.
* `vehicle`: The vehicle to use for the pursuit.
* `beginAsSighted`: If `true`, the pursuit will begin as if the player has already been sighted.

### `BeginBodySearch_LocalPlayer()`

Begins a body search of the local player.

### `BeginBodySearch_Networked(NetworkObject target)`

Begins a body search of a player.

**Parameters:**

* `target`: The player to search.

### `AssignToCheckpoint(CheckpointManager.ECheckpointLocation location)`

Assigns the police officer to a checkpoint.

**Parameters:**

* `location`: The location of the checkpoint to assign the police officer to.

### `UnassignFromCheckpoint()`

Unassigns the police officer from their current checkpoint.

### `StartFootPatrol(PatrolGroup group, bool warpToStartPoint)`

Starts a foot patrol.

**Parameters:**

* `group`: The patrol group to join.
* `warpToStartPoint`: If `true`, the police officer will be warped to the start point of the patrol.

### `StartVehiclePatrol(VehiclePatrolRoute route, LandVehicle vehicle)`

Starts a vehicle patrol.

**Parameters:**

* `route`: The patrol route to follow.
* `vehicle`: The vehicle to use for the patrol.

### `AssignToSentryLocation(SentryLocation location)`

Assigns the police officer to a sentry location.

**Parameters:**

* `location`: The sentry location to assign the police officer to.

### `UnassignFromSentryLocation()`

Unassigns the police officer from their current sentry location.

### `Activate()`

Activates the police officer.

### `Deactivate()`

Deactivates the police officer.

### `GetNameAddress()`

Gets the name and address of the police officer.

**Returns:** `string`

### `UpdateBodySearch()`

Updates the body search behaviour of the police officer.

### `ConductBodySearch(Player player)`

Conducts a body search of a player.

**Parameters:**

* `player`: The player to search.
