# PlayerPusher

The `PlayerPusher` class is responsible for pushing the player away from the vehicle. It is attached to a trigger collider on the vehicle, and when the player enters the trigger, it applies a force to the player to push them away.

## Public Properties

| Property         | Type    | Description                                      |
| ---------------- | ------- | ------------------------------------------------ |
| `MinSpeedToPush` | `float` | The minimum speed the vehicle must be moving to push the player. |
| `MaxPushSpeed`   | `float` | The speed at which the maximum push force will be applied. |
| `MinPushForce`   | `float` | The minimum force to apply to the player.        |
| `MaxPushForce`   | `float` | The maximum force to apply to the player.        |
