public interface IOrderService
{
    ///<summary>
    /// Принять заказ от клиента за определенным столом
    ///</summary>
    void CreateOrder(int table, MenuItem[] orderData);
    ///<summary>
    /// Принять платеж от клиента за заказ
    ///</summary>
    void AcceptPayment(int table, int amount);
}