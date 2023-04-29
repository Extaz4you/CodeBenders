public class OrderService : IOrderService
{
    private readonly OrderDb _db;
    public OrderService(OrderDb db)
    {
        _db = db;
    }
   
    public void CreateOrder(int table, MenuItem[] orderData)
    {
        //todo: проверить что стол не занят
        //todo: сделать стол занятым
        //todo: записать заказ в бд
        throw new NotImplementedException();
    }
    
    public void AcceptPayment(int table, int amount)
    {
        //todo: проверить что стоимость заказа у этого стола соответствует размеру платежа
        //todo: увеличить баланс в кассе
        //todo: удалить заказ у стола 
        //todo: сделать стол свободным
        throw new NotImplementedException();
    }
}