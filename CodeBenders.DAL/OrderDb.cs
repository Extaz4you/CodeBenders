public class OrderDb : IOrderDb
{
    ///<summary>
    /// Пути до файлов бд
    ///</summary>
    private readonly OrderDbConfiguration _configuration;
    public OrderDb(OrderDbConfiguration configuration)
    {
        _configuration = configuration;
        //todo: валидация конфигурации - все пути должны вести к существующим файлам
        if (_configuration.IsValid() == false)
        {
            //todo: бросать ошибку с сообщением о том, что конифигурация не валидна
        }
    }

    public void AddMoneyToBalance(int amount)
    {
        //todo: увеличить баланс в кассе
        throw new NotImplementedException();
    }

    public void CreateOrder(Order order)
    {
        //todo: Записать заказ в бд
        throw new NotImplementedException();
    }

    public void DeleteOrder(int table)
    {
        //todo: удаляет заказ у указанного стола
        throw new NotImplementedException();
    }

    public void FreeTable(int table)
    {
        //todo: освободить стол
        //throw new NotImplementedException();
        List<int> tables = new List<int>();
        tables.AddRange(GetFreeTables());
        tables.Add(table);
    }

    public int[] GetAllTables()
    {
        // Можно сделать хедер с AmountOfSitters
        return null;
    }

    public int[] GetFreeTables()
    {

        //todo: получить список свободных столов
        //throw new NotImplementedException();
        List<int> freetables = new List<int>();
        freetables.AddRange(GetFreeTables());
        return freetables.ToArray();
    }

    public MenuItem[] GetMenu()
    {
        return null;
    }

    public void ReserveTable(int table)
    {
        //todo: забронировать стол
        //throw new NotImplementedException();
        List<int> tables = new List<int>();
        tables.AddRange(GetFreeTables());
        tables.Remove(table);
    }
}