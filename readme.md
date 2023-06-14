# Grid for Blazor - Server Mode Data Processing
This example demonstrates the difference between the local and server-side data loading approaches in a Blazor Server app connected to a larve database via [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/).

## Use a Real Database
For simplicity, this example generates an in-memory database that operates without SQL queries. If you want to test the sample with a real database, follow the link below to download the database file:
[Download - Issues.zip](https://www.dropbox.com/s/fu8j0l1r3fkj1vd/Issues.zip?dl=0)
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

- [Index.razor](./CS/Pages/Index.razor)
- [Program.cs](./CS/Program.cs)

## Documentation

- [Get Started with Grid](https://docs.devexpress.com/Blazor/403625/grid/get-started-with-grid)
- [Large Data (Server Mode Sources)](https://docs.devexpress.com/Blazor/403737/components/grid/bind-to-data#large-data-server-mode-sources)
    
## Free Trial
Download a 30-day trial of DevExpress Blazor components here: [Free DevExpress Trial](devexpress.com/try).
