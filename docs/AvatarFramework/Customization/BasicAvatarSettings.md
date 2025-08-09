# BasicAvatarSettings

Inherits from `ScriptableObject`.

## Description

A `ScriptableObject` that holds a simplified set of avatar customization settings. This class provides a more user-friendly way to define an avatar's appearance, which can then be converted into a full `AvatarSettings` object.

## Fields

-   **Gender**: `int` - 0 for male, 1 for female.
-   **Weight**: `float`
-   **SkinColor**: `Color`
-   **HairStyle**: `string` - Asset path for the hair style.
-   **HairColor**: `Color`
-   **Mouth**: `string` - Asset path for the mouth.
-   **FacialHair**: `string` - Asset path for facial hair.
-   **FacialDetails**: `string` - Asset path for facial details like freckles.
-   **FacialDetailsIntensity**: `float`
-   **EyeballColor**: `Color`
-   **UpperEyeLidRestingPosition**: `float`
-   **LowerEyeLidRestingPosition**: `float`
-   **PupilDilation**: `float`
-   **EyebrowScale**: `float`
-   **EyebrowThickness**: `float`
-   **EyebrowRestingHeight**: `float`
-   **EyebrowRestingAngle**: `float`
-   **Top**: `string` - Asset path for the top clothing item.
-   **TopColor**: `Color`
-   **Bottom**: `string` - Asset path for the bottom clothing item.
-   **BottomColor**: `Color`
-   **Shoes**: `string` - Asset path for shoes.
-   **ShoesColor**: `Color`
-   **Headwear**: `string` - Asset path for headwear.
-   **HeadwearColor**: `Color`
-   **Eyewear**: `string` - Asset path for eyewear.
-   **EyewearColor**: `Color`
-   **Tattoos**: `List<string>` - A list of asset paths for tattoos.

## Methods

### SetValue<T>
`public T SetValue<T>(string fieldName, T value)`

Sets the value of a specified field using reflection.

-   **Parameters:**
    -   `fieldName`: The name of the field to set.
    -   `value`: The new value for the field.
-   **Returns:** The value that was set.

### GetValue<T>
`public T GetValue<T>(string fieldName)`

Gets the value of a specified field using reflection.

-   **Parameters:**
    -   `fieldName`: The name of the field to get.
-   **Returns:** The value of the field, or the default value of type `T` if the field is not found.

### GetAvatarSettings
`public AvatarSettings GetAvatarSettings()`

Converts the `BasicAvatarSettings` into a full `AvatarSettings` object, mapping the simplified fields to the more complex structure of `AvatarSettings`.

-   **Returns:** A new `AvatarSettings` instance configured with the settings from this object.

### GetJson
`public virtual string GetJson(bool prettyPrint = true)`

Serializes the object to a JSON string.

-   **Parameters:**
    -   `prettyPrint`: If true, the JSON will be formatted for readability.
-   **Returns:** A JSON representation of the object.
