var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/datetime", async context =>
{
    DateTimeOffset currentDateTimeOffset = DateTimeOffset.Now;
    string currentDateTime = currentDateTimeOffset.ToString("yyyy-MM-dd HH:mm:ss zzz");
    await context.Response.WriteAsync(currentDateTime);
});
app.Run();
