# VehicleInitializer

The `VehicleInitializer` class is responsible for initializing a vehicle when it is spawned on the server. If an `InitialParkingLot` is specified, it will try to park the vehicle in a random free spot in that lot.

## Public Properties

| Property          | Type         | Description                                      |
| ----------------- | ------------ | ------------------------------------------------ |
| `InitialParkingLot` | `ParkingLot` | The parking lot to park the vehicle in when it is spawned. |
