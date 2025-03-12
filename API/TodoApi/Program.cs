using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var conString = builder.Configuration.GetConnectionString("ProductDb");
     
builder.Services.AddDbContext<TestDB>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProductDb")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.MapGet("/productdata", (TestDB testDb) => {
    var derp =  testDb.ProductData.FirstOrDefault();

    return "Thingy";
});

app.Run();