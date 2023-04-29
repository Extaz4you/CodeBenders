OrderDb db = new OrderDb(new OrderDbConfiguration
{
    MoneyBalanceFilePath = "",
    MenuFilePath = "",
    OrdersFilePath = "",
    TablesFilePath = ""
});
OrderService service = new OrderService(db);

//--------пример жизенного цикла заказа-------------
//получаем меню
var menu = db.GetMenu();
//получаем свободные столы
var tables = db.GetFreeTables();
//создаем заказ на первый свободный стол с первым блюдом в меню
service.CreateOrder(tables[0], new MenuItem[] { menu[0] });
//платим за заказ
service.AcceptPayment(tables[0], 100);
//--------------------------------------------------