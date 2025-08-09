# ACReplicator

Inherits from `MonoBehaviour`.

## Description

A base class for replicators in the avatar customization system. It subscribes to the `OnAvatarSettingsChanged` event of the `CustomizationManager` and provides a virtual method to be overridden by derived classes to handle setting changes.

## Fields

-   **propertyName**: `string`
    -   The name of the avatar setting property that this replicator is associated with.

## Methods

### Start
`private void Start()`

Subscribes the `AvatarSettingsChanged` method to the `CustomizationManager.OnAvatarSettingsChanged` event.

### AvatarSettingsChanged
`protected virtual void AvatarSettingsChanged(AvatarSettings newSettings)`

A virtual method that is called when the avatar settings change. Derived classes should override this method to implement their specific replication logic.

-   **Parameters:**
    -   `newSettings`: The new avatar settings.
