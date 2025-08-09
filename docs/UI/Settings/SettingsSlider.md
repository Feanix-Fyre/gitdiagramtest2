# SettingsSlider

The `SettingsSlider` class is a base class for settings sliders. It gets a reference to the `Slider` component and registers a listener for the `onValueChanged` event. It also has functionality for displaying the current value of the slider.

## Public Properties

| Property     | Type | Description                                      |
| ------------ | ---- | ------------------------------------------------ |
| `DisplayValue` | `bool` | If true, the current value of the slider will be displayed. |

## Protected Properties

| Property             | Type              | Description                                      |
| -------------------- | ----------------- | ------------------------------------------------ |
| `slider`             | `Slider`          | The `Slider` component for this setting.         |
| `valueLabel`         | `TextMeshProUGUI` | The label for the slider's value.                |
| `timeOnValueChange`  | `float`           | The time when the value of the slider last changed. |

## Protected Methods

| Method               | Return Type | Description                                      |
| -------------------- | ----------- | ------------------------------------------------ |
| `Awake()`            | `void`      | Initializes the component.                       |
| `Update()`           | `void`      | Updates the component.                           |
| `OnValueChanged(float value)` | `void` | Called when the value of the slider changes.     |
| `GetDisplayValue(float value)` | `string` | Gets the string representation of the slider's value. |
