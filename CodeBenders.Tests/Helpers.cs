public static class Helpers
{
    public static (OrderDb, OrderService) NewServiceAndDb()
    {
        var dbConfig = GetNewOrderDbConfiguration();
        var db = new OrderDb(dbConfig);
        return (db, new OrderService(db));
    }

    public static OrderDbConfiguration GetNewOrderDbConfiguration()
    {
        var currDir = Directory.GetCurrentDirectory();

        var moneyFilePath = EmptyFileIfExists("money");
        var ordersFilePath = EmptyFileIfExists("orders");

        var config = new OrderDbConfiguration
        {
            MoneyBalanceFilePath = moneyFilePath,
            OrdersFilePath = ordersFilePath,
            MenuFilePath = Path.Combine(currDir, "menu"),
            TablesFilePath = Path.Combine(currDir, "tables")
        };
        return config;
    }

    private static string EmptyFileIfExists(string filename)
    {
        var currentDir = Directory.GetCurrentDirectory();
        var fullFilePath = Path.Combine(currentDir, filename);
        if (File.Exists(fullFilePath))
            File.Delete(fullFilePath);

        File.Create(fullFilePath).Close();
        return fullFilePath;
    }
}