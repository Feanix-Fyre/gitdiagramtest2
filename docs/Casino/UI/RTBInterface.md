# RTBInterface

The `RTBInterface` class is a singleton that provides a UI for the Red or Black casino game.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Canvas` | `Canvas` | The canvas for the UI. |
| `PlayerDisplay` | `CasinoGamePlayerDisplay` | The player display. |
| `StatusLabel` | `TextMeshProUGUI` | The status label. |
| `BetContainer` | `RectTransform` | The container for the bet UI. |
| `BetTitleLabel` | `TextMeshProUGUI` | The title label for the bet UI. |
| `BetSlider` | `Slider` | The bet slider. |
| `BetAmount` | `TextMeshProUGUI` | The bet amount. |
| `ReadyButton` | `Button` | The ready button. |
| `ReadyLabel` | `TextMeshProUGUI` | The ready label. |
| `WinningsMultiplierLabel` | `TextMeshProUGUI` | The winnings multiplier label. |
| `QuestionContainer` | `RectTransform` | The container for the question UI. |
| `QuestionLabel` | `TextMeshProUGUI` | The question label. |
| `TimerSlider` | `Slider` | The timer slider. |
| `AnswerButtons` | `Button[]` | An array of answer buttons. |
| `AnswerLabels` | `TextMeshProUGUI[]` | An array of answer labels. |
| `ForfeitButton` | `Button` | The forfeit button. |
| `ForfeitLabel` | `TextMeshProUGUI` | The forfeit label. |
| `QuestionContainerAnimation` | `Animation` | The animation for the question container. |
| `QuestionContainerFadeIn` | `AnimationClip` | The fade-in animation for the question container. |
| `QuestionContainerFadeOut` | `AnimationClip` | The fade-out animation for the question container. |
| `QuestionCanvasGroup` | `CanvasGroup` | The canvas group for the question UI. |
| `SelectionIndicator` | `RectTransform` | The selection indicator. |
| `onCorrect` | `UnityEvent` | An event that is invoked when the player answers a question correctly. |
| `onFinalCorrect` | `UnityEvent` | An event that is invoked when the player answers the final question correctly. |
| `onIncorrect` | `UnityEvent` | An event that is invoked when the player answers a question incorrectly. |
| `CurrentGame` | `RTBGameController` | The current game. |

## Methods

### `Open(RTBGameController game)`

Opens the UI for a game.

**Parameters:**

* `game`: The game to open the UI for.

### `Close()`

Closes the UI.
