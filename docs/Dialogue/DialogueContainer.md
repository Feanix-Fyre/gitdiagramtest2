# DialogueContainer

The `DialogueContainer` class is a scriptable object that contains all the data for a dialogue.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `NodeLinks` | `List<NodeLinkData>` | A list of all node links in the dialogue. |
| `DialogueNodeData` | `List<DialogueNodeData>` | A list of all dialogue nodes in the dialogue. |
| `BranchNodeData` | `List<BranchNodeData>` | A list of all branch nodes in the dialogue. |
| `allowExit` | `bool` | If `true`, the player can exit the dialogue. |
| `AllowExit` | `bool` | Returns `true` if the player can exit the dialogue. |

## Methods

### `GetDialogueNodeByLabel(string dialogueNodeLabel)`

Gets a dialogue node by its label.

**Parameters:**

* `dialogueNodeLabel`: The label of the dialogue node to get.

**Returns:** `DialogueNodeData`

### `GetBranchNodeByLabel(string branchLabel)`

Gets a branch node by its label.

**Parameters:**

* `branchLabel`: The label of the branch node to get.

**Returns:** `BranchNodeData`

### `GetDialogueNodeByGUID(string dialogueNodeGUID)`

Gets a dialogue node by its GUID.

**Parameters:**

* `dialogueNodeGUID`: The GUID of the dialogue node to get.

**Returns:** `DialogueNodeData`

### `GetBranchNodeByGUID(string branchGUID)`

Gets a branch node by its GUID.

**Parameters:**

* `branchGUID`: The GUID of the branch node to get.

**Returns:** `BranchNodeData`

### `GetLink(string baseChoiceOrOptionGUID)`

Gets a node link by its base choice or option GUID.

**Parameters:**

* `baseChoiceOrOptionGUID`: The GUID of the base choice or option to get the link for.

**Returns:** `NodeLinkData`

### `SetAllowExit(bool allowed)`

Sets whether the player can exit the dialogue.

**Parameters:**

* `allowed`: If `true`, the player can exit the dialogue.
