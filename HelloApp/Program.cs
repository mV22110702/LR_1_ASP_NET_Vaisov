var builder = WebApplication.CreateBuilder();
var app = builder.Build();

var randGenerator = new Random();
const int RANDOM_NUMBER_CEIL = 101;

var company = new Company() { EmployeeCount = 1, Name = "Truck Inc.", TaxNumber = "1234567890" };

app.Use(async (context, next) =>
{
    await next();
    if (context.Response.StatusCode == StatusCodes.Status404NotFound)
    {
        await context.Response.WriteAsync("Requested endpoint has not been found!");
    }
});

app.MapGet("/company", async (context) => await context.Response.WriteAsJsonAsync(company));
app.MapGet("/random/number", async (context) => {
    var randomNumber = randGenerator.Next(RANDOM_NUMBER_CEIL);
    await context.Response.WriteAsync(randomNumber.ToString());
});

app.MapGet("/",async (context) => await context.Response.WriteAsync($"Root route is here ({context.Request.Path})."));

app.Run();


