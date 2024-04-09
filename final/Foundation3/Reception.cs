public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, string address, string rsvpEmail)
        : base(title, description, date, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nRSVP Email: {_rsvpEmail}\nEvent Type: Reception";
    }
}