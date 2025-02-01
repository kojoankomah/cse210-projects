using System.Net.Sockets;

public class Customer
{
    // store customer details

    private string _name;
    private Address _address;

    // receive and store customer name and address from program through customer constructor

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // call IsInUSA fuction from Address class if address is from the country of USA

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
} 