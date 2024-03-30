
# ASP.NET Core Web API with Password Hashing and PostgreSQL Storage
  This project is a demonstration of building a secure ASP.NET Core Web API with password hashing using salt and storing user credentials in a PostgreSQL database. By implementing proper password hashing techniques and utilizing a secure database storage mechanism, this API ensures that user passwords are adequately protected from common security threats like brute-force attacks and password leaks.
## Features

- Password Hashing with Salt: User passwords are securely hashed using a strong cryptographic algorithm along with a unique salt for each user. This ensures that even if two users have the same password, their hashed values will be different.
- PostgreSQL Database Storage: User credentials are stored in a PostgreSQL database, ensuring data integrity and security. PostgreSQL offers robust features for data management and provides a scalable solution for storing user information.
- ASP.NET Core Web API: The API is built using ASP.NET Core, a cross-platform framework for building modern, cloud-based applications. It provides a flexible and powerful environment for creating web APIs that can be hosted on various platforms.
## Technologies Used

**ASP.NET Core:** The primary framework for building web applications and APIs.

**C#:** The programming language used for backend logic and API.

**Swagger UI:** A tool to document and test APIs.

**PostgreSQL:** A lightweight, file-based database used for local development and testing.


## Run Locally

Clone the project
```bash
  git clone https://github.com/imdesai00/hashpassword.git
```

Navigate to the project directory.
```bash
  cd your-repo
```

Set up the necessary database configurations in appsettings.json. 
```bash
  dotnet build
  dotnet run
```
