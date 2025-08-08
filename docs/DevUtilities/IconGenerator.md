# IconGenerator

The `IconGenerator` class is a singleton that provides methods for generating icons for items.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `IconSize` | `int` | The size of the icons to generate. |
| `OutputPath` | `string` | The path to output the icons to. |
| `ModifyLighting` | `bool` | If `true`, the lighting will be modified when generating icons. |
| `Registry` | `Registry` | The registry to use for getting item definitions. |
| `CameraPosition` | `Camera` | The camera to use for generating icons. |
| `MainContainer` | `Transform` | The main container for the icon generator. |
| `ItemContainer` | `Transform` | The container for the item to generate an icon for. |
| `Canvas` | `GameObject` | The canvas for the icon generator. |
| `Visuals` | `List<PackagingVisuals>` | A list of packaging visuals. |

## Methods

### `GenerateIcon()`

Generates an icon for the currently active item in the item container.

### `GeneratePackagingIcon(string packagingID, string productID)`

Generates an icon for a packaged product.

**Parameters:**

* `packagingID`: The ID of the packaging.
* `productID`: The ID of the product.

**Returns:** `Texture2D`

### `GetTexture(Transform model)`

Gets a texture for a model.

**Parameters:**

* `model`: The model to get a texture for.

**Returns:** `Texture2D`
