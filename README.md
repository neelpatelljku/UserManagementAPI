# Coursera-Module-5-Graded-Assignment
**Yo! guys whoever is checking please do pass me :)**
# User Management API

## Project Overview
The **User Management API** is a back-end service developed for TechHive Solutions to manage user records for HR and IT departments. It provides CRUD operations (Create, Read, Update, Delete) for user management.

This project was developed using **ASP.NET Core Web API** with the assistance of **Microsoft Copilot**, which helped scaffold the project, generate API endpoints, and enhance functionality.

---
## Setup Instructions

### 1. Prerequisites
Ensure you have the following installed:
- **Visual Studio** (latest version)
- **.NET SDK** (latest version)
- **SQL Server** (if using a database)
- **Postman** (for testing API calls)

### 2. Clone the Repository
```sh
 git clone https://github.com/your-username/UserManagementAPI.git
 cd UserManagementAPI
```

### 3. Open in Visual Studio
1. Open **Visual Studio**.
2. Click **File** → **Open** → **Project/Solution**.
3. Select the `UserManagementAPI.csproj` file.

### 4. Run the API
Press **Ctrl + F5** or execute:
```sh
dotnet run
```
The API should start at `https://localhost:5001`.

---
## API Endpoints

### 1. Retrieve All Users
**GET** `/api/users`
```json
Response: [
  { "id": 1, "name": "John Doe", "email": "john@example.com", "age": 30 }
]
```

### 2. Retrieve a User by ID
**GET** `/api/users/{id}`
```json
Response: { "id": 1, "name": "John Doe", "email": "john@example.com", "age": 30 }
```

### 3. Create a User
**POST** `/api/users`
```json
Request Body: { "name": "Jane Doe", "email": "jane@example.com", "age": 28 }
```
```json
Response: { "id": 2, "name": "Jane Doe", "email": "jane@example.com", "age": 28 }
```

### 4. Update a User
**PUT** `/api/users/{id}`
```json
Request Body: { "name": "Jane Smith", "email": "jane.smith@example.com", "age": 29 }
```

### 5. Delete a User
**DELETE** `/api/users/{id}`
Response: `204 No Content`

---
## Testing Instructions

### 1. Using Postman
1. Open **Postman**.
2. Enter the API URL (e.g., `https://localhost:5001/api/users`).
3. Send **GET, POST, PUT, DELETE** requests as per the API endpoints.

### 2. Using Swagger
1. Run the API.
2. Open a browser and navigate to:
   ```
   https://localhost:5001/swagger
   ```
3. Use the interactive UI to test the API.

---
## How Microsoft Copilot Assisted
Microsoft Copilot was used to:
- Generate the **initial project structure** and boilerplate code.
- Create **CRUD API endpoints** efficiently.
- Improve **error handling** and **data validation**.
- Suggest **Swagger integration** for API documentation.
- Help structure **Postman testing** instructions.

By leveraging Copilot, development time was reduced, and code quality was enhanced.

---
## Future Enhancements
- **JWT Authentication** for secure access.
- **Database Integration** using Entity Framework Core.
- **Role-Based Access Control** for user permissions.

---
## Author
**Your Name**  
TechHive Solutions  

---
## License
This project is licensed under the **MIT License**.

