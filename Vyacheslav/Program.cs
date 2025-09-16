using Vyacheslav.Task1.Services;
using Vyacheslav.Task2.Services;
using Vyacheslav.Task3.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<IGreetings, Greetings>();
builder.Services.AddSingleton<ITreker, Treker>();
builder.Services.AddSingleton<INoteService, NoteService>();
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