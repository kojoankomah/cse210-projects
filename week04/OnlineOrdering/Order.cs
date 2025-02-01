using System.Net.Http.Headers;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;


    //receive and store customer class
    public Order(Customer customer){
        _customer = customer;
    }

    // Add product function to the list of products to create the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // calculate the total cost of the order
    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach(var product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _customer.LivesInUSA()? 5.00m : 35.00m;
        return total;
    }

    // get and make packing label string
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach(var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetID()})\n";
        }
        return label;
    }

    // get and make shipping label string
    
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n {_customer.GetName()}\n {_customer.GetAddress().ToString()}";
    }
}