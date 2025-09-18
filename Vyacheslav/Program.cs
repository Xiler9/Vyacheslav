using Vyacheslav.Task1.Services;
using Vyacheslav.Task2.Services;
using Vyacheslav.Task3.Services;
using Vyacheslav.Task4.Services;
using Vyacheslav.Task5.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<IGreetings, Greetings>();
builder.Services.AddSingleton<ITreker, Treker>();
builder.Services.AddSingleton<INoteService, NoteService>();
builder.Services.AddSingleton<ICurrencyRateService, CurrencyRateService>();
builder.Services.AddSingleton<ICurrencyConverterService, CurrencyConverterService>();
builder.Services.AddSingleton<INotificationService, NotificationService>();
builder.Services.AddSingleton<ILoggingService, LoggingService>();
builder.Services.AddSingleton<IPriorityService, PriorityService>();
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