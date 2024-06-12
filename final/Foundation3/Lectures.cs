public class Lectures : Events
{
    private string _speaker;
    private int _capacity;
    public Lectures(string title, string description, string date, string time, Address address, string speaker, int capacity)
     : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string DisplayEventDetails()
    {
        return base.DisplayEventDetails() + $"\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
    public override string DisplayStandardDetails()
    {
        return base.DisplayEventDetails();
    }
    public override string DisplayShortDescription()
    {
        return $"Lecture" + base.DisplayShortDescription();
    }
}