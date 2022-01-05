# Postgres EF migration POC

## Packages
- Npgsql.EntityFrameworkCore.Postgresql
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools.DotNet
- EntityFramework6.Npgsql
- adding dotnet-ef (https://www.nuget.org/packages/dotnet-ef/)

    ``$ dotnet tool install --global dotnet-ef --version 6.0.1``

## Docker Container 
 docker-compose.yml inside .ci folder will create docker container for Postgres DB and PgAdmin


``$ cd .ci`` 

``$ docker-compose up -d``


## EF Migration (dotnet ef)

###Adds Migration File.

``dotnet ef migrations add {migration-name} ``\

The directory use to output the files. Paths are relative to the target project directory. Defaults to "Migrations".

### Add Migrations Script

Generates a SQL script from migrations.

``dotnet ef migrations script 0 {MigrationName} -i -o ./scripts/{OutputFilename}.sql ``

Creates a script for the next Migration 

``dotnet ef migrations script {From MigrationName} {To MigrationName} -i -o ./scripts/{OutputFilename}.sql``

Note: ``--idempotent`` or	``-i``	Generate a script that can be used on a database at any migration.
### Update Database 

Updates the database to the last migration or to a specified migration.

``dotnet ef database update`` or
``dotnet ef database update {MigrationName}``



##Reference

dotnet-ef (https://docs.microsoft.com/en-us/ef/core/cli/dotnet)

Postgres DataType-EF Mapping (https://www.npgsql.org/efcore/mapping/general.html?tabs=data-annotations#explicitly-specifying-data-types)

Postgress EF - (https://www.npgsql.org/ef6/)

