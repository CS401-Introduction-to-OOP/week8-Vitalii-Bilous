namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _items = new List<T>();

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var item in _items)
        {
            totalCost += item.CalculateCost();
        }
        
        return totalCost;
    }
}
        
    
    