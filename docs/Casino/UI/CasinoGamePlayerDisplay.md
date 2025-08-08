# CasinoGamePlayerDisplay

The `CasinoGamePlayerDisplay` class is a component that displays the players in a casino game.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `BindedPlayers` | `CasinoGamePlayers` | The players that are bound to this display. |
| `TitleLabel` | `TextMeshProUGUI` | The title label for the display. |
| `PlayerEntries` | `RectTransform[]` | An array of player entries. |

## Methods

### `RefreshPlayers()`

Refreshes the player display.

### `RefreshScores()`

Refreshes the player scores.

### `Bind(CasinoGamePlayers players)`

Binds the display to a `CasinoGamePlayers` object.

**Parameters:**

* `players`: The `CasinoGamePlayers` object to bind to.

### `Unbind()`

Unbinds the display from the `CasinoGamePlayers` object.
