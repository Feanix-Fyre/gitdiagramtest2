# VehicleManager

The `VehicleManager` class is a `NetworkSingleton` that manages all the vehicles in the game. It can spawn and load vehicles, and it also handles saving and loading of player-owned vehicles.

## Public Properties

| Property              | Type                  | Description                                      |
| --------------------- | --------------------- | ------------------------------------------------ |
| `AllVehicles`         | `List<LandVehicle>`   | A list of all vehicles in the scene.             |
| `VehiclePrefabs`      | `List<LandVehicle>`   | A list of all vehicle prefabs.                   |
| `PlayerOwnedVehicles` | `List<LandVehicle>`   | A list of all player-owned vehicles.             |
| `SaveFileName`        | `string`              | The name of the save file for player-owned vehicles. |
| `Loader`              | `Loader`              | The loader to use for loading vehicle data.      |
| `ShouldSaveUnderFolder` | `bool`              | A boolean that indicates whether the save file should be saved under a folder. |
| `LocalExtraFiles`     | `List<string>`        | A list of extra files to save.                   |
| `LocalExtraFolders`   | `List<string>`        | A list of extra folders to save.                 |
| `HasChanged`          | `bool`                | A boolean that indicates whether the vehicle data has changed. |

## Public Methods

| Method                                      | Return Type   | Description                                                                    |
| ------------------------------------------- | ------------- | ------------------------------------------------------------------------------ |
| `InitializeSaveable()`                      | `void`        | Initializes the saveable.                                                      |
| `SpawnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)` | `void`        | Spawns a vehicle.                                                              |
| `SpawnAndReturnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)` | `LandVehicle` | Spawns a vehicle and returns it.                                               |
| `GetVehiclePrefab(string vehicleCode)`      | `LandVehicle` | Gets a vehicle prefab by its code.                                             |
| `SpawnAndLoadVehicle(VehicleData data, string path, bool playerOwned)` | `LandVehicle` | Spawns a vehicle and loads its data.                                           |
| `LoadVehicle(VehicleData data, string path)` | `void`        | Loads the data for a vehicle.                                                  |
| `GetSaveString()`                           | `string`      | Gets the save string for all player-owned vehicles.                            |
| `SpawnLoanSharkVehicle(Vector3 position, Quaternion rot)` | `void`        | Spawns a loan shark vehicle.                                                   |
