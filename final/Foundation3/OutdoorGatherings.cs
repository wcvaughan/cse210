public class OutdoorGatherings : Events
{
    private string _weatherForecast;
    public OutdoorGatherings(string title, string description, string date, string time, Address address, string weatherForeCast)
     : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForeCast;
    }
    public override string DisplayEventDetails()
    {
        return base.DisplayEventDetails() + $"\nPlease prepare for {_weatherForecast} weather.";
    }
    public override string DisplayStandardDetails()
    {
        return base.DisplayEventDetails();
    }
    public override string DisplayShortDescription()
    {
        return $"Outdoor Gathering" + base.DisplayShortDescription();
    }
}