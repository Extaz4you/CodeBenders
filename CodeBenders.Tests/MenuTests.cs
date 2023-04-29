using static Helpers;
[Trait("Меню", "")]
public class MenuTests
{
    private readonly OrderDb _db;
    private readonly OrderService _orderService;
    public MenuTests() => (_db, _orderService) = NewServiceAndDb();

    [Fact(DisplayName = "Полученное меню не может быть пустым")]
    public void Menu_cannot_be_empty()
    {
        Assert.NotEmpty(_db.GetFreeTables());
    }

    [Fact(DisplayName = "Меню соответствует указанному в файле")]
    public void Menu_equals_to_file_data()
    {
        MenuItem[] menu = _db.GetMenu();
        //todo: поправить на реальные блюда
        Assert.Contains(menu, item=> item.DishName == "Coca-cola");
        Assert.Contains(menu, item=> item.DishName == "Pizza");
        Assert.Contains(menu, item => item.DishName == "Chicken");
        //todo: поправить на реальный размер меню
        Assert.Equal(3, menu.Length);
    }
}