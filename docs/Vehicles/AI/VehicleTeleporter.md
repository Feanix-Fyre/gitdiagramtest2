# VehicleTeleporter

The `VehicleTeleporter` class provides methods to move a vehicle to the nearest point on a specified A* graph. It can move the vehicle to either the "General Vehicle Graph" or the "Road Nodes" graph.

## Methods

-   `MoveToGraph(bool resetRotation = true)`: Moves the vehicle to the nearest point on the "General Vehicle Graph".
-   `MoveToRoadNetwork(bool resetRotation = true)`: Moves the vehicle to the nearest point on the "Road Nodes" graph.
