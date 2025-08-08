# RoadCheckpoint

The `RoadCheckpoint` class represents a police checkpoint on a road. It is responsible for managing the state of the checkpoint, including the gates, car stoppers, and vehicle obstacles.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `AssignedNPCs` | `List<NPC>` | A list of NPCs that are assigned to the checkpoint. |
| `MaxStealthLevel` | `EStealthLevel` | The maximum stealth level of contraband that can pass through the checkpoint without being detected. |
| `OpenForNPCs` | `bool` | If `true`, the checkpoint will be open for NPCs. |
| `EnabledOnStart` | `bool` | If `true`, the checkpoint will be enabled when the game starts. |
| `Stopper1` | `CarStopper` | The first car stopper at the checkpoint. |
| `Stopper2` | `CarStopper` | The second car stopper at the checkpoint. |
| `SearchArea1` | `VehicleDetector` | The first vehicle search area at the checkpoint. |
| `SearchArea2` | `VehicleDetector` | The second vehicle search area at the checkpoint. |
| `VehicleObstacle1` | `VehicleObstacle` | The first vehicle obstacle at the checkpoint. |
| `VehicleObstacle2` | `VehicleObstacle` | The second vehicle obstacle at the checkpoint. |
| `NPCVehicleDetectionArea1` | `VehicleDetector` | The first NPC vehicle detection area at the checkpoint. |
| `NPCVehicleDetectionArea2` | `VehicleDetector` | The second NPC vehicle detection area at the checkpoint. |
| `ImmediateVehicleDetector` | `VehicleDetector` | A vehicle detector that detects vehicles immediately in front of the checkpoint. |
| `TrafficCones` | `Rigidbody[]` | An array of traffic cones at the checkpoint. |
| `StandPoints` | `Transform[]` | An array of stand points for NPCs at the checkpoint. |
| `onPlayerWalkThrough` | `UnityEvent<Player>` | An event that is invoked when a player walks through the checkpoint. |
| `ActivationState` | `ECheckpointState` | The activation state of the checkpoint. |
| `Gate1Open` | `bool` | Returns `true` if the first gate is open. |
| `Gate2Open` | `bool` | Returns `true` if the second gate is open. |

## Methods

### `Enable(NetworkConnection conn)`

Enables the checkpoint.

**Parameters:**

* `conn`: The network connection to enable the checkpoint on.

### `Disable()`

Disables the checkpoint.

### `SetGate1Open(bool o)`

Sets the state of the first gate.

**Parameters:**

* `o`: If `true`, the gate will be opened.

### `SetGate2Open(bool o)`

Sets the state of the second gate.

**Parameters:**

* `o`: If `true`, the gate will be opened.

### `PlayerDetected(Player player)`

Called when a player is detected at the checkpoint.

**Parameters:**

* `player`: The player who was detected.
