public class Events
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    public Events(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public virtual string DisplayEventDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nTime: {_time} Date: {_date}\nAddress: {_address.DisplayAddress()}";
    }

    public virtual string DisplayStandardDetails()
    {
        return "";
    }
    public virtual string DisplayShortDescription()
    {
        return $"Title: {_title} Date: {_date}";
    }

}
