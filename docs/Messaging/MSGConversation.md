# MSGConversation

The `MSGConversation` class represents a conversation between the player and an NPC.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `contactName` | `string` | The name of the contact. |
| `sender` | `NPC` | The NPC that is the sender of the messages. |
| `messageHistory` | `List<Message>` | A list of all messages in the conversation. |
| `messageChainHistory` | `List<MessageChain>` | A list of all message chains in the conversation. |
| `bubbles` | `List<MessageBubble>` | A list of all message bubbles in the conversation. |
| `Sendables` | `List<SendableMessage>` | A list of all sendable messages in the conversation. |
| `read` | `bool` | If `true`, the conversation has been read. |
| `Categories` | `List<EConversationCategory>` | A list of all categories that the conversation belongs to. |
| `entry` | `RectTransform` | The rect transform of the conversation entry in the message list. |
| `onMessageRendered` | `Action` | An event that is invoked when a message is rendered. |
| `onLoaded` | `Action` | An event that is invoked when the conversation is loaded. |
| `onResponsesShown` | `Action` | An event that is invoked when responses are shown. |
| `currentResponses` | `List<Response>` | A list of all current responses. |
| `IsSenderKnown` | `bool` | Returns `true` if the sender is known. |
| `index` | `int` | The index of the conversation in the message list. |
| `isOpen` | `bool` | Returns `true` if the conversation is open. |
| `rollingOut` | `bool` | Returns `true` if the conversation is rolling out. |
| `EntryVisible` | `bool` | Returns `true` if the conversation entry is visible. |
| `AreResponsesActive` | `bool` | Returns `true` if there are active responses. |
| `SaveFolderName` | `string` | The name of the folder where the save files are stored. |
| `SaveFileName` | `string` | The name of the save file. |
| `Loader` | `Loader` | The loader for the conversation data. |
| `ShouldSaveUnderFolder` | `bool` | Returns `true` if the save file should be saved under a folder. |
| `LocalExtraFiles` | `List<string>` | A list of extra files to save. |
| `LocalExtraFolders` | `List<string>` | A list of extra folders to save. |
| `HasChanged` | `bool` | Returns `true` if the conversation data has changed and needs to be saved. |

## Constructors

### `MSGConversation(NPC _npc, string _contactName)`

Initializes a new instance of the `MSGConversation` class.

**Parameters:**

* `_npc`: The NPC that is the sender of the messages.
* `_contactName`: The name of the contact.

## Methods

### `InitializeSaveable()`

Initializes the saveable object.

### `SetCategories(List<EConversationCategory> cat)`

Sets the categories of the conversation.

**Parameters:**

* `cat`: The categories to set.

### `MoveToTop()`

Moves the conversation to the top of the message list.

### `RepositionEntry()`

Repositions the conversation entry in the message list.

### `SetIsKnown(bool known)`

Sets whether the sender is known.

**Parameters:**

* `known`: If `true`, the sender is known.

### `EntryClicked()`

Called when the conversation entry is clicked.

### `SetOpen(bool open)`

Sets whether the conversation is open.

**Parameters:**

* `open`: If `true`, the conversation is open.

### `SetEntryVisibility(bool v)`

Sets the visibility of the conversation entry.

**Parameters:**

* `v`: If `true`, the conversation entry is visible.

### `SetRead(bool r)`

Sets whether the conversation has been read.

**Parameters:**

* `r`: If `true`, the conversation has been read.

### `SendMessage(Message message, bool notify = true, bool network = true)`

Sends a message.

**Parameters:**

* `message`: The message to send.
* `notify`: If `true`, a notification will be shown for the message.
* `network`: If `true`, the message will be sent over the network.

### `SendMessageChain(MessageChain messages, float initialDelay = 0f, bool notify = true, bool network = true)`

Sends a message chain.

**Parameters:**

* `messages`: The message chain to send.
* `initialDelay`: The initial delay before sending the message chain.
* `notify`: If `true`, a notification will be shown for the message chain.
* `network`: If `true`, the message chain will be sent over the network.

### `GetSaveData()`

Gets the save data for the conversation.

**Returns:** `MSGConversationData`

### `GetSaveString()`

Gets the save string for the conversation data.

**Returns:** `string`

### `Load(MSGConversationData data)`

Loads the conversation data.

**Parameters:**

* `data`: The conversation data to load.

### `SetSliderValue(float value, Color color)`

Sets the value of the slider in the conversation entry.

**Parameters:**

* `value`: The value to set.
* `color`: The color to set.

### `GetResponse(string label)`

Gets a response by its label.

**Parameters:**

* `label`: The label of the response to get.

**Returns:** `Response`

### `ShowResponses(List<Response> _responses, float showResponseDelay = 0f, bool network = true)`

Shows a list of responses.

**Parameters:**

* `_responses`: The list of responses to show.
* `showResponseDelay`: The delay before showing the responses.
* `network`: If `true`, the responses will be shown over the network.

### `SetResponseContainerVisible(bool v)`

Sets the visibility of the response container.

**Parameters:**

* `v`: If `true`, the response container is visible.

### `ResponseChosen(Response r, bool network)`

Called when a response is chosen.

**Parameters:**

* `r`: The response that was chosen.
* `network`: If `true`, the response will be sent over the network.

### `ClearResponses(bool network = false)`

Clears the responses.

**Parameters:**

* `network`: If `true`, the responses will be cleared over the network.

### `CreateSendableMessage(string text)`

Creates a sendable message.

**Parameters:**

* `text`: The text of the message.

**Returns:** `SendableMessage`

### `SendPlayerMessage(int sendableIndex, int sentIndex, bool network)`

Sends a player message.

**Parameters:**

* `sendableIndex`: The index of the sendable message.
* `sentIndex`: The index of the sent message.
* `network`: If `true`, the message will be sent over the network.

### `RenderPlayerMessage(SendableMessage sendable)`

Renders a player message.

**Parameters:**

* `sendable`: The sendable message to render.
