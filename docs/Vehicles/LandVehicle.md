# LandVehicle

The `LandVehicle` class is the base class for all land vehicles. It handles a wide range of functionality, including vehicle physics, player interaction, networking, saving and loading, AI control, and visuals.

## Classes

### BodyMesh

This class is a data container for a mesh that is part of the vehicle's body.

-   `Renderer`: The `MeshRenderer` for the mesh.
-   `MaterialIndex`: The index of the material to use for the mesh.

## Delegates

### VehiclePlayerEvent

This delegate is used for events that involve a player and a vehicle.

-   `player`: The player involved in the event.

## Public Properties

| Property                   | Type                | Description                                                                  |
| -------------------------- | ------------------- | ---------------------------------------------------------------------------- |
| `DEBUG`                    | `bool`              | If true, debug information will be logged to the console.                    |
| `UseHumanoidCollider`      | `bool`              | If true, a humanoid collider will be used for the vehicle.                   |
| `SpawnAsPlayerOwned`       | `bool`              | If true, the vehicle will be spawned as player-owned.                        |
| `wheels`                   | `List<Wheel>`       | A list of all the wheels on the vehicle.                                     |
| `Seats`                    | `VehicleSeat[]`     | An array of all the seats in the vehicle.                                    |
| `boundingBox`              | `BoxCollider`       | The bounding box of the vehicle.                                             |
| `Agent`                    | `VehicleAgent`      | The `VehicleAgent` component for this vehicle.                               |
| `VelocityCalculator`       | `SmoothedVelocityCalculator` | The `SmoothedVelocityCalculator` for this vehicle.                       |
| `Trunk`                    | `StorageDoorAnimation`| The `StorageDoorAnimation` for the trunk of the vehicle.                     |
| `NavMeshObstacle`          | `NavMeshObstacle`   | The `NavMeshObstacle` for this vehicle.                                      |
| `NavmeshCut`               | `NavmeshCut`        | The `NavmeshCut` for this vehicle.                                           |
| `HumanoidColliderContainer`| `VehicleHumanoidCollider` | The `VehicleHumanoidCollider` for this vehicle.                            |
| `POI`                      | `POI`               | The `POI` for this vehicle.                                                  |
| `TopSpeed`                 | `float`             | The top speed of the vehicle in km/h.                                        |
| `DefaultColor`             | `EVehicleColor`     | The default color of the vehicle.                                            |
| `overrideControls`         | `bool`              | If true, the vehicle's controls will be overridden.                          |
| `throttleOverride`         | `float`             | The throttle override value.                                                 |
| `steerOverride`            | `float`             | The steer override value.                                                    |
| `Storage`                  | `StorageEntity`     | The `StorageEntity` for this vehicle.                                        |
| `currentSteerAngle`        | `float`             | The current steering angle of the vehicle.                                   |
| `onPlayerEnterVehicle`     | `VehiclePlayerEvent`| An event that is invoked when a player enters the vehicle.                   |
| `onPlayerExitVehicle`      | `VehiclePlayerEvent`| An event that is invoked when a player exits the vehicle.                    |
| `onVehicleStart`           | `UnityEvent`        | An event that is invoked when the vehicle starts.                            |
| `onVehicleStop`            | `UnityEvent`        | An event that is invoked when the vehicle stops.                             |
| `onHandbrakeApplied`       | `UnityEvent`        | An event that is invoked when the handbrake is applied.                      |
| `onCollision`              | `UnityEvent<Collision>` | An event that is invoked when a collision occurs.                            |
| `VehicleName`              | `string`            | The name of the vehicle.                                                     |
| `VehicleCode`              | `string`            | The code for the vehicle.                                                    |
| `VehiclePrice`             | `float`             | The price of the vehicle.                                                    |
| `IsPlayerOwned`            | `bool`              | A boolean that indicates whether the vehicle is player-owned.                |
| `IsVisible`                | `bool`              | A boolean that indicates whether the vehicle is visible.                     |
| `GUID`                     | `Guid`              | The GUID of the vehicle.                                                     |
| `DistanceToLocalCamera`    | `float`             | The distance from the vehicle to the local camera.                           |
| `boundingBoxDimensions`    | `Vector3`           | The dimensions of the vehicle's bounding box.                                |
| `driverEntryPoint`         | `Transform`         | The entry point for the driver.                                              |
| `Rb`                       | `Rigidbody`         | The rigidbody of the vehicle.                                                |
| `ActualMaxSteeringAngle`   | `float`             | The actual maximum steering angle of the vehicle.                            |
| `MaxSteerAngleOverridden`  | `bool`              | A boolean that indicates whether the maximum steering angle is overridden.   |
| `OverriddenMaxSteerAngle`  | `float`             | The overridden maximum steering angle.                                       |
| `OwnedColor`               | `EVehicleColor`     | The owned color of the vehicle.                                              |
| `Capacity`                 | `int`               | The number of seats in the vehicle.                                          |
| `CurrentPlayerOccupancy`   | `int`               | The number of players currently in the vehicle.                              |
| `localPlayerIsDriver`      | `bool`              | A boolean that indicates whether the local player is the driver.             |
| `localPlayerIsInVehicle`   | `bool`              | A boolean that indicates whether the local player is in the vehicle.         |
| `isOccupied`               | `bool`              | A boolean that indicates whether the vehicle is occupied.                    |
| `DriverPlayer`             | `Player`            | The player who is driving the vehicle.                                       |
| `OccupantPlayers`          | `List<Player>`      | A list of all the players in the vehicle.                                    |
| `OccupantNPCs`             | `NPC[]`             | An array of all the NPCs in the vehicle.                                     |
| `speed_Kmh`                | `float`             | The speed of the vehicle in km/h.                                            |
| `speed_Ms`                 | `float`             | The speed of the vehicle in m/s.                                             |
| `speed_Mph`                | `float`             | The speed of the vehicle in mph.                                             |
| `currentThrottle`          | `float`             | The current throttle of the vehicle.                                         |
| `brakesApplied`            | `bool`              | A boolean that indicates whether the brakes are applied.                     |
| `isReversing`              | `bool`              | A boolean that indicates whether the vehicle is reversing.                   |
| `isStatic`                 | `bool`              | A boolean that indicates whether the vehicle is static.                      |
| `handbrakeApplied`         | `bool`              | A boolean that indicates whether the handbrake is applied.                   |
| `boundingBaseOffset`       | `float`             | The offset of the bounding box's base.                                       |
| `isParked`                 | `bool`              | A boolean that indicates whether the vehicle is parked.                      |
| `CurrentParkingLot`        | `ParkingLot`        | The parking lot the vehicle is parked in.                                    |
| `CurrentParkingSpot`       | `ParkingSpot`       | The parking spot the vehicle is parked in.                                   |
| `SaveFileName`             | `string`            | The name of the save file for the vehicle.                                   |
| `Loader`                   | `Loader`            | The loader to use for loading vehicle data.                                  |
| `ShouldSaveUnderFolder`    | `bool`              | A boolean that indicates whether the save file should be saved under a folder. |
| `LocalExtraFiles`          | `List<string>`      | A list of extra files to save.                                               |
| `LocalExtraFolders`        | `List<string>`      | A list of extra folders to save.                                             |
| `HasChanged`               | `bool`              | A boolean that indicates whether the vehicle data has changed.               |

## Public Methods

| Method                                      | Return Type | Description                                                                    |
| ------------------------------------------- | ----------- | ------------------------------------------------------------------------------ |
| `InitializeSaveable()`                      | `void`        | Initializes the saveable.                                                      |
| `SetIsPlayerOwned(NetworkConnection conn, bool playerOwned)` | `void`      | Sets whether the vehicle is player-owned.                                      |
| `SetGUID(Guid guid)`                        | `void`        | Sets the GUID of the vehicle.                                                  |
| `SetTransform(Vector3 pos, Quaternion rot)` | `void`        | Sets the transform of the vehicle.                                             |
| `DestroyVehicle()`                          | `void`        | Destroys the vehicle.                                                          |
| `ApplyHandbrake()`                          | `void`        | Applies the handbrake.                                                         |
| `SetIsStatic(bool stat)`                    | `void`        | Sets whether the vehicle is static.                                            |
| `AlignTo(Transform target, EParkingAlignment type, bool network = false)` | `void` | Aligns the vehicle to a target.                                                |
| `GetAlignmentTransform(Transform target, EParkingAlignment type)` | `Tuple<Vector3, Quaternion>` | Gets the alignment transform for a target.                                     |
| `GetVehicleValue()`                         | `float`       | Gets the value of the vehicle.                                                 |
| `OverrideMaxSteerAngle(float maxAngle)`     | `void`        | Overrides the maximum steering angle of the vehicle.                           |
| `ResetMaxSteerAngle()`                      | `void`        | Resets the maximum steering angle of the vehicle.                              |
| `SetObstaclesActive(bool active)`           | `void`        | Sets whether the vehicle's obstacles are active.                               |
| `GetFirstFreeSeat()`                        | `VehicleSeat` | Gets the first free seat in the vehicle.                                       |
| `ExitVehicle()`                             | `void`        | Exits the vehicle.                                                             |
| `GetExitPoint(int seatIndex = 0)`           | `Transform`   | Gets the exit point for a seat.                                                |
| `AddNPCOccupant(NPC npc)`                   | `void`        | Adds an NPC to the vehicle.                                                    |
| `RemoveNPCOccupant(NPC npc)`                | `void`        | Removes an NPC from the vehicle.                                               |
| `CanBeRecovered()`                          | `bool`        | Checks if the vehicle can be recovered.                                        |
| `RecoverVehicle()`                          | `void`        | Recovers the vehicle.                                                          |
| `SendOwnedColor(EVehicleColor col)`         | `void`        | Sends the owned color of the vehicle to the server.                            |
| `ApplyColor(EVehicleColor col)`             | `void`        | Applies a color to the vehicle.                                                |
| `ApplyOwnedColor()`                         | `void`        | Applies the owned color to the vehicle.                                        |
| `ShowOutline(BuildableItem.EOutlineColor color)` | `void`      | Shows an outline around the vehicle.                                           |
| `HideOutline()`                             | `void`        | Hides the outline around the vehicle.                                          |
| `Park(NetworkConnection conn, ParkData parkData, bool network)` | `void` | Parks the vehicle.                                                             |
| `ExitPark(bool moveToExitPoint = true)`     | `void`        | Exits the park.                                                                |
| `SetVisible(bool vis)`                      | `void`        | Sets whether the vehicle is visible.                                           |
| `GetContents()`                             | `List<ItemInstance>` | Gets the contents of the vehicle's storage.                                  |
| `GetVehicleData()`                          | `VehicleData` | Gets the vehicle's data.                                                       |
| `GetSaveString()`                           | `string`      | Gets the save string for the vehicle.                                          |
| `Load(VehicleData data, string containerPath)` | `void`      | Loads the vehicle's data.                                                      |
