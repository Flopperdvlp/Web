using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class HomeController : Controller
{
    // Метод для отображения формы
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    // Метод для обработки данных из формы
    [HttpPost]
    public IActionResult SubmitForm(string username, string email)
    {
        // Вывод данных в консоль
        Console.WriteLine($"Полученные данные: Имя = {username}, Email = {email}");

        // Дополнительно вернуть результат на страницу
        ViewBag.Message = $"Данные получены: Имя = {username}, Email = {email}";
        return View("Result"); // Переход на страницу с результатами
    }
}
