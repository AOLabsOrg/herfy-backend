- Herfy Backend

Backend for Herfy, an open-source platform connecting clients with artisans for handmade and heritage products (e.g., pottery, brasswork). Built with .NET Core and PostgreSQL.

## Features

- User management (registration, login, profiles, role: client or artisan).
- Product listings (handmade and heritage items).
- Order management.
- Chat between clients and artisans.
- Reviews and ratings.

## Tech Stack

- **.NET Core 8.0**: Web API framework.
- **SQL Server**: Database.
- **Entity Framework Core**: ORM.
- **Swagger**: API documentation.
- **JWT**: Authentication.

## Setup Instructions

1. **Clone the repository**:

   ```bash
   git clone https://github.com/AOLabsOrg/herfy-backend.git
   cd harfy-backend
   ```

2. **Install .NET SDK**: Download from here.

3. **Install SQL Server**: Download from here.

4. **Configure environment**:

   - Copy `src/HerfyBackend/appsettings.json` to `appsettings.Development.json`.
   - Update `ConnectionStrings.DefaultConnection` with your PostgreSQL credentials.
   - Update `Jwt.SecretKey` with a secure key.

**Run migrations**:

```bash
cd src/HerfyBackend
dotnet ef database update
```

1. **Run the project**:

   ```bash
   dotnet run
   ```

2. **Access Swagger**: Open `https://localhost:5001/swagger`.

## Contributing

See CONTRIBUTING.md for guidelines.

## License

This project is licensed under the MIT License. See LICENSE for details.

## Contact

For questions, reach out via GitHub Issues or email \[aolabsorg@gmail.com\].