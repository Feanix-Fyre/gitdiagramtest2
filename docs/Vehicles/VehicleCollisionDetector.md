# VehicleCollisionDetector

The `VehicleCollisionDetector` class is a MonoBehaviour that is used to broadcast collision events to other components.

## Public Properties

| Property         | Type                  | Description                                      |
| ---------------- | --------------------- | ------------------------------------------------ |
| `onCollisionEnter` | `UnityEvent<Collision>` | An event that is invoked when a collision occurs. |

## Public Methods

| Method                  | Return Type | Description                               |
| ----------------------- | ----------- | ----------------------------------------- |
| `OnCollisionEnter(Collision collision)` | `void`      | Invokes the `onCollisionEnter` event.     |
