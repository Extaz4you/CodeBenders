public interface IOrderDb
{
    ///<summary>
    /// Получить доступное меню для ресторана
    ///</summary>
    MenuItem[] GetMenu();
    ///<summary>
    /// Получить свободные столы
    ///</summary>
    int[] GetFreeTables();
    ///<summary>
    /// Получить все имеющеяся столы
    ///</summary>
    int[] GetAllTables();
    ///<summary>
    /// Забронировать стол (или занять при заказе)
    ///</summary>
    void ReserveTable(int table);
    ///<summary>
    /// Записать заказ в бд
    ///</summary>
    void CreateOrder(Order order);
    ///<summary>
    /// Освободить стол
    ///</summary>
    void FreeTable(int table);
    ///<summary>
    /// Добавить денег на баланс
    ///</summary>
    void AddMoneyToBalance(int amount);
    ///<summary>
    /// Удаляет текущий заказ у стола
    ///</summary>
    void DeleteOrder(int table);
}