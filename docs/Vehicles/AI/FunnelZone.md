# FunnelZone

The `FunnelZone` class defines a zone that funnels vehicles towards an entry point.

## Public Properties

| Property      | Type                  | Description                                      |
| ------------- | --------------------- | ------------------------------------------------ |
| `funnelZones` | `List<FunnelZone>`    | A static list of all `FunnelZone`s in the scene. |
| `col`         | `BoxCollider`         | The collider that defines the zone.              |
| `entryPoint`  | `Transform`           | The entry point of the zone.                     |

## Public Methods

| Method           | Return Type  | Description                               |
| ---------------- | ------------ | ----------------------------------------- |
| `GetFunnelZone(Vector3 point)` | `FunnelZone` | Gets the `FunnelZone` that contains a given point. |
