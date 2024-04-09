using System;

public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _address;

    public Event(string title, string description, DateTime date, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate and Time: {_date}\nAddress: {_address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Title: {_title}\nDate: {_date.Date}";
    }
}