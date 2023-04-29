using static Helpers;
namespace CodeBenders.Tests;

[Trait("Столы", "")]
public class TablesTests
{
    private readonly OrderDb _db;
    private readonly OrderService _orderService;
    public TablesTests() => (_db, _orderService) = NewServiceAndDb();

    [Fact(DisplayName = "Полученный список всех столов не может быть пустым")]
    public void Existing_tables_is_not_empty()
    {
        Assert.NotEmpty(_db.GetAllTables());
    }

    [Fact(DisplayName = "Файл со столами считывается правильно")]
    public void GetAllTables_reads_tables_file_correctly()
    {
        var tables = _db.GetAllTables();

        Assert.Contains(1, tables);
        Assert.Contains(2, tables);
        Assert.Contains(3, tables);
        Assert.Contains(6, tables);
        Assert.Contains(7, tables);
        Assert.Contains(8, tables);
        Assert.Equal(6, tables.Length);
    }

    [Fact(DisplayName = "Все существующие столы изначально свободны")]
    public void All_existing_tables_free_from_start()
    {
        var existingTables = _db.GetAllTables();
        var freeTables = _db.GetFreeTables();
        Assert.Equal(existingTables.Order(), freeTables.Order());
    }

    [Fact(DisplayName = "Стол можно зарезервировать")]
    public void Table_can_be_reserved()
    {
        var existingTables = _db.GetAllTables();
        _db.ReserveTable(existingTables[0]);
        var freeTables = _db.GetFreeTables();
        Assert.Equal(existingTables.Length - 1, freeTables.Length);
        Assert.DoesNotContain(freeTables, table => table == existingTables[0]); //todo: хз че инт не сожрал, мб студия лагает
    }

    [Fact(DisplayName = "Стол можно освободить")]
    public void Table_can_set_free_after_reserve()
    {
        var existingTables = _db.GetAllTables();
        _db.ReserveTable(existingTables[0]);
        _db.FreeTable(existingTables[0]);
        var freeTables = _db.GetFreeTables();
        Assert.Equal(existingTables.Order(), freeTables.Order());
    }
}