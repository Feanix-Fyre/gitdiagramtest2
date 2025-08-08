# EmployeeManager

The `EmployeeManager` class is a network singleton that manages employees.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `AllEmployees` | `List<Employee>` | A list of all employees. |
| `EmployeeQuests` | `Quest_Employees[]` | An array of all employee quests. |
| `BotanistPrefab` | `Botanist` | The prefab for the botanist. |
| `PackagerPrefab` | `Packager` | The prefab for the packager. |
| `ChemistPrefab` | `Chemist` | The prefab for the chemist. |
| `CleanerPrefab` | `Cleaner` | The prefab for the cleaner. |
| `MaleAppearances` | `List<EmployeeAppearance>` | A list of all male appearances. |
| `FemaleAppearances` | `List<EmployeeAppearance>` | A list of all female appearances. |
| `MaleVoices` | `VODatabase[]` | An array of all male voices. |
| `FemaleVoices` | `VODatabase[]` | An array of all female voices. |
| `MaleFirstNames` | `string[]` | An array of all male first names. |
| `FemaleFirstNames` | `string[]` | An array of all female first names. |
| `LastNames` | `string[]` | An array of all last names. |

## Methods

### `CreateNewEmployee(Property property, EEmployeeType type)`

Creates a new employee.

**Parameters:**

* `property`: The property to create the employee for.
* `type`: The type of employee to create.

### `CreateEmployee(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")`

Creates an employee.

**Parameters:**

* `property`: The property to create the employee for.
* `type`: The type of employee to create.
* `firstName`: The first name of the employee.
* `lastName`: The last name of the employee.
* `id`: The ID of the employee.
* `male`: If `true`, the employee is male.
* `appearanceIndex`: The appearance index of the employee.
* `position`: The position of the employee.
* `rotation`: The rotation of the employee.
* `guid`: The GUID of the employee.

### `CreateEmployee_Server(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid)`

Creates an employee on the server.

**Parameters:**

* `property`: The property to create the employee for.
* `type`: The type of employee to create.
* `firstName`: The first name of the employee.
* `lastName`: The last name of the employee.
* `id`: The ID of the employee.
* `male`: If `true`, the employee is male.
* `appearanceIndex`: The appearance index of the employee.
* `position`: The position of the employee.
* `rotation`: The rotation of the employee.
* `guid`: The GUID of the employee.

**Returns:** `Employee`

### `RegisterName(string name)`

Registers a name.

**Parameters:**

* `name`: The name to register.

### `RegisterAppearance(bool male, int index)`

Registers an appearance.

**Parameters:**

* `male`: If `true`, the appearance is for a male.
* `index`: The index of the appearance.

### `GenerateRandomName(bool male, out string firstName, out string lastName)`

Generates a random name.

**Parameters:**

* `male`: If `true`, the name is for a male.
* `firstName`: Returns the first name.
* `lastName`: Returns the last name.

### `GetAppearance(bool male, int index)`

Gets an appearance.

**Parameters:**

* `male`: If `true`, the appearance is for a male.
* `index`: The index of the appearance.

**Returns:** `EmployeeAppearance`

### `GetVoice(bool male, int index)`

Gets a voice.

**Parameters:**

* `male`: If `true`, the voice is for a male.
* `index`: The index of the voice.

**Returns:** `VODatabase`

### `GetRandomAppearance(bool male, out int index, out AvatarSettings settings)`

Gets a random appearance.

**Parameters:**

* `male`: If `true`, the appearance is for a male.
* `index`: Returns the index of the appearance.
* `settings`: Returns the settings for the appearance.

### `GetEmployeePrefab(EEmployeeType type)`

Gets the prefab for an employee type.

**Parameters:**

* `type`: The type of employee to get the prefab for.

**Returns:** `Employee`

### `GetEmployeesByType(EEmployeeType type)`

Gets a list of employees by their type.

**Parameters:**

* `type`: The type of employee to get.

**Returns:** `List<Employee>`
