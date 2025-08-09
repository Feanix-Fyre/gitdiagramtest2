# CasinoGamePlayers

The `CasinoGamePlayers` class is a network behaviour that manages the players in a casino game.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `PlayerLimit` | `int` | The maximum number of players that can join the game. |
| `onPlayerListChanged` | `UnityEvent` | An event that is invoked when the player list changes. |
| `onPlayerScoresChanged` | `UnityEvent` | An event that is invoked when the player scores change. |
| `CurrentPlayerCount` | `int` | The current number of players in the game. |

## Methods

### `AddPlayer(Player player)`

Adds a player to the game.

**Parameters:**

* `player`: The player to add.

### `RemovePlayer(Player player)`

Removes a player from the game.

**Parameters:**

* `player`: The player to remove.

### `SetPlayerScore(Player player, int score)`

Sets the score for a player.

**Parameters:**

* `player`: The player to set the score for.
* `score`: The score to set.

### `GetPlayerScore(Player player)`

Gets the score for a player.

**Parameters:**

* `player`: The player to get the score for.

**Returns:** `int`

### `GetPlayer(int index)`

Gets a player by their index.

**Parameters:**

* `index`: The index of the player to get.

**Returns:** `Player`

### `GetPlayerIndex(Player player)`

Gets the index of a player.

**Parameters:**

* `player`: The player to get the index of.

**Returns:** `int`

### `GetPlayerData()`

Gets the player data for the local player.

**Returns:** `CasinoGamePlayerData`

### `GetPlayerData(Player player)`

Gets the player data for a player.

**Parameters:**

* `player`: The player to get the data for.

**Returns:** `CasinoGamePlayerData`

### `GetPlayerData(int index)`

Gets the player data for a player by their index.

**Parameters:**

* `index`: The index of the player to get the data for.

**Returns:** `CasinoGamePlayerData`

### `SendPlayerBool(NetworkObject playerObject, string key, bool value)`

Sends a boolean value to a player.

**Parameters:**

* `playerObject`: The network object of the player to send the value to.
* `key`: The key of the value to send.
* `value`: The value to send.

### `SendPlayerFloat(NetworkObject playerObject, string key, float value)`

Sends a float value to a player.

**Parameters:**

* `playerObject`: The network object of the player to send the value to.
* `key`: The key of the value to send.
* `value`: The value to send.
