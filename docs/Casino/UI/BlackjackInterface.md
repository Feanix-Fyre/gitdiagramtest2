# BlackjackInterface

The `BlackjackInterface` class is a singleton that provides a UI for the Blackjack casino game.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Canvas` | `Canvas` | The canvas for the UI. |
| `PlayerDisplay` | `CasinoGamePlayerDisplay` | The player display. |
| `BetContainer` | `RectTransform` | The container for the bet UI. |
| `BetTitleLabel` | `TextMeshProUGUI` | The title label for the bet UI. |
| `BetSlider` | `Slider` | The bet slider. |
| `BetAmount` | `TextMeshProUGUI` | The bet amount. |
| `ReadyButton` | `Button` | The ready button. |
| `ReadyLabel` | `TextMeshProUGUI` | The ready label. |
| `WaitingContainer` | `RectTransform` | The container for the waiting UI. |
| `WaitingLabel` | `TextMeshProUGUI` | The waiting label. |
| `DealerScoreLabel` | `TextMeshProUGUI` | The dealer score label. |
| `PlayerScoreLabel` | `TextMeshProUGUI` | The player score label. |
| `HitButton` | `Button` | The hit button. |
| `StandButton` | `Button` | The stand button. |
| `InputContainerAnimation` | `Animation` | The animation for the input container. |
| `InputContainerCanvasGroup` | `CanvasGroup` | The canvas group for the input container. |
| `InputContainerFadeIn` | `AnimationClip` | The fade-in animation for the input container. |
| `InputContainerFadeOut` | `AnimationClip` | The fade-out animation for the input container. |
| `SelectionIndicator` | `RectTransform` | The selection indicator. |
| `ScoresContainerAnimation` | `Animation` | The animation for the scores container. |
| `ScoresContainerCanvasGroup` | `CanvasGroup` | The canvas group for the scores container. |
| `PositiveOutcomeLabel` | `TextMeshProUGUI` | The positive outcome label. |
| `PayoutLabel` | `TextMeshProUGUI` | The payout label. |
| `onBust` | `UnityEvent` | An event that is invoked when the player busts. |
| `onBlackjack` | `UnityEvent` | An event that is invoked when the player gets blackjack. |
| `onWin` | `UnityEvent` | An event that is invoked when the player wins. |
| `onLose` | `UnityEvent` | An event that is invoked when the player loses. |
| `onPush` | `UnityEvent` | An event that is invoked when the player pushes. |
| `CurrentGame` | `BlackjackGameController` | The current game. |

## Methods

### `Open(BlackjackGameController game)`

Opens the UI for a game.

**Parameters:**

* `game`: The game to open the UI for.

### `Close()`

Closes the UI.
