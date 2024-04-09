public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string speaker, string description, DateTime date, string address, int capacity)
        : base(title, description, date, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}\nEvent Type: Lecture";
    }
}