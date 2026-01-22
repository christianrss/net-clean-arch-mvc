# clean-arch-mvc
API Template using Clean Architecture

Creating Migrations

`dotnet ef migrations add MigrationName --project NetCleanArchMvc.Infra.Data --startup-project ../NetCleanArchMvc.WebUI --context ApplicationDbContext --verbose -- --environment Development`

Update Database

`dotnet ef database update --project NetCleanArchMvc.Infra.Data --startup-project ../NetCleanArchMvc.WebUI --context ApplicationDbContext --verbose -- --environment Development`

Remove Migrations

`dotnet ef migrations remove --project NetCleanArchMvc.Infra.Data --startup-project ../NetCleanArchMvc.WebUI --context ApplicationDbContext --verbose -- --environment Development`
