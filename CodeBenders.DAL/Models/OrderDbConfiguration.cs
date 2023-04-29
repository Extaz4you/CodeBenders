///<summary>
///Конфигурация базы данных
///</summary>
public class OrderDbConfiguration
{
    ///<summary>
    ///Путь до файла с балансом в кассе
    ///</summary>
    public string MoneyBalanceFilePath { get; init; } = null!;
    ///<summary>
    ///Путь до файла с текущими заказами
    ///</summary>
    public string OrdersFilePath { get; init; } = null!;
    ///<summary>
    ///Путь до файла с информации по столам
    ///</summary>
    public string TablesFilePath { get; init; } = null!;
    ///<summary>
    ///Путь до файла с меню
    ///</summary>
    public string MenuFilePath { get; init; } = null!;

    ///<summary>
    ///Проверка валидности конфигурации
    ///</summary>
    public bool IsValid()
    {
        //todo: проверить что все необходимые файлы сущестует и готовы к работе
        return true;
        throw new NotImplementedException();
    }
}