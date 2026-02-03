namespace WebAppDemo;

public static class View
{
    public static string MainPage()
    {
        return 
            "<h1>Главная</h1>" +
            "<p>Приложение запущено! Переходы:</p>" +
            "<li><a href='/page1'>Страница 1</a></li>" +
            "<li><a href='/page2'>Страница 2</a></li>";
    }
    
    public static string Page1()
    {
        return 
            "<h1>Страница 1</h1>" +
            "<p>Это первая страница.</p>" +
            "<a href='/'>Назад</a>";
    }
    
    public static string Page2()
    {
        return 
            "<h1>Страница 2</h1>" +
            "<p>Это вторая страница.</p>" +
            "<a href='/'>Назад</a>";
    }
}