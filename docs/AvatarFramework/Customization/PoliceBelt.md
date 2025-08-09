# PoliceBelt

Inherits from `Accessory`.

## Description

This class represents a police duty belt accessory. It extends the `Accessory` class to include references to specific items on the belt (baton, taser, gun) and provides methods to control their visibility.

## Fields

-   **BatonObject**: `GameObject`
    -   A reference to the baton game object on the belt.
-   **TaserObject**: `GameObject`
    -   A reference to the taser game object on the belt.
-   **GunObject**: `GameObject`
    -   A reference to the gun game object on the belt.

## Methods

### SetBatonVisible
`public void SetBatonVisible(bool vis)`

Sets the visibility of the baton object.

-   **Parameters:**
    -   `vis`: True to make the baton visible, false to hide it.

### SetTaserVisible
`public void SetTaserVisible(bool vis)`

Sets the visibility of the taser object.

-   **Parameters:**
    -   `vis`: True to make the taser visible, false to hide it.

### SetGunVisible
`public void SetGunVisible(bool vis)`

Sets the visibility of the gun object.

-   **Parameters:**
    -   `vis`: True to make the gun visible, false to hide it.
