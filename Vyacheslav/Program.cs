var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

//app.Use(async (context, next) =>
//{

//    await next();
//}
//);

app.MapGet("/", () => $"Главная страница");
app.Run();