# Employee Management

## Description
A Blazor WebAssembly application with an API backend for managing employees. The backend uses Entity Framework Core for data access.

## Installation
1. **Prerequisites:**
    - .NET 6 SDK
    - Visual Studio 2022
    - SQL Server (or another supported database)

2. **Install Entity Framework Core tools:**
    ```sh
    dotnet tool install --global dotnet-ef
    ```

3. **Create initial database migration:**
    ```sh
    dotnet ef migrations add InitialCreate
    ```

4. **Apply migrations to the database:**
    ```sh
    dotnet ef database update
    ```

## Usage
Usage details: To be filled later.

## Debugging Instructions
Debugging instructions: To be filled later.

## Infrastructure and Deployment
Infrastructure and deployment information: To be filled later.

## Results and Data Access
Results and data access: To be filled later.

## API Documentation
### Endpoints
- **GET /api/employees**
  - Description: Retrieves all employees.
  - Response: `200 OK` with a list of employees.

- **GET /api/employees/{id}**
  - Description: Retrieves an employee by ID.
  - Response: `200 OK` with the employee details or `404 Not Found` if the employee does not exist.

- **POST /api/employees**
  - Description: Creates a new employee.
  - Request Body: Employee object. Example: `{ "FirstName": "Jane", "LastName": "Smith", "Email": "jane.smith@example.com", "Department": "HR", "DateOfBirth": "1992-05-15T00:00:00", "Salary": 60000 }`
  - Response: `201 Created` with the created employee details or `400 Bad Request` if the request is invalid.

- **PUT /api/employees/{id}**
  - Description: Updates an existing employee.
  - Request Body: Employee object with updated details. Example: `{ "Id": 1, "FirstName": "John", "LastName": "Doe", "Email": "john.doe@example.com", "Department": "IT", "DateOfBirth": "1985-10-20T00:00:00", "Salary": 75000 }`
  - Response: `204 No Content` or `400 Bad Request` if the request is invalid.

- **DELETE /api/employees/{id}**
  - Description: Deletes an employee by ID.
  - Response: `204 No Content` or `404 Not Found` if the employee does not exist.

## Contributing
Contributing information: To be filled later.

## License
License: To be filled later.