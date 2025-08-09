# Employee

The `Employee` class represents an employee. It inherits from the `NPC` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `SigningFee` | `float` | The signing fee for the employee. |
| `DailyWage` | `float` | The daily wage of the employee. |
| `WaitOutside` | `IdleBehaviour` | The idle behaviour for when the employee is waiting outside. |
| `MoveItemBehaviour` | `MoveItemBehaviour` | The behaviour for moving items. |
| `BedNotAssignedDialogue` | `DialogueContainer` | The dialogue to play when the employee has not been assigned a bed. |
| `NotPaidDialogue` | `DialogueContainer` | The dialogue to play when the employee has not been paid. |
| `WorkIssueDialogueTemplate` | `DialogueContainer` | The template for the work issue dialogue. |
| `FireDialogue` | `DialogueContainer` | The dialogue for firing the employee. |
| `AssignedProperty` | `Property` | The property that the employee is assigned to. |
| `EmployeeIndex` | `int` | The index of the employee. |
| `PaidForToday` | `bool` | Returns `true` if the employee has been paid for today. |
| `Fired` | `bool` | Returns `true` if the employee has been fired. |
| `IsWaitingOutside` | `bool` | Returns `true` if the employee is waiting outside. |
| `IsMale` | `bool` | Returns `true` if the employee is male. |
| `EmployeeType` | `EEmployeeType` | The type of the employee. |
| `TimeSinceLastWorked` | `int` | The time since the employee last worked. |

## Methods

### `Initialize(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)`

Initializes the employee.

**Parameters:**

* `conn`: The network connection.
* `firstName`: The first name of the employee.
* `lastName`: The last name of the employee.
* `id`: The ID of the employee.
* `guid`: The GUID of the employee.
* `propertyID`: The ID of the property that the employee is assigned to.
* `male`: If `true`, the employee is male.
* `appearanceIndex`: The appearance index of the employee.

### `SendFire()`

Sends an RPC to all clients to fire the employee.

### `SetIsPaid()`

Sets whether the employee has been paid for today.

### `ShouldSave()`

Returns `true` if the employee should be saved.

**Returns:** `bool`

### `GetSaveString()`

Gets the save string for the employee.

**Returns:** `string`

### `GetBed()`

Gets the bed that the employee is assigned to.

**Returns:** `BedItem`

### `IsPayAvailable()`

Returns `true` if pay is available for the employee.

**Returns:** `bool`

### `RemoveDailyWage()`

Removes the daily wage from the employee's bed.

### `GetWorkIssue(out DialogueContainer notWorkingReason)`

Gets the work issue for the employee.

**Parameters:**

* `notWorkingReason`: Returns the reason why the employee is not working.

**Returns:** `bool`

### `SetIdle(bool idle)`

Sets whether the employee is idle.

**Parameters:**

* `idle`: If `true`, the employee is idle.

### `SubmitNoWorkReason(string reason, string fix, int priority = 0)`

Submits a reason why the employee is not working.

**Parameters:**

* `reason`: The reason why the employee is not working.
* `fix`: The fix for the issue.
* `priority`: The priority of the issue.
