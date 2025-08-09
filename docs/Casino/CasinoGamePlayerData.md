# CasinoGamePlayerData

The `CasinoGamePlayerData` class contains data for a player in a casino game.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Parent` | `CasinoGamePlayers` | The parent `CasinoGamePlayers` object. |
| `Player` | `Player` | The player that this data is for. |

## Constructors

### `CasinoGamePlayerData(CasinoGamePlayers parent, Player player)`

Initializes a new instance of the `CasinoGamePlayerData` class.

**Parameters:**

* `parent`: The parent `CasinoGamePlayers` object.
* `player`: The player that this data is for.

## Methods

### `GetData<T>(string key)`

Gets data from the player's data.

**Parameters:**

* `key`: The key of the data to get.

**Returns:** `T`

### `SetData<T>(string key, T value, bool network = true)`

Sets data in the player's data.

**Parameters:**

* `key`: The key of the data to set.
* `value`: The value to set.
* `network`: If `true`, the data will be sent over the network.
