public class Order
{
    ///<summary>
    ///Номер стола
    ///</summary>
    public int Table { get; set; }
    //<summary>
    ///Заказанные блюда
    ///</summary>
    public MenuItem[] Dishes { get; set; } = new MenuItem[0];
}