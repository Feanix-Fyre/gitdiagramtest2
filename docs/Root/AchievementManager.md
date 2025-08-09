# AchievementManager

The `AchievementManager` class is responsible for managing player achievements in the game. It interfaces with the Steamworks API to track and unlock achievements. This class is implemented as a persistent singleton, ensuring that it remains active across different scenes.

## EAchievement Enum

This enumeration defines all the possible achievements available in the game.

| Member | Description |
| --- | --- |
| `COMPLETE_PROLOGUE` | Unlocked upon completing the prologue. |
| `RV_DESTROYED` | Unlocked when the player's RV is destroyed. |
| `DEALER_RECRUITED` | Unlocked when the player recruits their first dealer. |
| `MASTER_CHEF` | Unlocked upon mastering the art of cooking. |
| `BUSINESSMAN` | Unlocked when the player achieves the rank of Businessman. |
| `BIGWIG` | Unlocked when the player achieves the rank of Bigwig. |
| `MAGNATE` | Unlocked when the player achieves the rank of Magnate. |
| `UPSTANDING_CITIZEN` | Unlocked for being an upstanding citizen. |
| `ROLLING_IN_STYLE` | Unlocked for acquiring a stylish vehicle. |
| `LONG_ARM_OF_THE_LAW` | Unlocked after a significant encounter with the law. |
| `INDIAN_DEALER` | Unlocked after dealing with a specific character. |

## Methods

### `Awake()`

This method is called when the script instance is being loaded. It initializes the `AchievementManager` by populating the list of achievements and setting their initial unlocked status to `false`.

### `Start()`

Called before the first frame update, this method pulls the latest achievement status from the Steamworks API to synchronize with the local game state.

### `PullAchievements()`

This private method fetches the current status of all achievements from Steamworks. It updates a local dictionary to reflect which achievements the player has already unlocked.

### `UnlockAchievement(EAchievement achievement)`

This public method is used to unlock a specific achievement for the player. It checks if Steamworks is initialized and if the achievement is not already unlocked before proceeding.

- **Parameters:**
  - `achievement`: The `EAchievement` enum member representing the achievement to unlock.
