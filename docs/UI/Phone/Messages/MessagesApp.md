# MessagesApp

The `MessagesApp` class is the UI for the messaging app on the phone. It displays a list of conversations, and it allows the player to open a conversation to view the messages. It also has a detail panel that shows information about the contact.

## Classes

### CategoryInfo

This class is a data container for a conversation category.

-   `Category`: The `EConversationCategory` of the category.
-   `Name`: The name of the category.
-   `Color`: The color of the category.

## Public Properties

| Property                   | Type                      | Description                                      |
| -------------------------- | ------------------------- | ------------------------------------------------ |
| `Conversations`            | `List<MSGConversation>`   | A static list of all the conversations.          |
| `ActiveConversations`      | `List<MSGConversation>`   | A static list of all the active conversations.   |
| `categoryInfos`            | `List<CategoryInfo>`      | A list of all the category infos.                |
| `homePage`                 | `GameObject`              | The home page of the app.                        |
| `dialoguePage`             | `GameObject`              | The dialogue page of the app.                    |
| `dialoguePageNameText`     | `Text`                    | The text for the name on the dialogue page.      |
| `relationshipContainer`    | `RectTransform`           | The container for the relationship UI.           |
| `relationshipScrollbar`    | `Scrollbar`               | The scrollbar for the relationship UI.           |
| `relationshipTooltip`      | `Tooltip`                 | The tooltip for the relationship UI.             |
| `standardsContainer`       | `RectTransform`           | The container for the standards UI.              |
| `standardsStar`            | `Image`                   | The image for the standards star.                |
| `standardsTooltip`         | `Tooltip`                 | The tooltip for the standards UI.                |
| `iconContainerRect`        | `RectTransform`           | The rect transform for the icon container.       |
| `iconImage`                | `Image`                   | The image for the icon.                          |
| `BlankAvatarSprite`        | `Sprite`                  | The sprite to use for when there is no avatar.   |
| `DealWindowSelector`       | `DealWindowSelector`      | The deal window selector.                        |
| `PhoneShopInterface`       | `PhoneShopInterface`      | The phone shop interface.                        |
| `CounterofferInterface`    | `CounterofferInterface`   | The counteroffer interface.                      |
| `ClearFilterButton`        | `RectTransform`           | The button to clear the filter.                  |
| `CategoryButtons`          | `Button[]`                | An array of buttons for the categories.          |
| `MessageReceivedSound`     | `AudioSourceController`   | The sound to play when a message is received.    |
| `MessageSentSound`         | `AudioSourceController`   | The sound to play when a message is sent.        |
| `unreadConversations`      | `List<MSGConversation>`   | A list of all the unread conversations.          |
| `currentConversation`      | `MSGConversation`         | The currently open conversation.                 |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `CreateConversationUI(MSGConversation c, out RectTransform entry, out RectTransform container)` | `void` | Creates the UI for a conversation.               |
| `RepositionEntries()`                       | `void`      | Repositions the conversation entries.            |
| `ReturnButtonClicked()`                     | `void`      | Called when the return button is clicked.        |
| `RefreshNotifications()`                    | `void`      | Refreshes the notifications.                     |
| `Exit(ExitAction exit)`                     | `void`      | Called when the player exits the app.            |
| `SetCurrentConversation(MSGConversation conversation)` | `void` | Sets the current conversation.                   |
| `GetCategoryInfo(EConversationCategory category)` | `CategoryInfo` | Gets the category info for a category.           |
| `FilterByCategory(int category)`            | `void`      | Filters the conversations by a category.         |
| `ClearFilter()`                             | `void`      | Clears the filter.                               |
