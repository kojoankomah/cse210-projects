public class Product
{
    // store product details

    private string _name;
    private string _id;
    private int _quantity;
    private decimal _price;

    // receive and store product details from program through constructors

    public Product(string name, string id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // get the total product cost

    public decimal GetTotalCost()
    {
        return _price*_quantity;
    }

    // get name of product 

    public string GetName()
    {
        return _name;
    }

    // get product ID

    public string GetID()
    {
        return _id;
    }
}