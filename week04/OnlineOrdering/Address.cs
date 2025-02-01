public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // store address details from the given addresses in the program

    public Address(string street, string city, string state, string country)
    {
        _city = city;
        _country = country;
        _state = state;
        _street = street;
    }

    // if address is in USA 

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    // return string for address

    public override string ToString()
    {
        return $"{_street}\n {_city}, {_state}\n {_country}";
    }
}