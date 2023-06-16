<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/654449233/23.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1172266)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Grid for Blazor - Server Mode Data Processing
This example demonstrates the difference between local and server-side data loading strategies for a Blazor Server app connected to a large database via [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/).

## Use a Real Database
For simplicity, this example generates an in-memory database that does not use SQL queries. If you want to test the sample with a real database, use the link below to download a sample large database file:

[Download - Issues.zip](https://downloads.devexpress.com/blazor/issues.zip)

Unpack the archive into the project folder and change database connection settings in [Program.cs](./CS/Program.cs):
```cs
builder.Services.AddDbContext<IssuesContext>((sp, options) => {
    var env = sp.GetRequiredService<IWebHostEnvironment>();
    var dbPath = Path.Combine(env.ContentRootPath, "Issues.mdf");
    options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + dbPath);
}, contextLifetime: ServiceLifetime.Transient);
//builder.Services.AddDbContext<IssuesContext>((sp, options) => options.UseInMemoryDatabase("Issues"), contextLifetime: ServiceLifetime.Transient);
```

## Files to Review

- [Grid.razor](./CS/Pages/Grid.razor)
- [LocalData.razor](./CS/Pages/LocalData.razor)
- [ServerMode.razor](./CS/Pages/ServerMode.razor)
- [Program.cs](./CS/Program.cs)
- [IssuesContextInitializer.cs](./CS/Models/IssuesContextInitializer.cs)

## Documentation

- [Getting Started with the DevExpress Blazor Grid](https://docs.devexpress.com/Blazor/403625/grid/get-started-with-grid)
- [Large Data (Server Mode Sources)](https://docs.devexpress.com/Blazor/403737/components/grid/bind-to-data#large-data-server-mode-sources)
    
## Free Trial
Download a 30-day trial of DevExpress Blazor components here: [Free DevExpress Trial](https://www.devexpress.com/products/try/).
