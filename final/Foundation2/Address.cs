public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private int _zipCode;

    public Address(string streetAddress, string city, string state, string country, int zipCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
        _zipCode = zipCode;
    }
    public string Street => _streetAddress;
    public string City => _city;
    public string State => _state;
    public string Country => _country;
    public int ZipCode => _zipCode;

    public string DisplayAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state} {_country} {_zipCode}";
    }
    public bool CustomerLivesInUSA()
    {
        return _country == "USA";
    }

}