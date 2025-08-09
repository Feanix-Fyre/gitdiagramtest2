# WorldspacePopupCanvas

The `WorldspacePopupCanvas` class is responsible for managing all the `WorldspacePopupUI`s in the scene. It creates and destroys the UI for the popups, and it also updates their position and scale.

## Public Properties

| Property                   | Type            | Description                                      |
| -------------------------- | --------------- | ------------------------------------------------ |
| `WorldspaceContainer`      | `RectTransform` | The container for the worldspace popups.         |
| `HudContainer`             | `RectTransform` | The container for the HUD popups.                |
| `HudIconContainerPrefab`   | `GameObject`    | The prefab for the HUD icon container.           |
