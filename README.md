# clean-arch-mvc
API Template using Clean Architecture

Creating Migrations

Inside of NetCleanArchMvc.Infra.Data run:

`dotnet ef migrations add MigrationName --startup-project ../NetCleanArchMvc.WebUI -- --environment Development`

Update Database

`dotnet ef database update --startup-project ../NetCleanArchMvc.WebUI -- --environment Development`