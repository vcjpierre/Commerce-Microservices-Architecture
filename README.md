# Commerce - Microservice Architecture .NET Core

Sample project using a microservices oriented architecture and .NET Core

![alt text](https://images-s3-aws.s3.us-east-2.amazonaws.com/Commerce+Architecture.png "Commerce Architecture")

## Getting started 🚀

1. Update the connection strings of each Microservice.

2. Update web project ports:

- Clients.Authentication: localhost:60000
- Clients.WebClient: localhost:60001
- Api.Gateway.WebClient: localhost:50000
- Identity.Api: localhost:10000
- Catalog.Api: localhost:20000
- Customer.Api: localhost:30000
- Order.Api: localhost:40000

3. Execute the migrations:
   
```
update-database -context ApplicationDbContext
```

4. Add a default user to the database

``` sql
INSERT [Identity].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'cc7deafd-2977-4c1b-91ad-7b8d37a01ffe', N'admin', N'ADMIN', N'admin@admin.com', N'ADMIN@ADMIN.COM', 0, N'AQAAAAEAACcQAAAAEL5faIXPhAOdXYU+vAAKbF32yd2ONSGUdGJ6wo9jkhm8KKlLF/h5x0zjJbcPKt8WYg==', N'PS7QHYXIO4NUC65ZYEP4SBEYOXP4DTWA', N'e955992b-abf5-41d3-b504-ec6dc0632989', NULL, 0, 0, NULL, 1, 0, N'John', N'Doe')

```

- User: admin
- Email: admin@admin.com
- Password: 123456