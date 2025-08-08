# CookableModule

The `CookableModule` class is a type of `ItemModule` that represents a cookable item in a station. It defines the cooking time, type, and the resulting product.

## ECookableType (Enum)

| Value   | Description                       |
| ------- | --------------------------------- |
| `Liquid`| Represents a liquid cookable type.|
| `Solid` | Represents a solid cookable type. |

## Public Properties

| Property             | Type                     | Description                                      |
| -------------------- | ------------------------ | ------------------------------------------------ |
| `CookTime`           | `int`                    | The time required to cook the item.              |
| `CookType`           | `ECookableType`          | The type of the cookable item (Liquid or Solid). |
| `Product`            | `StorableItemDefinition` | The definition of the item produced after cooking. |
| `ProductQuantity`    | `int`                    | The quantity of the product produced.            |
| `ProductShardPrefab` | `Rigidbody`              | A prefab for the product shard.                  |
| `LiquidColor`        | `Color`                  | The color of the liquid when cooking.            |
| `SolidColor`         | `Color`                  | The color of the solid when cooking.             |
