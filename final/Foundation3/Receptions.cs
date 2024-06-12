public class Receptions : Events
{
    private string _rsvpEmail;
    public Receptions(string title, string description, string date, string time, Address address, string rsvpEmail)
     : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public override string DisplayEventDetails()
    {
        return base.DisplayEventDetails() + $"\nPlease RSVP to {_rsvpEmail}";
    }
    public override string DisplayStandardDetails()
    {
        return base.DisplayEventDetails();
    }
    public override string DisplayShortDescription()
    {
        return $"Reception" + base.DisplayShortDescription();
    }
}