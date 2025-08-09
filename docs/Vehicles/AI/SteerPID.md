# SteerPID

The `SteerPID` class implements a PID (Proportional-Integral-Derivative) controller for steering. It takes an error value and a set of PID parameters and returns a new value that can be used to control the steering of a vehicle.

## Methods

-   `GetNewValue(float error, PID_Parameters pid_parameters)`: Calculates and returns a new steering value based on the given error and PID parameters.
-   `AddValueToAverage(float oldAverage, float valueToAdd, float count)`: A utility method for adding a value to an average.
