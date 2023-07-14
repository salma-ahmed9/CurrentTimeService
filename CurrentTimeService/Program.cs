var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/datetime", () =>
{
    DateTimeOffset currentDateTimeOffset = DateTimeOffset.Now;
    string currentDateTime = currentDateTimeOffset.ToString("yyyy-MM-dd HH:mm:ss zzz");
    return Results.Text(currentDateTime, "text/plain");
});
app.Run();
