
# Migration 

## set migration
On consola with Package Manager Console
Ensure that you're using the correct assembly and that the type is neither abstract nor generic

```
add-migration AddBookToDb
```

## To Undo

To undo this action, use ` Remove-Migration`.

## update database

`
update-database
`

## CLI dotnet console 

- Add new change: `dotnet ef migrations add AddGenresTODB --project CodingWiki_DataAccess`
- Update Database" `dotnet ef database update --project CodingWiki_DataAccess`
- Get all migrations: `dotnet ef migrations list --project CodingWiki_DataAccess`

## Rollback

To Rollback we just need the migration Name like this `dotnet ef database update NameOfMigration`
 e.g: `dotnet ef database update InitialCreate`
This will revert all migrations and bring the database back to its original state (without any migrations applied).

**Note:**

This command only undoes the migrations applied to the database. The migration classes in your project will not be deleted, only the database changes will be undone.