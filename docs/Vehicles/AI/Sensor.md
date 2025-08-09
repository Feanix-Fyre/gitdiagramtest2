# Sensor

The `Sensor` class is a sensor that can be attached to a vehicle to detect obstacles. It uses a spherecast to check for obstacles in front of it and updates the `obstruction` and `obstructionDistance` properties accordingly.

## Properties

-   `obstruction`: The `Collider` of the obstacle that was detected.
-   `obstructionDistance`: The distance to the obstacle that was detected.
-   `minDetectionRange`: The minimum range of the sensor.
-   `maxDetectionRange`: The maximum range of the sensor.
-   `checkRadius`: The radius of the spherecast.
-   `checkMask`: The layer mask to use for the spherecast.
-   `calculatedDetectionRange`: The calculated detection range of the sensor, based on the vehicle's speed.

## Methods

-   `Check()`: Performs a spherecast to check for obstacles.
