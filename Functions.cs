namespace Mission3;

public class FoodItem
{
    public string Name;
    public string Category;
    public int Quantity;
    public DateTime ExpirationDate;

    public FoodItem(string name, string category, int quantity, DateTime expirationDate)
    {
        this.Name = name;
        this.Category = category;
        this.Quantity = quantity;
        this.ExpirationDate = expirationDate;
    }
}
