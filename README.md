# WebApiWithController

## Setup

Run the following command to create a new docker container with SQL Server 2022:

```sh
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=passWord1*" \
   -p 1433:1433 --name sql2022 --hostname sql2022 \
   -d \
   mcr.microsoft.com/mssql/server:2022-latest
```

One-liner if the above command does not work in your CLI:

```sh
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=passWord1*" -p 1433:1433 --name sql2022 --hostname sql2022 -d mcr.microsoft.com/mssql/server:2022-latest
```

Add the following to the `appsettings.json` file:

```json
{
  "ConnectionStrings": {
    "HeroDbContext": "Server=localhost,1433;Database=DatabaseName;User Id=sa;Password=passWord1*;TrustServerCertificate=True;Connection Timeout=30;"
  }
}
```