
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