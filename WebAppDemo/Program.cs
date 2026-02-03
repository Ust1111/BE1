using WebAppDemo;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Главная страница (View)
app.MapGet("/", () => Results.Text(
    View.MainPage(),
    "text/html; charset=utf-8"));

// Страница 1
app.MapGet("/page1", () => Results.Text(
    View.Page1(),
    "text/html; charset=utf-8"));

// Страница 2
app.MapGet("/page2", () => Results.Text(
    View.Page2(),
    "text/html; charset=utf-8"));

app.Run();