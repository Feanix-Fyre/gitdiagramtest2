# ObjectSelector

The `ObjectSelector` class is a singleton that provides a UI for selecting objects in the world.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `onClose` | `Action` | An event that is invoked when the object selector is closed. |
| `isSelecting` | `bool` | Returns `true` if the object selector is currently active. |

## Methods

### `StartSelecting(string selectionTitle, List<Type> _typeRestriction, ref List<BuildableItem> initialSelection_Objects, ref List<Constructable> initalSelection_Constructables, int _selectionLimit, bool _exitOnSelectionLimit)`

Starts the object selection process.

**Parameters:**

* `selectionTitle`: The title of the selection screen.
* `_typeRestriction`: A list of types that can be selected.
* `initialSelection_Objects`: A list of initially selected buildable items.
* `initalSelection_Constructables`: A list of initially selected constructables.
* `_selectionLimit`: The maximum number of objects that can be selected.
* `_exitOnSelectionLimit`: If `true`, the selection screen will be closed when the selection limit is reached.

### `StopSelecting()`

Stops the object selection process.
