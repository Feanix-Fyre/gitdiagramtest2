# DialogueHandler

The `DialogueHandler` class is a component that handles dialogue.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `activeDialogue` | `DialogueContainer` | The active dialogue container. |
| `activeDialogueNode` | `DialogueNodeData` | The active dialogue node. |
| `Database` | `DialogueDatabase` | The dialogue database. |
| `LookPosition` | `Transform` | The position that the NPC will look at during dialogue. |
| `WorldspaceRend` | `WorldspaceDialogueRenderer` | The worldspace dialogue renderer. |
| `VOEmitter` | `VOEmitter` | The voice-over emitter. |
| `CurrentChoices` | `List<DialogueChoiceData>` | A list of all current choices. |
| `DialogueEvents` | `DialogueEvent[]` | An array of all dialogue events. |
| `onConversationStart` | `UnityEvent` | An event that is invoked when a conversation starts. |
| `onDialogueNodeDisplayed` | `UnityEvent<string>` | An event that is invoked when a dialogue node is displayed. |
| `onDialogueChoiceChosen` | `UnityEvent<string>` | An event that is invoked when a dialogue choice is chosen. |
| `IsPlaying` | `bool` | Returns `true` if a dialogue is currently playing. |
| `NPC` | `NPC` | The NPC that this dialogue handler is for. |
| `runtimeModules` | `List<DialogueModule>` | A list of all runtime dialogue modules. |

## Methods

### `InitializeDialogue(DialogueContainer container)`

Initializes a dialogue.

**Parameters:**

* `container`: The dialogue container to initialize.

### `InitializeDialogue(DialogueContainer dialogueContainer, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")`

Initializes a dialogue.

**Parameters:**

* `dialogueContainer`: The dialogue container to initialize.
* `enableDialogueBehaviour`: If `true`, the dialogue behaviour will be enabled.
* `entryNodeLabel`: The label of the entry node.

### `InitializeDialogue(string dialogueContainerName, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")`

Initializes a dialogue.

**Parameters:**

* `dialogueContainerName`: The name of the dialogue container to initialize.
* `enableDialogueBehaviour`: If `true`, the dialogue behaviour will be enabled.
* `entryNodeLabel`: The label of the entry node.

### `CanBeginConversation()`

Returns `true` if a conversation can be started.

**Returns:** `bool`

### `OverrideShownDialogue(string _overrideText)`

Overrides the currently shown dialogue.

**Parameters:**

* `_overrideText`: The text to override the dialogue with.

### `StopOverride()`

Stops overriding the dialogue.

### `EndDialogue()`

Ends the current dialogue.

### `SkipNextDialogueBehaviourEnd()`

Skips the next dialogue behaviour end.

### `ShowNode(DialogueNodeData node)`

Shows a dialogue node.

**Parameters:**

* `node`: The dialogue node to show.

### `ChoiceSelected(int choiceIndex)`

Called when a choice is selected.

**Parameters:**

* `choiceIndex`: The index of the choice that was selected.

### `ContinueSubmitted()`

Called when the continue button is submitted.

### `CheckChoice(string choiceLabel, out string invalidReason)`

Checks if a choice is valid.

**Parameters:**

* `choiceLabel`: The label of the choice to check.
* `invalidReason`: Returns the reason why the choice is invalid.

**Returns:** `bool`

### `ShouldChoiceBeShown(string choiceLabel)`

Returns `true` if a choice should be shown.

**Parameters:**

* `choiceLabel`: The label of the choice to check.

**Returns:** `bool`

### `Hovered()`

Called when the player hovers over the dialogue handler.

### `Interacted()`

Called when the player interacts with the dialogue handler.

### `PlayReaction_Local(string key)`

Plays a reaction locally.

**Parameters:**

* `key`: The key of the reaction to play.

### `PlayReaction_Networked(string key)`

Plays a reaction over the network.

**Parameters:**

* `key`: The key of the reaction to play.

### `PlayReaction(string key, float duration, bool network)`

Plays a reaction.

**Parameters:**

* `key`: The key of the reaction to play.
* `duration`: The duration of the reaction.
* `network`: If `true`, the reaction will be played over the network.

### `HideWorldspaceDialogue()`

Hides the worldspace dialogue.

### `ShowWorldspaceDialogue(string text, float duration)`

Shows a worldspace dialogue.

**Parameters:**

* `text`: The text to show.
* `duration`: The duration to show the text for.

### `ShowWorldspaceDialogue_5s(string text)`

Shows a worldspace dialogue for 5 seconds.

**Parameters:**

* `text`: The text to show.
