# ObstructionDetector

The `ObstructionDetector` class is used to detect obstructions in front of a vehicle. It uses a trigger collider to detect vehicles, NPCs, players, and vehicle obstacles, and it calculates the distance to the closest obstruction.

## Public Properties

| Property                   | Type                      | Description                                      |
| -------------------------- | ------------------------- | ------------------------------------------------ |
| `vehicles`                 | `List<LandVehicle>`       | A list of all vehicles detected by the sensor.   |
| `npcs`                     | `List<NPC>`               | A list of all NPCs detected by the sensor.       |
| `players`                  | `List<PlayerMovement>`    | A list of all players detected by the sensor.    |
| `vehicleObstacles`         | `List<VehicleObstacle>`   | A list of all vehicle obstacles detected by the sensor. |
| `closestObstructionDistance` | `float`                   | The distance to the closest obstruction.         |
| `range`                    | `float`                   | The range of the sensor.                         |
