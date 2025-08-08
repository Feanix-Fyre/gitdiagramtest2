# ImpactSoundEntity

The `ImpactSoundEntity` class plays a sound when the object it's attached to collides with another object. The sound played is determined by the `Material` property. This component requires a `Rigidbody`.

## EMaterial (Enum)

Defines the material type of the object, which determines the impact sound.

| Value              | Description                  |
| ------------------ | ---------------------------- |
| `Wood`             | Wood material.               |
| `HollowMetal`      | Hollow metal material.       |
| `Cardboard`        | Cardboard material.          |
| `Glass`            | Glass material.              |
| `Plastic`          | Plastic material.            |
| `Basketball`       | Basketball material.         |
| `SmallHollowMetal` | Small hollow metal material. |
| `PlasticBag`       | Plastic bag material.        |
| `Punch`            | Punch sound.                 |
| `BaseballBat`      | Baseball bat sound.          |

## Public Constants

| Constant              | Type    | Description                                       |
| --------------------- | ------- | ------------------------------------------------- |
| `MIN_IMPACT_MOMENTUM` | `float` | The minimum impact momentum required to play a sound. |
| `COOLDOWN`            | `float` | The cooldown time between impact sounds.            |

## Public Properties

| Property   | Type      | Description                          |
| ---------- | --------- | ------------------------------------ |
| `Material` | `EMaterial` | The material type of the object.     |
