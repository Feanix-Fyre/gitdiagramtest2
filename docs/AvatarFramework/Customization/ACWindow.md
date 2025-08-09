# ACWindow

Inherits from `MonoBehaviour`.

## Description

This class manages a window within the avatar customization UI. It handles the window's title, a back button for navigation to a predecessor window, and methods for opening and closing the window.

## Fields

-   **WindowTitle**: `string`
    -   The title to be displayed at the top of the window.
-   **Predecessor**: `ACWindow`
    -   A reference to the previous window in the navigation stack. If this is not null, a back button will be displayed.
-   **TitleText**: `TextMeshProUGUI`
    -   A reference to the UI text element for the window's title.
-   **BackButton**: `Button`
    -   A reference to the back button UI element.

## Methods

### Start
`private void Start()`

Initializes the window. It sets the title text, configures the back button's visibility and listener based on whether a `Predecessor` is assigned, and deactivates the window if it has a predecessor.

### Open
`public void Open()`

Activates the window's game object, making it visible.

### Close
`public void Close()`

Deactivates the window's game object. If a `Predecessor` window exists, it calls the `Open()` method on it.
